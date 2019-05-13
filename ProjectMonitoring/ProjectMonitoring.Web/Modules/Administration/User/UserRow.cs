
namespace ProjectMonitoring.Administration.Entities
{
    using Newtonsoft.Json;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;

    [ConnectionKey("Default"), Module("Administration"), TableName("Users")]
    [DisplayName("Users"), InstanceName("User")]

    //[ReadPermission(PermissionKeys.Security)]
    [ReadPermission(ProjectMonitoring.PermissionKeys.General)]
    [ModifyPermission(ProjectMonitoring.PermissionKeys.General)]

    [LookupScript(Permission = ProjectMonitoring.PermissionKeys.General)]
    [JsonConverter(typeof(JsonRowConverter))]
    public sealed class UserRow : LoggingRow, IIdRow, INameRow, IIsActiveRow
    {
        // Id trong bảng User (thuộc database Default)
        [DisplayName("User Id"), Identity]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }
        
        // Tên đăng nhập của sinh viên (hoặc giáo viên)
        [DisplayName("Username"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String Username
        {
            get { return Fields.Username[this]; }
            set { Fields.Username[this] = value; }
        }
        
        // Mã số sinh viên
        [DisplayName("Student Code"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String UserCode
        {
            get { return Fields.UserCode[this]; }
            set { Fields.UserCode[this] = value; }
        }

        // Ngày sinh
        [DisplayName("Birthday"), Size(100)]
        public DateTime? Birthday
        {
            get { return Fields.Birthday[this]; }
            set { Fields.Birthday[this] = value; }
        }

        // Số điện thoại
        [DisplayName("Phone"), Size(100), NotNull, LookupInclude]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        // Hệ đang học
        [DisplayName("Level"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String Level
        {
            get { return Fields.UserCode[this]; }
            set { Fields.UserCode[this] = value; }
        }

        [DisplayName("Source"), Size(4), NotNull, Insertable(false), Updatable(false), DefaultValue("site")]
        public String Source
        {
            get { return Fields.Source[this]; }
            set { Fields.Source[this] = value; }
        }

        [DisplayName("Password Hash"), Size(86), NotNull, Insertable(false), Updatable(false), MinSelectLevel(SelectLevel.Never)]
        public String PasswordHash
        {
            get { return Fields.PasswordHash[this]; }
            set { Fields.PasswordHash[this] = value; }
        }

        [DisplayName("Password Salt"), Size(10), NotNull, Insertable(false), Updatable(false), MinSelectLevel(SelectLevel.Never)]
        public String PasswordSalt
        {
            get { return Fields.PasswordSalt[this]; }
            set { Fields.PasswordSalt[this] = value; }
        }


        // Họ và tên đầy đủ
        [DisplayName("Display Name"), Size(100), NotNull, QuickSearch, LookupInclude]
        public String DisplayName
        {
            get { return Fields.DisplayName[this]; }
            set { Fields.DisplayName[this] = value; }
        }

        // Địa chỉ email
        [DisplayName("Email"), Size(100)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        // Danh sách lớp hiện tại
        //[MasterDetailRelation(foreignKey: "UserId", IncludeColumns = "ClassSubjectCode")]
        [DisplayName("Class List"), NotMapped]
        public List<ProjectMonitoring.Entities.UserClassesRow> ClassList
        {
            get { return Fields.ClassList[this]; }
            set { Fields.ClassList[this] = value; }
        }

        [DisplayName("User Image"), Size(100)]
        [ImageUploadEditor(FilenameFormat = "UserImage/~", CopyToHistory = true)]
        public String UserImage
        {
            get { return Fields.UserImage[this]; }
            set { Fields.UserImage[this] = value; }
        }

        [DisplayName("Password"), Size(50), NotMapped]
        public String Password
        {
            get { return Fields.Password[this]; }
            set { Fields.Password[this] = value; }
        }

        [NotNull, Insertable(false), Updatable(true)]
        public Int16? IsActive
        {
            get { return Fields.IsActive[this]; }
            set { Fields.IsActive[this] = value; }
        }

        [DisplayName("Confirm Password"), Size(50), NotMapped]
        public String PasswordConfirm
        {
            get { return Fields.PasswordConfirm[this]; }
            set { Fields.PasswordConfirm[this] = value; }
        }

        [DisplayName("Last Directory Update"), Insertable(false), Updatable(false)]
        public DateTime? LastDirectoryUpdate
        {
            get { return Fields.LastDirectoryUpdate[this]; }
            set { Fields.LastDirectoryUpdate[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.UserId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Username; }
        }

        Int16Field IIsActiveRow.IsActiveField
        {
            get { return Fields.IsActive; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field UserId;
            public StringField Username;
            public StringField Source;
            public StringField PasswordHash;
            public StringField PasswordSalt;
            public StringField DisplayName;
            public StringField Email;
            public StringField UserImage;
            public DateTimeField LastDirectoryUpdate;
            public Int16Field IsActive;

            public StringField Password;
            public StringField PasswordConfirm;
            public StringField UserCode;
            public DateTimeField Birthday;
            public StringField Phone;
            public StringField Level;

            // Khai báo ClassList để khi thêm mới Class cho User thì có thể lưu lại được ở phía server
            public readonly RowListField<ProjectMonitoring.Entities.UserClassesRow> ClassList;
        }
    }
}