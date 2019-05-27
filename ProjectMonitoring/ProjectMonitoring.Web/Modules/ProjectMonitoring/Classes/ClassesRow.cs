
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Newtonsoft.Json;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[Classes]")]
    [DisplayName("Classes"), InstanceName("Classes")]

    // xác định quyền tương ứng cho bảng Classes
    [ReadPermission(PermissionKeys.Class.View)]
    [ModifyPermission(PermissionKeys.Class.Modify)]
    [DeletePermission(PermissionKeys.Class.Delete)]

    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("dbo.Classes")]

    public sealed class ClassesRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), Identity, AlignCenter]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("Class Code"), Size(10), QuickSearch]
        public String ClassCode
        {
            get { return Fields.ClassCode[this]; }
            set { Fields.ClassCode[this] = value; }
        }

        [DisplayName("Subject Name"), Expression("jSubject.[Name]"), NotMapped, QuickSearch, LookupInclude]
        public String SubjectName
        {
            get { return Fields.SubjectName[this]; }
            set { Fields.SubjectName[this] = value; }
        }

        [DisplayName("Subject Code"), Size(10), Column("SubjectCode"), ForeignKey("[dbo].[Subjects]", "SubjectCode"), LeftJoin("jSubject"), TextualField("ClassSubjectCode")]
        [QuickSearch]
        [LookupEditor(typeof(Lookups.SubjectsCodeLookup))]
        public String SubjectCode
        {
            get { return Fields.SubjectCode[this]; }
            set { Fields.SubjectCode[this] = value; }
        }

        [DisplayName("Mid Exam Code"), Size(10)]
        public String MidExamCode
        {
            get { return Fields.MidExamCode[this]; }
            set { Fields.MidExamCode[this] = value; }
        }

        [DisplayName("Final Exam Code"), Size(10)]
        public String FinalExamCode
        {
            get { return Fields.FinalExamCode[this]; }
            set { Fields.FinalExamCode[this] = value; }
        }

        [DisplayName("Start Date")]
        public DateTime? StartDate
        {
            get { return Fields.StartDate[this]; }
            set { Fields.StartDate[this] = value; }
        }

        [DisplayName("Is Finished")]
        public Int32? IsFinished
        {
            get { return Fields.IsFinished[this]; }
            set { Fields.IsFinished[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ClassCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public ClassesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField ClassCode;
            public StringField SubjectName;
            public StringField SubjectCode;
            public StringField MidExamCode;
            public StringField FinalExamCode;
            public DateTimeField StartDate;
            public Int32Field IsFinished;
        }
    }
}
