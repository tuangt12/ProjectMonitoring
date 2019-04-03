
using Serenity.Extensibility;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    [NestedPermissionKeys]
    [DisplayName("PermissionKeys PM")]
    public class PermissionKeys
    {
        [Description("User, Role Management and Permissions")]
        public const string Security = "PM:Security";

        [Description("Languages and Translations")]
        public const string Translation = "PM:Translation";

        [Description("Teacher Permissions")]
        public const string Teacher = "PM:Teacher";
        
        public class SCM
        {
            [Description("General")]
            public const string General = "PM:SCM:General";

            [Description("Modify"), ImplicitPermission(General)]
            public const string Modify = "PM:SCM:Mdify";
        }
    }
}
