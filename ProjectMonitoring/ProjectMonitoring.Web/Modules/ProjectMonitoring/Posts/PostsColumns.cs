
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

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
        [QuickFilter, LookupEditor(typeof(Lookups.UserClassesIdLookup))]
        public Int32 UserClassId { get; set; }
        public DateTime CreateDate { get; set; }
        [Width(100)]
        [QuickFilter, LookupEditor(typeof(Administration.Lookups.UserCodeLookup))]
        public String CreateBy { get; set; }
    }
}