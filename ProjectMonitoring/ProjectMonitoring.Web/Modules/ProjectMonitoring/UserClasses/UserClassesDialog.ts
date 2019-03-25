
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class UserClassesDialog extends Serenity.EntityDialog<UserClassesRow, any> {
        protected getFormKey() { return UserClassesForm.formKey; }
        protected getIdProperty() { return UserClassesRow.idProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }
        protected getService() { return UserClassesService.baseUrl; }

        protected form = new UserClassesForm(this.idPrefix);

    }
}