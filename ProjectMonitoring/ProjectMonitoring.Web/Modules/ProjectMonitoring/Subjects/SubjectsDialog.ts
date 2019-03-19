
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class SubjectsDialog extends Serenity.EntityDialog<SubjectsRow, any> {
        protected getFormKey() { return SubjectsForm.formKey; }
        protected getIdProperty() { return SubjectsRow.idProperty; }
        protected getLocalTextPrefix() { return SubjectsRow.localTextPrefix; }
        protected getNameProperty() { return SubjectsRow.nameProperty; }
        protected getService() { return SubjectsService.baseUrl; }

        protected form = new SubjectsForm(this.idPrefix);

    }
}