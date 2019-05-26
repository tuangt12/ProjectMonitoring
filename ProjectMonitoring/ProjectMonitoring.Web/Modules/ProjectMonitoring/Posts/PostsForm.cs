
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("ProjectMonitoring.Posts")]
    [BasedOnRow(typeof(Entities.PostsRow), CheckNames = true)]
    public class PostsForm
    {
        public String Title { get; set; }
        public String ContentPost { get; set; }
        public Int32 UserClassId { get; set; }
        public DateTime CreateDate { get; set; }
        public Int32 CreateBy { get; set; }
    }
}