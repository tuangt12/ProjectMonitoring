
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ProjectMonitoring.SCMTypes")]
    [BasedOnRow(typeof(Entities.SCMTypesRow), CheckNames = true)]
    public class SCMTypesForm
    {
        public String Name { get; set; }
    }
}