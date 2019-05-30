
namespace ProjectMonitoring.Administration.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserColumns
    {
        [EditLink, AlignCenter, Width(55)]
        public String UserId { get; set; }
        [EditLink, AlignCenter, Width(90)]
        public String UserCode { get; set; }
        [EditLink, Width(150)]
        public String Username { get; set; }
        [Width(150)]
        public String DisplayName { get; set; }
        [AlignRight]
        public DateTime? Birthday { get; set; }
        [Width(130), AlignRight]
        public String Phone { get; set; }
        [Width(60), AlignCenter]
        [QuickFilter, LookupEditor(typeof(Lookups.UserLevelLookup))]
        public String Level { get; set; }

        [Width(250)]
        public String Email { get; set; }

        // Không hiển thị cột Source ra nữa
        //[Width(100)]
        //public String Source { get; set; }
    }
}
