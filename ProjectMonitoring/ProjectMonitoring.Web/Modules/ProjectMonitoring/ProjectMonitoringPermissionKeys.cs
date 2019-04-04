
using Serenity.Extensibility;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    /// <summary>
    ///         Định nghĩa các quyền của Project Monitoring
    ///         Sẽ hiển thị trên giao diện Adminstrator / User Role / tab Edit Permission
    /// </summary>
    [NestedPermissionKeys]
    [DisplayName("PermissionKeys PM")]
    public class PermissionKeys
    {
        /// <summary>
        ///         Quyền chung cho ProjectMonitoring
        /// </summary>
        [Description("[General]")]
        public const string General = "PM:General";

        /// <summary>
        ///         Thiết đặt quyền cho bảng Classes
        /// </summary>
        public class Class
        {
            /// <summary>
            ///         Quyền xóa dữ liệu trong bảng Classes
            /// </summary>
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Class:Delete";

            /// <summary>
            ///         Quyền chỉnh sửa dữ liệu trong bảng Classes
            /// </summary>
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Class:Modify";

            /// <summary>
            ///         Quyền xem dữ liệu trong bảng Classes
            /// </summary>
            public const string View = "PM:Class:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng Posts
        /// </summary>
        public class Post
        {
            /// <summary>
            ///         Quyền xóa dữ liệu trong bảng Posts
            /// </summary>
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Post:Delete";

            /// <summary>
            ///         Quyền chỉnh sửa dữ liệu trong bảng Posts
            /// </summary>
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Post:Modify";

            /// <summary>
            ///         Quyền xem dữ liệu trong bảng Posts
            /// </summary>
            public const string View = "PM:Post:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng SCMs
        /// </summary>
        public class SCM
        {
            /// <summary>
            ///         Quyền xóa dữ liệu trong bảng SCMs
            /// </summary>
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCM:Delete";

            /// <summary>
            ///         Quyền chỉnh sửa dữ liệu trong bảng SCMs
            /// </summary>
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCM:Modify";

            /// <summary>
            ///         Quyền xem dữ liệu trong bảng SCMs
            /// </summary>
            public const string View = "PM:SCM:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng SCMTypes
        /// </summary>
        public class SCMType
        {
            /// <summary>
            ///         Quyền xóa dữ liệu trong bảng SCMTypes
            /// </summary>
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:SCMType:Delete";

            /// <summary>
            ///         Quyền chỉnh sửa dữ liệu trong bảng SCMTypes
            /// </summary>
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:SCMType:Modify";

            /// <summary>
            ///         Quyền xem dữ liệu trong bảng SCMTypes
            /// </summary>
            public const string View = "PM:SCMType:View";
        }

        /// <summary>
        ///         Thiết đặt quyền cho bảng Subjects
        /// </summary>
        public class Subject
        {
            /// <summary>
            ///         Quyền xóa dữ liệu trong bảng Subjects
            /// </summary>
            [ImplicitPermission(General), ImplicitPermission(View)]
            public const string Delete = "PM:Subject:Delete";

            /// <summary>
            ///         Quyền chỉnh sửa dữ liệu trong bảng Subjects
            /// </summary>
            [Description("Create/Update"), ImplicitPermission(General), ImplicitPermission(View)]
            public const string Modify = "PM:Subject:Modify";

            /// <summary>
            ///         Quyền xem dữ liệu trong bảng Subjects
            /// </summary>
            public const string View = "PM:Subject:View";
        }

    }
}
