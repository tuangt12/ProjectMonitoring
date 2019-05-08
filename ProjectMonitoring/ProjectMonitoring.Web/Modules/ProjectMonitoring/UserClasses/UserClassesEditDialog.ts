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

            this.form.ClassId.changeSelect2(e => {
                var classID = Q.toId(this.form.ClassId.value);
                if (classID != null) {
                    var subjectID = ClassesRow.getLookup().itemById[classID].SubjectId;
                    this.form.SubjectName.value = SubjectsRow.getLookup().itemById[subjectID].Name;
                }
            });
        }
    }
}