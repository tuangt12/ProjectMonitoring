
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ProjectMonitoring.SCMs")]
    [BasedOnRow(typeof(Entities.SCMsRow), CheckNames = true)]
    public class SCMsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 Id { get; set; }
        public String ScmTypeName { get; set; }
        [EditLink]
        public String ScmLink { get; set; }
        public Int32 UserClassId { get; set; }
    }
}