
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
namespace ProjectMonitoring.ProjectMonitoring {
    @Serenity.Decorators.registerEditor()
    @Serenity.Decorators.maximizable()
    export class UserClassesEditor
        extends Common.GridEditorBase<UserClassesRow> {
        protected getColumnsKey() { return "ProjectMonitoring.UserClasses"; }
        protected getDialogType() { return UserClassesEditDialog; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getAddButtonCaption() {
            return "Add to a Class";
        }

        // Xác thực dữ liệu khi đăng ký một lớp mới
        // Không cho phép đăng ký một lớp đã đăng ký trước đó
        validateEntity(row, id) {
            // Lấy ra ClassId của từng dòng trong bảng UserClasses
            row.ClassId = Q.toId(row.ClassId);

            // Kiểm tra xem có trùng class đã đăng ký hay không
            // So sánh ClassId vừa chọn trong select box (sử dụng biến x) 
            // xem có trùng ClassId với trong row hay không
            var sameClass = Q.tryFirst(this.view.getItems(), x => x.ClassId === row.ClassId);
            // Nếu có trùng, và id của row mới khác với id của row cũ
            if (sameClass && this.id(sameClass) !== id) {
                // thì cảnh báo Lớp học đã được đăng ký rồi
                Q.alert('This class is already registed!');
                return false;
            }

            // Gán trường ClassCode của UserClass hiện tại bằng cách
            // Lấy ra trường ClassCode trong ClassesRow theo Id 
            // (Id này chính là ClassId lấy từ row hiện tại, Row hiện tại là Row của UserClasses)
            row.ClassClassCode = ClassesRow.getLookup()
                .itemById[row.ClassId].ClassCode;

            // Gán trường SubjectCode của UserClass hiện tại
            row.ClassSubjectCode = ClassesRow.getLookup()
                .itemById[row.ClassId].SubjectCode;
            return true;
        }
    }
}