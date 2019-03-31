
namespace ProjectMonitoring.ProjectMonitoring.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("ProjectMonitoring"), Module("ProjectMonitoring"), TableName("[dbo].[User]")]
    [DisplayName("User"), InstanceName("User")]

    //Đặt quyền cho Student chỉ được xem bảng này, không được sửa
    [ReadPermission("PM:General")]
    [ModifyPermission("PM:Teacher")]
    public sealed class UserRow : Row, IIdRow, INameRow
    {
        [DisplayName("Id"), PrimaryKey]
        public Int32? Id
        {
            get { return Fields.Id[this]; }
            set { Fields.Id[this] = value; }
        }

        [DisplayName("User Code"), Size(10), QuickSearch]
        public String UserCode
        {
            get { return Fields.UserCode[this]; }
            set { Fields.UserCode[this] = value; }
        }

        [DisplayName("Name"), Size(50)]
        public String Name
        {
            get { return Fields.Name[this]; }
            set { Fields.Name[this] = value; }
        }

        [DisplayName("Birthday")]
        public DateTime? Birthday
        {
            get { return Fields.Birthday[this]; }
            set { Fields.Birthday[this] = value; }
        }

        [DisplayName("Phone"), Size(15)]
        public String Phone
        {
            get { return Fields.Phone[this]; }
            set { Fields.Phone[this] = value; }
        }

        [DisplayName("Address"), Size(50)]
        public String Address
        {
            get { return Fields.Address[this]; }
            set { Fields.Address[this] = value; }
        }

        [DisplayName("Email"), Size(50)]
        public String Email
        {
            get { return Fields.Email[this]; }
            set { Fields.Email[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.Id; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.UserCode; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public UserRow()
            : base(Fields)
        {
        }

        public class RowFields : RowFieldsBase
        {
            public Int32Field Id;
            public StringField UserCode;
            public StringField Name;
            public DateTimeField Birthday;
            public StringField Phone;
            public StringField Address;
            public StringField Email;
        }
    }
}
