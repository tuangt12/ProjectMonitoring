
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("ProjectMonitoring.SCMs")]
    [BasedOnRow(typeof(Entities.SCMsRow), CheckNames = true)]
    public class SCMsForm
    {
        [ReadOnly(true)]
        public Int32 ScmTypeId { get; set; }
        public String ScmLink { get; set; }
        public Int32 UserClassId { get; set; }
    }
}