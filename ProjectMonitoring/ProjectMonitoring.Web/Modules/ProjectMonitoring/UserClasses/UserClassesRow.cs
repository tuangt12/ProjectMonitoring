
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Newtonsoft.Json;
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[ProjectMonitoring].[dbo].[UserClasses]")]
    [DisplayName("User Classes"), InstanceName("User Classes")]

    // xác định quyền tương ứng cho bảng UserClasses
    [ReadPermission(PermissionKeys.General)]
    [ModifyPermission(PermissionKeys.General)]

    [JsonConverter(typeof(JsonRowConverter))]
    [LookupScript("dbo.UserClasses")]

    public sealed class UserClassesRow : Row, IIdRow
    {
        [DisplayName("Id"), Identity]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        // Danh sách User được lấy từ bảng User
        [DisplayName("User"), ForeignKey("[ProjectMonitoring_Default_v1].[dbo].[Users]", "UserId"), LeftJoin("jUser"), TextualField("UserUserCode")]
        public Int32? UserId
        {
            get { return Fields.UserId[this]; }
            set { Fields.UserId[this] = value; }
        }

        // Danh sách Class được lấy từ bảng Class
        [DisplayName("Class"), ForeignKey("[ProjectMonitoring].[dbo].[Classes]", "Id"), LeftJoin("jClass"), TextualField("ClassClassCode")]
        [LookupEditor("dbo.Classes")]
        public Int32? ClassId
        {
            get { return Fields.ClassId[this]; }
            set { Fields.ClassId[this] = value; }
        }

        // Danh sách Subject được lấy từ bảng Subjects
        [DisplayName("Subject"), ForeignKey("[ProjectMonitoring].[dbo].[Subjects]", "Id"), LeftJoin("jSubject"), TextualField("SubjectSubjectCode")]
        [LookupEditor("dbo.Classes")]
        public Int32? SubjectId
        {
            get { return Fields.SubjectId[this]; }
            set { Fields.SubjectId[this] = value; }
        }

        [DisplayName("Subject Name"), Expression("jSubject.[Name]")]
        public String SubjectName
        {
            get { return Fields.SubjectName[this]; }
            set { Fields.SubjectName[this] = value; }
        }

        [DisplayName("User Code"), Expression("jUser.[UserCode]")]
        public String UserUserCode
        {
            get { return Fields.UserUserCode[this]; }
            set { Fields.UserUserCode[this] = value; }
        }

        [DisplayName("User Name"), Expression("jUser.[Username]")]
        public String UserName
        {
            get { return Fields.UserName[this]; }
            set { Fields.UserName[this] = value; }
        }

        [DisplayName("Student Name"), Expression("jUser.[DisplayName]")]
        public String UserDisplayName
        {
            get { return Fields.UserDisplayName[this]; }
            set { Fields.UserDisplayName[this] = value; }
        }

        [DisplayName("User Birthday"), Expression("jUser.[Birthday]")]
        public DateTime? UserBirthday
        {
            get { return Fields.UserBirthday[this]; }
            set { Fields.UserBirthday[this] = value; }
        }

        [DisplayName("User Phone"), Expression("jUser.[Phone]")]
        public String UserPhone
        {
            get { return Fields.UserPhone[this]; }
            set { Fields.UserPhone[this] = value; }
        }

        [DisplayName("User Email"), Expression("jUser.[Email]")]
        public String UserEmail
        {
            get { return Fields.UserEmail[this]; }
            set { Fields.UserEmail[this] = value; }
        }

        [DisplayName("Class Code"), Expression("jClass.[ClassCode]")]
        public String ClassClassCode
        {
            get { return Fields.ClassClassCode[this]; }
            set { Fields.ClassClassCode[this] = value; }
        }

        [DisplayName("Subject Code"), Expression("jClass.[SubjectCode]")]
        public String ClassSubjectCode
        {
            get { return Fields.ClassSubjectCode[this]; }
            set { Fields.ClassSubjectCode[this] = value; }
        }

        [DisplayName("Class Mid Exam Code"), Expression("jClass.[MidExamCode]")]
        public String ClassMidExamCode
        {
            get { return Fields.ClassMidExamCode[this]; }
            set { Fields.ClassMidExamCode[this] = value; }
        }

        [DisplayName("Class Final Exam Code"), Expression("jClass.[FinalExamCode]")]
        public String ClassFinalExamCode
        {
            get { return Fields.ClassFinalExamCode[this]; }
            set { Fields.ClassFinalExamCode[this] = value; }
        }

        [DisplayName("Class Start Date"), Expression("jClass.[StartDate]")]
        public DateTime? ClassStartDate
        {
            get { return Fields.ClassStartDate[this]; }
            set { Fields.ClassStartDate[this] = value; }
        }

        [DisplayName("Class Is Finished"), Expression("jClass.[IsFinished]")]
        public Int32? ClassIsFinished
        {
            get { return Fields.ClassIsFinished[this]; }
            set { Fields.ClassIsFinished[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserClassesRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public Int32Field UserId;
            public Int32Field ClassId;

            public StringField UserUserCode;
            public StringField UserName;
            public StringField UserDisplayName;
            public DateTimeField UserBirthday;
            public StringField UserPhone;
            public StringField UserEmail;

            public Int32Field SubjectId;
            public StringField SubjectName;

            public StringField ClassClassCode;
            public StringField ClassSubjectCode;
            public StringField ClassMidExamCode;
            public StringField ClassFinalExamCode;
            public DateTimeField ClassStartDate;
            public Int32Field ClassIsFinished;
        }
    }
}
