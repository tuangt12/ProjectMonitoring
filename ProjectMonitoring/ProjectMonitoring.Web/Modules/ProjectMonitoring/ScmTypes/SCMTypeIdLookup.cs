
namespace ProjectMonitoring.ProjectMonitoring.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class SCMTypeIdLookup : RowLookupScript<Entities.SCMTypesRow>
    {
        public SCMTypeIdLookup()
        {
            IdField = TextField = "Id";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.SCMTypesRow.Fields;
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