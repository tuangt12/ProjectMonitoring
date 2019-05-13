
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

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