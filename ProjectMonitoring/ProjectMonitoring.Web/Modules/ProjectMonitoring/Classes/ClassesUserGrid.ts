//Tab hiển thị danh sách User thuộc Class đang chọn

namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class ClassesUserGrid extends Serenity.EntityGrid<UserClassesRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.ClassesUser'; }
        protected getIdProperty() { return UserClassesRow.idProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }
        protected getService() { return UserClassesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        // Ghi đè để loại bỏ Button
        protected getButtons() {
            return null;
        }

        // Ghi đè để loại bỏ Title
        protected getInitialTitle() {
            return null;
        }

        protected usePager() {
            return false;
        }

        protected getGridCanLoad() {
            return this.classesID != null;
        }

        private _classesID: number;

        get classesID() {
            return this._classesID;
        }

        // Tạo bộ lọc để chỉ hiển thị danh sách các user thuộc lớp hiện tại
        // Nếu không có bộ lọc này thì bảng sẽ hiển thị tất cả các User
        set classesID(value: number) {
            if (this._classesID != value) {
                this._classesID = value;
                // Đặt giá trị của classesID bằng Id của Class đang mở Dialog
                this.setEquality(UserClassesRow.Fields.ClassId, value);
                this.refresh();
            }
        }
    }
}