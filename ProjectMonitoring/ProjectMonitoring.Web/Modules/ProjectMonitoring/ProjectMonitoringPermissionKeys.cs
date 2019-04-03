
using Serenity.Extensibility;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    [NestedPermissionKeys]
    [DisplayName("PermissionKeys PM")]
    public class PermissionKeys
    {
        [Description("[General]")]
        public const string General = "PM:General";

        [Description("Teacher Permissions")]
        public const string Teacher = "PM:Teacher";
        
        // Thiết đặt quyền cho bảng SCM
        public class SCM
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCM:Delete";
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCM:Modify";
            public const string View = "PM:SCM:View";
        }
    }
}
