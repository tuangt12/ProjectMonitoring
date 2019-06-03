
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class UserClassesGrid extends Serenity.EntityGrid<UserClassesRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.UserClasses'; }
        protected getDialogType() { return UserClassesDialog; }
        protected getIdProperty() { return UserClassesRow.idProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }
        protected getService() { return UserClassesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        // Không hiển thị nút thêm Topic mới tại đây khi đăng nhập với quyền sinh viên
        // Sinh viên nếu muốn đăng ký một lớp mới (đăng ký đề tài) thì đã có trong phần quản lý tài khoản của mình
        protected getButtons(): Serenity.ToolButton[] {
            var buttons = super.getButtons();
            // Nếu kiểm tra mà không có quyền admin
            if (!Authorization.hasPermission("Administration:Security")) {
                buttons.splice(Q.indexOf(buttons, x => x.cssClass == "add-button"), 1);
            }
            return buttons;
        }

        // Chỉ hiển thị các filter khi đăng nhập với quyền quản trị
        // Khi đăng nhập với tư cách là sinh viên thì đã mặc định chỉ lọc các lớp mà sinh viên đó tham gia rồi
        // nên không cần filter nữa
        protected getQuickFilters() {

            var filters = super.getQuickFilters();
            // Kiểm tra quyền
            if (!Authorization.hasPermission("Administration:Security")) {
                // Trả về list filter rỗng (xóa tất cả các filter)
                return [];
            }
            return filters;
        }
    }
}