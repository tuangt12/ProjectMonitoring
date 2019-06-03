
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;

    [FormScript("ProjectMonitoring.Posts")]
    [BasedOnRow(typeof(Entities.PostsRow), CheckNames = true)]
    public class PostsForm
    {
        public String Title { get; set; }
        [TextAreaEditor]
        public String ContentPost { get; set; }
        public Int32 UserClassId { get; set; }
        [DefaultValue("now")]
        public DateTime CreateDate { get; set; }
        public String CreateBy { get; set; }   
        [HalfWidth]
        public String AttachFilePost { get; set; }
        [HalfWidth]
        public String AttachImagePost { get; set; }
    }
}