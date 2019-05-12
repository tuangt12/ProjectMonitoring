
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ProjectMonitoring.UserClasses")]
    [BasedOnRow(typeof(Entities.UserClassesRow), CheckNames = true)]
    public class UserClassesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }

        [EditLink, Width(100)]
        public String ClassClassCode { get; set; }

        [Width(200)]
        // TODO : Hiển thị dạng SubjectCode + SubjectName
        public String ClassSubjectCode { get; set; }

    }
}