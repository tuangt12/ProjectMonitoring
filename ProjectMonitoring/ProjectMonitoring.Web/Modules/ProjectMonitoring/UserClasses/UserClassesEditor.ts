
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
namespace ProjectMonitoring.ProjectMonitoring {
    @Serenity.Decorators.registerEditor()
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

        protected validateEntity(row: UserClassesRow, id: number) {
            if (!super.validateEntity(row, id))
                return false;

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