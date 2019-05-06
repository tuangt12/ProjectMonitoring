
namespace ProjectMonitoring.Administration.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using Serenity.Web.Providers;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Configuration;
    using System.Data;
    using System.Web.Security;
    using MyRow = Entities.UserRow;
    using UserPreferenceRow = Common.Entities.UserPreferenceRow;

    public partial class UserRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }
        public static readonly bool isPublicDemo;

        static UserRepository()
        {
            isPublicDemo = ConfigurationManager.AppSettings["IsPublicDemo"] == "1";
        }

        public static void CheckPublicDemo(int? userID)
        {
            if (userID == 1 && isPublicDemo)
                throw new ValidationException("Sorry, but no changes are allowed in public demo on ADMIN user!");
        }

        public SaveResponse Create(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Create);
        }

        public SaveResponse Update(IUnitOfWork uow, SaveRequest<MyRow> request)
        {
            return new MySaveHandler().Process(uow, request, SaveRequestType.Update);
        }

        public DeleteResponse Delete(IUnitOfWork uow, DeleteRequest request)
        {
            return new MyDeleteHandler().Process(uow, request);
        }

        public UndeleteResponse Undelete(IUnitOfWork uow, UndeleteRequest request)
        {
            return new MyUndeleteHandler().Process(uow, request);
        }

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        public static string ValidateDisplayName(IDbConnection connection, string displayName, Int32? existingUserId)
        {
            displayName = displayName.TrimToNull();

            if (displayName == null)
                throw DataValidation.RequiredError(fld.DisplayName.Name, fld.DisplayName.Title);

            return displayName;
        }

        public static string ValidatePassword(string username, string password, bool isNewUser)
        {
            password = password.TrimToNull();

            if (password == null ||
                password.Length < 5)
                throw new ValidationError("PasswordLength", "Password",
                    String.Format(Texts.Validation.MinRequiredPasswordLength, 5));

            return password;
        }

        private class MySaveHandler : SaveRequestHandler<MyRow>
        {
            private string password;

            public static MyRow GetUser(IDbConnection connection, BaseCriteria filter)
            {
                var row = new MyRow();
                if (new SqlQuery().From(row)
                    .Select(
                        fld.UserId,
                        fld.Username,
                        fld.DisplayName,
                        fld.PasswordHash,
                        fld.PasswordSalt,
                        fld.IsActive)
                    .Where(filter)
                    .GetFirst(connection))
                {
                    return row;
                }

                return null;
            }

            /// <summary>
            ///         Thiết đặt quyền chỉnh sửa đối với các Row (ở phía server)
            /// </summary>
            /// <param name="editable"></param>
            protected override void GetEditableFields(HashSet<Field> editable)
            {
                base.GetEditableFields(editable);

                if (!Authorization.HasPermission(Administration.PermissionKeys.Security))
                {
                    editable.Remove(fld.Source);
                    editable.Remove(fld.IsActive);
                }
            }

            /// <summary>
            ///     Lưu giá trị khi tạo mới hoặc cập nhật đối với ClassList
            /// </summary>
            protected override void AfterSave()
            {
                base.AfterSave();

                if (Row.ClassList != null)
                {
                    // Lấy ra các trường trong UserClass
                    var mc = ProjectMonitoring.Entities.UserClassesRow.Fields;
                    // Nếu là tạo mới thì oldList = null
                    // Còn nếu là Update thì lưu giá trị cũ vào oldList (là danh sách cũ)
                    // lưu theo UserId
                    var oldList = IsCreate ? null :
                        // Connection là thuộc tính của SaveRequestHandler
                        // trả về kết nối hiện tại đang được sử dụng

                        // List sẽ chọn ra các bản ghi phù hợp với điều kiện trong ngoặc
                        // This.Row trả về giá trị của bản ghi hiện tại vừa được thực hiện chỉnh sửa
                        Connection.List<ProjectMonitoring.Entities.UserClassesRow>(
                            mc.UserId == this.Row.UserId.Value);

                    // DetailListSaveHandler cho biết danh sách cũ và danh sách mới
                    // và một biến x, ở đây dại diện cho UserId
                    // để liên kết các bản ghi thông tin Class với UserId hiện tại
                    new Common.DetailListSaveHandler<ProjectMonitoring.Entities.UserClassesRow>(
                        oldList, Row.ClassList,
                        // UnitOfWork là một đối tượng bao gồm các tác vụ hiện tại
                        // gọi tới hàm Process để thực thi tác vụ hiện tại
                        x => x.UserId = Row.UserId.Value).Process(this.UnitOfWork);
                }

                BatchGenerationUpdater.OnCommit(this.UnitOfWork, fld.GenerationKey);
            }

            private static bool IsInvariantLetter(Char c)
            {
                return (c >= 'A' && c <= 'Z') ||
                    (c >= 'a' && c <= 'z');
            }

            private static bool IsDigit(Char c)
            {
                return (c >= '0' && c <= '9');
            }

            private static bool IsValidEmailChar(Char c)
            {
                return IsInvariantLetter(c) ||
                    IsDigit(c) ||
                    c == '.' ||
                    c == '_' ||
                    c == '-' ||
                    c == '@';
            }

            public static bool IsValidUsername(string name)
            {
                if (name == null ||
                    name.Length < 0)
                    return false;

                var c = name[0];
                if (!IsInvariantLetter(c))
                    return false;

                for (var i = 1; i < name.Length - 1; i++)
                {
                    c = name[i];
                    if (!IsValidEmailChar(c))
                        return false;
                }

                return true;
            }

            public static string ValidateUsername(IDbConnection connection, string username, Int32? existingUserId)
            {
                username = username.TrimToNull();

                if (username == null)
                    throw DataValidation.RequiredError(fld.Username.Name, fld.Username.Title);

                if (!IsValidUsername(username))
                    throw new ValidationError("InvalidUsername", "Username",
                        "Usernames should start with letters, only contain letters and numbers!");

                var existing = GetUser(connection,
                    new Criteria(fld.Username) == username |
                    new Criteria(fld.Username) == username.Replace('I', 'İ'));

                if (existing != null && existingUserId != existing.UserId)
                    throw new ValidationError("UniqueViolation", "Username",
                        "A user with same name exists. Please choose another!");

                return username;
            }

            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                if (IsUpdate)
                {
                    CheckPublicDemo(Row.UserId);

                    if (Row.IsAssigned(fld.Password) && !Row.Password.IsEmptyOrNull())
                        password = Row.Password = ValidatePassword(Old.Username, Row.Password, false);

                    if (Row.Username != Old.Username)
                        Row.Username = MySaveHandler.ValidateUsername(this.Connection, Row.Username, Old.UserId.Value);

                    if (Row.DisplayName != Old.DisplayName)
                        Row.DisplayName = ValidateDisplayName(this.Connection, Row.DisplayName, Old.UserId.Value);
                }

                if (IsCreate)
                {
                    this.Row.Username = ValidateUsername(this.Connection, this.Row.Username, null);
                    this.Row.DisplayName = ValidateDisplayName(this.Connection, this.Row.DisplayName, null);
                    password = ValidatePassword(Row.Username, Row.Password, true);
                }
            }

            protected override void SetInternalFields()
            {
                base.SetInternalFields();

                if (IsCreate)
                {
                    Row.Source = "site";
                    Row.IsActive = Row.IsActive ?? 1;
                }

                if (IsCreate || !Row.Password.IsEmptyOrNull())
                {
                    string salt = null;
                    Row.PasswordHash = GenerateHash(password, ref salt);
                    Row.PasswordSalt = salt;
                }
            }

            //protected override void AfterSave()
            //{
            //    base.AfterSave();

            //    BatchGenerationUpdater.OnCommit(this.UnitOfWork, fld.GenerationKey);
            //}
        }

        public static string CalculateHash(string password, string salt)
        {
            return SiteMembershipProvider.ComputeSHA512(password + salt);
        }

        public static string GenerateHash(string password, ref string salt)
        {
            salt = salt ?? Membership.GeneratePassword(5, 1);
            return CalculateHash(password, salt);
        }

        private class MyDeleteHandler : DeleteRequestHandler<MyRow>
        {
            protected override void ValidateRequest()
            {
                base.ValidateRequest();

                CheckPublicDemo(Row.UserId);
            }

            protected override void OnBeforeDelete()
            {
                base.OnBeforeDelete();

                new SqlDelete(UserPreferenceRow.Fields.TableName)
                    .Where(UserPreferenceRow.Fields.UserId == Row.UserId.Value)
                    .Execute(Connection, ExpectedRows.Ignore);

                new SqlDelete(Entities.UserRoleRow.Fields.TableName)
                    .Where(Entities.UserRoleRow.Fields.UserId == Row.UserId.Value)
                    .Execute(Connection, ExpectedRows.Ignore);

                new SqlDelete(Entities.UserPermissionRow.Fields.TableName)
                    .Where(Entities.UserPermissionRow.Fields.UserId == Row.UserId.Value)
                    .Execute(Connection, ExpectedRows.Ignore);


                /// Xử lý khi xóa với vấn đề khóa ngoại
                // Lấy ra các trường
                var mc = ProjectMonitoring.Entities.UserClassesRow.Fields;
                // Sửa câu truy vấn 
                foreach (var detailID in Connection.Query<Int32>(
                    new SqlQuery()
                        .From(mc)
                        .Select(mc.Id) // UserClassId
                        .Where(mc.UserId == Row.UserId.Value)))
                {
                    new DeleteRequestHandler<ProjectMonitoring.Entities.UserClassesRow>().Process(this.UnitOfWork,
                        new DeleteRequest
                        {
                            EntityId = detailID
                        });
                }
            }
        }

        private class MyUndeleteHandler : UndeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow>
        {
            
            /// <summary>
            ///     Ghi đè phương thức OnReturn để thêm ClassList vào hàng của User
            ///     ngay trước khi trả về từ phía dịch vụ
            /// </summary>
            protected override void OnReturn()
            {
                base.OnReturn();

                var mc = ProjectMonitoring.Entities.UserClassesRow.Fields;
                // Sử dụng overload của Connection.List để chỉnh sửa câu truy vấn select
                Row.ClassList = Connection.List<ProjectMonitoring.Entities.UserClassesRow>(q => q
                    .SelectTableFields()
                    // Lấy ra trường ClassCode trong UserClassesRow
                    .Select(mc.ClassClassCode)
                    .Select(mc.ClassSubjectCode)
                    .Select(mc.SubjectName)
                    // Với điều kiện UserId trong bảng trùng với UserId hiện tại
                    .Where(mc.UserId == Row.UserId.Value));
            }
            
        }

        /// <summary>
        ///         Tùy chỉnh danh sách hiển thị của bảng User với từng user khác nhau
        /// </summary>
        private class MyListHandler : ListRequestHandler<MyRow>
        {
            /// <summary>
            ///         Áp dụng bộ lọc để chỉ lọc ra user hiện đang đăng nhập để hiển thị
            /// </summary>
            /// <param name="query">câu lệnh sql</param>
            protected override void ApplyFilters(SqlQuery query)
            {
                base.ApplyFilters(query);
                // Lấy thông tin của user đang đăng nhập
                var user = (UserDefinition)Authorization.UserDefinition;
                // Nếu user hiện tại không có quyền admin
                if (!Authorization.HasPermission(PermissionKeys.Security))
                    // thì chỉ hiển thị thông tin của chính mình
                    query.Where(fld.UserId == user.UserId);
            }
        }
    }
}
