
namespace ProjectMonitoring.ProjectMonitoring.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class ClassesIsFinishedLookup : RowLookupScript<Entities.ClassesRow>
    {
        public ClassesIsFinishedLookup()
        {
            IdField = TextField = "IsFinished";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.ClassesRow.Fields;
            query.Distinct(true)
                .Select(fld.IsFinished)
                .Where(
                    new Criteria(fld.IsFinished).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}