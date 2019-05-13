
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("ProjectMonitoring.Posts")]
    [BasedOnRow(typeof(Entities.PostsRow), CheckNames = true)]
    public class PostsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String ContentPost { get; set; }
        [AlignCenter]
        public Int32 UserClassId { get; set; }
        public DateTime CreateDate { get; set; }
        [Width(100)]
        public String CreateBy { get; set; }
    }
}