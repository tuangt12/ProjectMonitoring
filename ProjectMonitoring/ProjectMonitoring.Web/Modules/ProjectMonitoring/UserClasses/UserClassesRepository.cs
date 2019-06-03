
namespace ProjectMonitoring.ProjectMonitoring.Repositories
{
    using Serenity;
    using Serenity.Data;
    using Serenity.Services;
    using System;
    using System.Data;
    using MyRow = Entities.UserClassesRow;

    public class UserClassesRepository
    {
        private static MyRow.RowFields fld { get { return MyRow.Fields; } }

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

        public RetrieveResponse<MyRow> Retrieve(IDbConnection connection, RetrieveRequest request)
        {
            return new MyRetrieveHandler().Process(connection, request);
        }

        public ListResponse<MyRow> List(IDbConnection connection, ListRequest request)
        {
            return new MyListHandler().Process(connection, request);
        }

        private class MySaveHandler : SaveRequestHandler<MyRow> { }
        private class MyDeleteHandler : DeleteRequestHandler<MyRow> { }
        private class MyRetrieveHandler : RetrieveRequestHandler<MyRow> { }
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
                if (!Authorization.HasPermission(Administration.PermissionKeys.Security))
                    // thì chỉ hiển thị thông tin của chính mình
                    query.Where(fld.UserId == user.UserId);
            }
        }
    }
}