
namespace ProjectMonitoring.Administration.Lookups
{
    //Fix-bug: Không tìm thấy package  ProjectMonitoring.Administration
    //Giải pháp: bỏ khai báo namespace  ProjectMonitoring  là xong
    //Nguyên nhân:  không biết tại sao

    //using ProjectMonitoring.Administration.Entities;
    using Administration.Entities;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Web;

    [LookupScript]
    public sealed class LanguageLookup : RowLookupScript<LanguageRow>
    {
        public LanguageLookup()
        {
            IdField = LanguageRow.Fields.LanguageId.PropertyName;
            Permission = "*";
        }

        protected override void PrepareQuery(SqlQuery query)
        {
            base.PrepareQuery(query);

            query.Select(LanguageRow.Fields.LanguageId);
        }
    }
}