﻿/// <reference path="../../Common/Helpers/GridEditorDialog.ts" />

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
                    //var subjectCode = ClassesRow.getLookup().itemById[classID].SubjectId;
                    var vlue1 = ClassesRow.getLookup().itemById[classID];
                    this.form.SubjectName.value = ClassesRow.getLookup().itemById[classID].SubjectName;
                    var i = 1;
                }
            });
        }
    }
}