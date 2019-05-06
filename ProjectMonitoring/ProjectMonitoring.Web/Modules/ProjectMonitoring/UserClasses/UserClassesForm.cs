
namespace ProjectMonitoring.ProjectMonitoring.Forms
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("ProjectMonitoring.UserClasses")]
    [BasedOnRow(typeof(Entities.UserClassesRow), CheckNames = true)]
    public class UserClassesForm
    {
        // UserId sẽ được lấy tự động với user tương ứng đang được chỉnh sửa
        //public Int32 UserId { get; set; }
        public Int32 ClassId { get; set; }
        public String SubjectName { get; set; }
    }
}