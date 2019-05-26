
namespace ProjectMonitoring.Administration.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class UserCodeLookup : RowLookupScript<Entities.UserRow>
    {
        public UserCodeLookup()
        {
            IdField = TextField = "UserCode";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Administration.Entities.UserRow.Fields;
            query.Distinct(true)
                .Select(fld.UserCode)
                .Where(
                    new Criteria(fld.UserCode) != "" &
                    new Criteria(fld.UserCode).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}