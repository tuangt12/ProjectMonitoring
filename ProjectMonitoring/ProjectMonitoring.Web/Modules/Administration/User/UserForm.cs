namespace ProjectMonitoring.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.Collections.Generic;

    [FormScript("Administration.User")]
    // Để Checknames = false vì có trường ClassList không nằm trong bảng User 
    //nên không lấy được tên ra từ UserRow
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = false)]
    public class UserForm
    {
        public String Username { get; set; }
        public String UserCode { get; set; }
        public String DisplayName { get; set; }
        [DateTimeEditor]
        public DateTime? Birthday { get; set; }
        [NumberFormatter]
        public String Phone { get; set; }
        public String Level { get; set; }
        [EmailEditor]
        public String Email { get; set; }

        // Form hiển thị thông tin bảng User và Class tương ứng đã đăng kí
        [ProjectMonitoring.UserClassesEditor]
        public List<ProjectMonitoring.Entities.UserClassesRow> ClassList { get; set; }

        public String UserImage { get; set; }
        [PasswordEditor, Required(true)]
        public String Password { get; set; }
        [PasswordEditor, OneWay, Required(true)]
        public String PasswordConfirm { get; set; }

        //Không cho nhập source nữa
        //[OneWay]
        //public string Source { get; set; }
    }
}