
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ProjectMonitoring.User")]
    [BasedOnRow(typeof(Entities.UserRow), CheckNames = true)]
    public class UserForm
    {
        public String UserCode { get; set; }
        public String Name { get; set; }
        public DateTime Birthday { get; set; }
        public String Phone { get; set; }
        public String Address { get; set; }
        public String Email { get; set; }
    }
}