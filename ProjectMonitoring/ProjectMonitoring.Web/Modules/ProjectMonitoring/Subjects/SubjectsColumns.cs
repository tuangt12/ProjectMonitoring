
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("ProjectMonitoring.Subjects")]
    [BasedOnRow(typeof(Entities.SubjectsRow), CheckNames = true)]
    public class SubjectsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }
        [EditLink]
        public String SubjectCode { get; set; }
        public String Name { get; set; }
    }
}