
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("ProjectMonitoring.SCMs")]
    [BasedOnRow(typeof(Entities.SCMsRow), CheckNames = true)]
    public class SCMsForm
    {
        public Int32 ScmTypeId { get; set; }
        public String ScmLink { get; set; }
        public Int32 UserClassId { get; set; }
    }
}