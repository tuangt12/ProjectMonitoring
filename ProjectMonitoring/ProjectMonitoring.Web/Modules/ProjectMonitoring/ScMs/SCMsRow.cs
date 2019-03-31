
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[SCMs]")]
    [DisplayName("SCMs"), InstanceName("SCMs")]
    [ReadPermission("PM:General")]
    [ModifyPermission("PM:General")]
    public sealed class SCMsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("SCM Type"), Column("SCMTypeId"), ForeignKey("[dbo].[SCMTypes]", "Id"), LeftJoin("jScmType"), TextualField("ScmTypeName")]
        public Int32? ScmTypeId
        {
            get { return Fields.ScmTypeId[this]; }
            set { Fields.ScmTypeId[this] = value; }
        }

        [DisplayName("SCM Link"), Column("SCMLink"), QuickSearch]
        public String ScmLink
        {
            get { return Fields.ScmLink[this]; }
            set { Fields.ScmLink[this] = value; }
        }

        [DisplayName("User Class"), ForeignKey("[dbo].[UserClasses]", "Id"), LeftJoin("jUserClass")]
        public Int32? UserClassId
        {
            get { return Fields.UserClassId[this]; }
            set { Fields.UserClassId[this] = value; }
        }

        [DisplayName("Scm Type Name"), Expression("jScmType.[Name]")]
        public String ScmTypeName
        {
            get { return Fields.ScmTypeName[this]; }
            set { Fields.ScmTypeName[this] = value; }
        }

        [DisplayName("User Class User Id"), Expression("jUserClass.[UserId]")]
        public Int32? UserClassUserId
        {
            get { return Fields.UserClassUserId[this]; }
            set { Fields.UserClassUserId[this] = value; }
        }

        [DisplayName("User Class Class Id"), Expression("jUserClass.[ClassId]")]
        public Int32? UserClassClassId
        {
            get { return Fields.UserClassClassId[this]; }
            set { Fields.UserClassClassId[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ScmLink; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SCMsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field ScmTypeId;
            public StringField ScmLink;
            public Int32Field UserClassId;

            public StringField ScmTypeName;

            public Int32Field UserClassUserId;
            public Int32Field UserClassClassId;
        }
    }
}
