namespace ProjectMonitoring.ProjectMonitoring {
    export interface ClassesForm {
        ClassCode: Serenity.StringEditor;
        SubjectCode: Serenity.StringEditor;
        MidExamCode: Serenity.StringEditor;
        FinalExamCode: Serenity.StringEditor;
        StartDate: Serenity.DateEditor;
        IsFinished: Serenity.IntegerEditor;
    }

    export class ClassesForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.Classes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!ClassesForm.init)  {
                ClassesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(ClassesForm, [
                    'ClassCode', w0,
                    'SubjectCode', w0,
                    'MidExamCode', w0,
                    'FinalExamCode', w0,
                    'StartDate', w1,
                    'IsFinished', w2
                ]);
            }
        }
    }
}

