
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

        [EditLink, AlignCenter, Width(90)]
        [QuickFilter]
        public String UserUserCode { get; set; }

        [Width(150)]
        public String UserDisplayName { get; set; }

        [EditLink, Width(100)]
        [QuickFilter]
        public String ClassClassCode { get; set; }

        [Width(150)]
        // TODO : Hiển thị dạng SubjectCode + SubjectName
        public String ClassSubjectCode { get; set; }
        public String Name { get; set; }
        [Width(100)]
        public String Point { get; set; }
    }
}