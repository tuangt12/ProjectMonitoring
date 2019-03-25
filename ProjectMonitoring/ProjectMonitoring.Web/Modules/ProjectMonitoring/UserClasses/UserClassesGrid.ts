
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
    }
}