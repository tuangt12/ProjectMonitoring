
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[Posts]")]
    [DisplayName("Posts"), InstanceName("Posts")]

    // xác định quyền tương ứng cho bảng Posts
    [ReadPermission(PermissionKeys.Post.View)]
    [ModifyPermission(PermissionKeys.Post.Modify)]
    [DeletePermission(PermissionKeys.Post.Delete)]
    [LookupScript("dbo.Posts")]

    public sealed class PostsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, AlignCenter]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Title"), QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("Content Post"), Size(2147483647)]
        public String ContentPost
        {
            get { return Fields.ContentPost[this]; }
            set { Fields.ContentPost[this] = value; }
        }

        [DisplayName("User Class Id")]
        [LookupEditor(typeof(Lookups.UserClassesIdLookup))]
        public Int32? UserClassId
        {
            get { return Fields.UserClassId[this]; }
            set { Fields.UserClassId[this] = value; }
        }

        [DisplayName("Create Date")]
        [ReadOnly(true)]
        public DateTime? CreateDate
        {
            get { return Fields.CreateDate[this]; }
            set { Fields.CreateDate[this] = value; }
        }

        [DisplayName("Create By"), ForeignKey("[ProjectMonitoring_Default_v1].[dbo].[Users]", "UserCode"), LeftJoin("jCreateBy"), TextualField("CreateByUserCode")]
        [LookupEditor(typeof(Administration.Lookups.UserCodeLookup))]
        public String CreateBy
        {
            get { return Fields.CreateBy[this]; }
            set { Fields.CreateBy[this] = value; }
        }

        [DisplayName("Create By User Name"), Expression("jCreateBy.[Username]")]
        public String CreateByUsername
        {
            get { return Fields.CreateByUsername[this]; }
            set { Fields.CreateByUsername[this] = value; }
        }

        [DisplayName("Create By Birthday"), Expression("jCreateBy.[Birthday]")]
        public DateTime? CreateByBirthday
        {
            get { return Fields.CreateByBirthday[this]; }
            set { Fields.CreateByBirthday[this] = value; }
        }

        [DisplayName("Create By Phone"), Expression("jCreateBy.[Phone]")]
        public String CreateByPhone
        {
            get { return Fields.CreateByPhone[this]; }
            set { Fields.CreateByPhone[this] = value; }
        }

        [DisplayName("Create By Email"), Expression("jCreateBy.[Email]")]
        public String CreateByEmail
        {
            get { return Fields.CreateByEmail[this]; }
            set { Fields.CreateByEmail[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PostsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField Title;
            public StringField ContentPost;
            public Int32Field UserClassId;
            public DateTimeField CreateDate;
            public StringField CreateBy;

            public StringField CreateByUsername;
            public DateTimeField CreateByBirthday;
            public StringField CreateByPhone;
            public StringField CreateByEmail;
        }
    }
}
