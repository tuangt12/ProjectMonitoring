
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SubjectsGrid extends Serenity.EntityGrid<SubjectsRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.Subjects'; }
        protected getDialogType() { return SubjectsDialog; }
        protected getIdProperty() { return SubjectsRow.idProperty; }
        protected getLocalTextPrefix() { return SubjectsRow.localTextPrefix; }
        protected getService() { return SubjectsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}