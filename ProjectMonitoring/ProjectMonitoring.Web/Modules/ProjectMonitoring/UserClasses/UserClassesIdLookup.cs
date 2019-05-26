
namespace ProjectMonitoring.ProjectMonitoring.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class UserClassesIdLookup : RowLookupScript<Entities.UserClassesRow>
    {
        public UserClassesIdLookup()
        {
            IdField = TextField = "Id";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.UserClassesRow.Fields;
            query.Distinct(true)
                .Select(fld.Id)
                .Where(
                    new Criteria(fld.Id).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}