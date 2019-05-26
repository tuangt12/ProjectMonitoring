
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("ProjectMonitoring.Classes")]
    [BasedOnRow(typeof(Entities.ClassesRow), CheckNames = true)]
    public class ClassesForm
    {
        public String ClassCode { get; set; }
        public String SubjectCode { get; set; }
        public String MidExamCode { get; set; }
        public String FinalExamCode { get; set; }
        public DateTime StartDate { get; set; }
        public Int32 IsFinished { get; set; }
    }
}