
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

        // Thiết đặt quyền cho bảng Classes
        public class Class
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Class:Delete";

            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Class:Modify";

            public const string View = "PM:Class:View";
        }

        // Thiết đặt quyền cho bảng Posts
        public class Post
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Post:Delete";

            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Post:Modify";

            public const string View = "PM:Post:View";
        }

        // Thiết đặt quyền cho bảng SCMs
        public class SCM
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCM:Delete";

            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCM:Modify";

            public const string View = "PM:SCM:View";
        }

        // Thiết đặt quyền cho bảng SCMTypes
        public class SCMType
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCMType:Delete";

            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCMType:Modify";

            public const string View = "PM:SCMType:View";
        }

        // Thiết đặt quyền cho bảng Subjects
        public class Subject
        {
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Subject:Delete";

            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Subject:Modify";

            public const string View = "PM:Subject:View";
        }

    }
}
