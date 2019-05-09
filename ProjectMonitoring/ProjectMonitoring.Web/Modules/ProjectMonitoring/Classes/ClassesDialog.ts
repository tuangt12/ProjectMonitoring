
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    @Serenity.Decorators.responsive()
    export class ClassesDialog extends Serenity.EntityDialog<ClassesRow, any> {
        protected getFormKey() { return ClassesForm.formKey; }
        protected getIdProperty() { return ClassesRow.idProperty; }
        protected getLocalTextPrefix() { return ClassesRow.localTextPrefix; }
        protected getNameProperty() { return ClassesRow.nameProperty; }
        protected getService() { return ClassesService.baseUrl; }

        protected form = new ClassesForm(this.idPrefix);

        private userGrid: ClassesUserGrid;

        constructor(container: JQuery) {
            super(container);

            // gán tab danh sách User bằng Grid hiển thị của bảng User
            this.userGrid = new ClassesUserGrid(this.byId("UserGrid"));
            this.tabs.on('tabsactivate', (e, i) => {
                this.arrange();
            });
        }

        protected afterLoadEntity() {
            super.afterLoadEntity();
            // Chỉ định mở đúng userGrid tương ứng cới Class đang chọn thao tác
            this.userGrid.classesID = this.entityId;
        }
    }
}