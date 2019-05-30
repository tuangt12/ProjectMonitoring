
namespace ProjectMonitoring.Administration.Lookups
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public class UserLevelLookup : RowLookupScript<Entities.UserRow>
    {
        public UserLevelLookup()
        {
            IdField = TextField = "Level";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            var fld = Entities.UserRow.Fields;
            query.Distinct(true)
                .Select(fld.Level)
                .Where(
                    new Criteria(fld.Level) != "" &
                    new Criteria(fld.Level).IsNotNull());
        }

        protected override void ApplyOrder(SqlQuery query)
        {
        }
    }
}