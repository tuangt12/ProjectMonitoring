namespace ProjectMonitoring.Administration.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Administration.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserForm
    {
        public String Username { get; set; }
        public String UserCode { get; set; }
        public String DisplayName { get; set; }
        [DateTimeEditor]
        public DateTime? Birthday { get; set; }
        [NumberFormatter]
        public Int16? Phone { get; set; }
        public String Level { get; set; }
        [EmailEditor]
        public String Email { get; set; }
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