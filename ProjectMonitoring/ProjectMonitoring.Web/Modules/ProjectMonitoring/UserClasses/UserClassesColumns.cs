
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
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String UserUserCode { get; set; }
        public String ClassClassCode { get; set; }
    }
}