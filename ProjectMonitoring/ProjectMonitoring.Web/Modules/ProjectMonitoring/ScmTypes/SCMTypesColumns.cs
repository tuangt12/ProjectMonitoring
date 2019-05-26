
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("ProjectMonitoring.SCMTypes")]
    [BasedOnRow(typeof(Entities.SCMTypesRow), CheckNames = true)]
    public class SCMTypesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }
        [EditLink]
        public String Name { get; set; }
    }
}