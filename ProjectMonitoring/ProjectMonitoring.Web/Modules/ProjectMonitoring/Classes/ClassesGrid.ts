
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class ClassesGrid extends Serenity.EntityGrid<ClassesRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.Classes'; }
        protected getDialogType() { return ClassesDialog; }
        protected getIdProperty() { return ClassesRow.idProperty; }
        protected getLocalTextPrefix() { return ClassesRow.localTextPrefix; }
        protected getService() { return ClassesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}