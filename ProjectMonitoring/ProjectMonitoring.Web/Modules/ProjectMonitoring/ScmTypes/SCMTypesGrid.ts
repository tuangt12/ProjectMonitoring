
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SCMTypesGrid extends Serenity.EntityGrid<SCMTypesRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.SCMTypes'; }
        protected getDialogType() { return SCMTypesDialog; }
        protected getIdProperty() { return SCMTypesRow.idProperty; }
        protected getLocalTextPrefix() { return SCMTypesRow.localTextPrefix; }
        protected getService() { return SCMTypesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}