
using Serenity.Extensibility;
using System.ComponentModel;

/// <summary>
///         Định nghĩa các quyền của Project Monitoring
///         Sẽ hiển thị trên giao diện Adminstrator / User Role / tab Edit Permission
/// </summary>
namespace ProjectMonitoring.ProjectMonitoring
{
    [NestedPermissionKeys]
    [DisplayName("PermissionKeys PM")]
    public class PermissionKeys
    {
        // Quyền cơ bản
        [Description("[General]")]
        public const string General = "PM:General";

        /// <summary>
        ///         Thiết đặt quyền cho bảng Classes
        /// </summary>
        public class Class
        {
            // Quyền xóa
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Class:Delete";

            // Quyền chỉnh sửa
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Class:Modify";

            // Quyền xem
            public const string View = "PM:Class:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng Posts
        /// </summary>
        public class Post
        {
            // Quyền xóa
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Post:Delete";

            // Quyền chỉnh sửa
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Post:Modify";

            // Quyền xem
            public const string View = "PM:Post:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng SCMs
        /// </summary>
        public class SCM
        {
            // Quyền xóa
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCM:Delete";

            // Quyền chỉnh sửa
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCM:Modify";

            // Quyền xem
            public const string View = "PM:SCM:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng SCMTypes
        /// </summary>
        public class SCMType
        {
            // Quyền xóa
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCMType:Delete";

            // Quyền chỉnh sửa
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCMType:Modify";

            // Quyền xem
            public const string View = "PM:SCMType:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng Subjects
        /// </summary>
        public class Subject
        {
            // Quyền xóa
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Subject:Delete";

            // Quyền chỉnh sửa
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Subject:Modify";

            // Quyền xem
            public const string View = "PM:Subject:View";
        }

    }
}
