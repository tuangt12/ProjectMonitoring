
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;
    using System.ComponentModel;


    [ColumnsScript("ProjectMonitoring.SCMs")]
    [BasedOnRow(typeof(Entities.SCMsRow), CheckNames = true)]
    public class SCMsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignCenter]
        public Int32 Id { get; set; }

        // Phân loại GitHub hay GitLab
        [Width(80)]
        public String ScmTypeName { get; set; }

        // Đường dẫn tới Project
        [EditLink]
        public String ScmLink { get; set; }
        // Không hiển thị UserClassId nữa
        // public Int32 UserClassId { get; set; }

        // Cột hiển thị tên sinh viên tương ứng với link báo cáo
        // Mặc định chỉ hiển thị UserId, tại đây sẽ sử dụng thêm SCMUserNameFormatter để hiển thị tên
        [Width(150), SCMUserNameFormatter]
        public Int32 UserClassUserId { get; set; }
    }
}