/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class UserClassesEditDialog extends
        Common.GridEditorDialog<UserClassesRow> {
        protected getFormKey() { return UserClassesForm.formKey; }
        //protected getNameProperty() { return UserClassesRow.nameProperty; }
        protected getLocalTextPrefix() { return UserClassesRow.localTextPrefix; }

        protected form: UserClassesForm;

        constructor() {
            super();
            this.form = new UserClassesForm(this.idPrefix);
        }
    }
}