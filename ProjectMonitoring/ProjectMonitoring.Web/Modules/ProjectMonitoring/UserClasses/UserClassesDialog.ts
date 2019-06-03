
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.maximizable()
    export class UserClassesDialog extends Serenity.EntityDialog<UserClassesRow, any> {
        protected getFormKey() { return UserClassesForm.formKey; }
        protected getIdProperty() { return UserClassesRow.idProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }
        protected getService() { return UserClassesService.baseUrl; }

        protected form = new UserClassesForm(this.idPrefix);

        constructor() {
            super();
            this.form = new UserClassesForm(this.idPrefix);

            // Tự động điền tên môn học khi chọn lớp
            this.form.ClassId.changeSelect2(e => {
                var classID = Q.toId(this.form.ClassId.value);
                if (classID != null) {

                    this.form.ClassSubjectCode.value = ClassesRow.getLookup().itemById[classID].SubjectName;
                }
            });

            // Tự động điền tên sinh viên khi chọn mã số sinh viên
            this.form.UserId.changeSelect2(e => {
                var userId = Q.toId(this.form.UserId.value);
                if (userId != null) {

                    this.form.UserDisplayName.value = Administration.UserRow.getLookup().itemById[userId].DisplayName;
                }
            });
        }

        // Thay đổi giao diện
        // Khi đăng nhập với tư cách không phải admin thì sẽ không cho phép nhập/ chỉnh sửa điểm
        protected updateInterface(): void {
            super.updateInterface();
            // Nếu kiểm tra mà không có quyền admin
            if (!Authorization.hasPermission("Administration:Security")) {
                // Tìm tới trường Name, Point và disable
                // Vì các trường bên trên đã mặc định ở trạng thái không cho phép cập nhật rồi
                // mà khi không có quyền Create New thì chắc chắn các trường khác sẽ ở dạng disable
                Serenity.EditorUtils.setReadonly(this.form.Name.element, true);
                Serenity.EditorUtils.setReadonly(this.form.Point.element, true);
                // Ẩn tất cả các button Save/ Delete
                this.toolbar.findButton('save-and-close-button').toggle(false);
                this.toolbar.findButton('apply-changes-button').toggle(false);
                this.toolbar.findButton('delete-button').toggle(false)
            }
        }
    }
}