/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.maximizable()
    export class UserClassesEditDialog extends
        Common.GridEditorDialog<UserClassesRow> {
        protected getFormKey() { return UserClassesForm.formKey; }
        //protected getNameProperty() { return UserClassesRow.nameProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }

        protected form: UserClassesForm;

        constructor() {
            super();
            this.form = new UserClassesForm(this.idPrefix);

            this.form.ClassId.changeSelect2(e => {
                var classID = Q.toId(this.form.ClassId.value);
                if (classID != null) {

                    this.form.ClassSubjectCode.value = ClassesRow.getLookup().itemById[classID].SubjectName;

                }
            });
        }

        // Thay đổi giao diện
        // Khi đăng nhập với tư cách không phải admin thì sẽ không cho phép nhập/ chỉnh sửa điểm
        protected updateInterface(): void {
            super.updateInterface();
            // Nếu kiểm tra mà không có quyền admin
            if (!Authorization.hasPermission("Administration:Security")) {
                // Tìm tới trường Point và disable
                Serenity.EditorUtils.setReadonly(this.form.Point.element, true);
            }
        }
    }
}