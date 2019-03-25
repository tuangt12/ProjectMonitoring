
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SCMTypesDialog extends Serenity.EntityDialog<SCMTypesRow, any> {
        protected getFormKey() { return SCMTypesForm.formKey; }
        protected getIdProperty() { return SCMTypesRow.idProperty; }
        protected getLocalTextPrefix() { return SCMTypesRow.localTextPrefix; }
        protected getNameProperty() { return SCMTypesRow.nameProperty; }
        protected getService() { return SCMTypesService.baseUrl; }

        protected form = new SCMTypesForm(this.idPrefix);

    }
}