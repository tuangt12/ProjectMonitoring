
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ProjectMonitoring.Subjects")]
    [BasedOnRow(typeof(Entities.SubjectsRow), CheckNames = true)]
    public class SubjectsForm
    {
        public String SubjectCode { get; set; }
        public String Name { get; set; }
    }
}