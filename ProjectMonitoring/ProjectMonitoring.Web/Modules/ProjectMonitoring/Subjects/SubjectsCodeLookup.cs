
namespace ProjectMonitoring.ProjectMonitoring.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class SubjectsCodeLookup : RowLookupScript<Entities.SubjectsRow>
    {
        public SubjectsCodeLookup()
        {
            IdField = TextField = "SubjectCode";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.SubjectsRow.Fields;
            query.Distinct(true)
                .Select(fld.SubjectCode)
                .Where(
                    new Criteria(fld.SubjectCode) != "" &
                    new Criteria(fld.SubjectCode).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}