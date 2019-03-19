
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SCMsDialog extends Serenity.EntityDialog<SCMsRow, any> {
        protected getFormKey() { return SCMsForm.formKey; }
        protected getIdProperty() { return SCMsRow.idProperty; }
        protected getLocalTextPrefix() { return SCMsRow.localTextPrefix; }
        protected getNameProperty() { return SCMsRow.nameProperty; }
        protected getService() { return SCMsService.baseUrl; }

        protected form = new SCMsForm(this.idPrefix);

    }
}