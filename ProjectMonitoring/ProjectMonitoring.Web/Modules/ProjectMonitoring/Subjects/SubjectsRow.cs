
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[Subjects]")]
    [DisplayName("Subjects"), InstanceName("Subjects")]
    [ReadPermission("PM:General")]
    [ModifyPermission("PM:General")]
    public sealed class SubjectsRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Subject Code"), Size(10), QuickSearch]
        public String SubjectCode
        {
            get { return Fields.SubjectCode[this]; }
            set { Fields.SubjectCode[this] = value; }
        }

        [DisplayName("Name"), Size(50)]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.SubjectCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public SubjectsRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField SubjectCode;
            public StringField Name;
        }
    }
}
