
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class ClassesDialog extends Serenity.EntityDialog<ClassesRow, any> {
        protected getFormKey() { return ClassesForm.formKey; }
        protected getIdProperty() { return ClassesRow.idProperty; }
        protected getLocalTextPrefix() { return ClassesRow.localTextPrefix; }
        protected getNameProperty() { return ClassesRow.nameProperty; }
        protected getService() { return ClassesService.baseUrl; }

        protected form = new ClassesForm(this.idPrefix);

    }
}