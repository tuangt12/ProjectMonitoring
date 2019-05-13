// Quy định các cột hiển thị khi hiển thị danh sách sinh viên trong lớp đang chọn
namespace ProjectMonitoring.ProjectMonitoring.Columns
{
    using Serenity.ComponentModel;
    using System;

    [ColumnsScript("ProjectMonitoring.ClassesUser")]
    [BasedOnRow(typeof(Entities.UserClassesRow), CheckNames = true)]
    public class ClassesUserColumns
    {
        /// <summary>
        ///     Hiển thị ID theo bảng UserClass
        /// </summary>
        [AlignCenter]
        public String Id { get; set; }

        /// <summary>
        ///     Hiển thị mã số sinh viên
        /// </summary>
        [AlignCenter, Width(90)]
        public String UserUserCode { get; set; }

        /// <summary>
        ///     Hiển thị tên sinh viên
        /// </summary>
        [Width(150)]
        public String UserDisplayName { get; set; }
    }
}