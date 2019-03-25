
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SCMsGrid extends Serenity.EntityGrid<SCMsRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.SCMs'; }
        protected getDialogType() { return SCMsDialog; }
        protected getIdProperty() { return SCMsRow.idProperty; }
        protected getLocalTextPrefix() { return SCMsRow.localTextPrefix; }
        protected getService() { return SCMsService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }
    }
}