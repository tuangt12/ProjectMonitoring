
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [ColumnsScript("ProjectMonitoring.UserClasses")]
    [BasedOnRow(typeof(Entities.UserClassesRow), CheckNames = true)]
    public class UserClassesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }

        [EditLink, Width(100)]
        public String ClassClassCode { get; set; }

        [Width(150)]
        // TODO : Hiển thị dạng SubjectCode + SubjectName
        public String ClassSubjectCode { get; set; }
        public String Name { get; set; }
        [Width(100)]
        public String Point { get; set; }
    }
}