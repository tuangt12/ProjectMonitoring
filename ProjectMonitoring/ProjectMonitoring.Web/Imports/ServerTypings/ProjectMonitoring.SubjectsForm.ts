namespace ProjectMonitoring.ProjectMonitoring {
    export interface SubjectsForm {
        SubjectCode: Serenity.StringEditor;
        Name: Serenity.StringEditor;
    }

    export class SubjectsForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.Subjects';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SubjectsForm.init)  {
                SubjectsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(SubjectsForm, [
                    'SubjectCode', w0,
                    'Name', w0
                ]);
            }
        }
    }
}

