
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("ProjectMonitoring.SCMTypes")]
    [BasedOnRow(typeof(Entities.SCMTypesRow), CheckNames = true)]
    public class SCMTypesForm
    {
        public String Name { get; set; }
    }
}