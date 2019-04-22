
/// <reference path="../../Common/Helpers/GridEditorBase.ts" />
namespace ProjectMonitoring.ProjectMonitoring {
    @Serenity.Decorators.registerEditor()
    export class UserClassesEditor
        extends Common.GridEditorBase<UserClassesRow> {
        protected getColumnsKey() { return "ProjectMonitoring.UserClasses"; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }
        constructor(container: JQuery) {
            super(container);
        }
    }
}