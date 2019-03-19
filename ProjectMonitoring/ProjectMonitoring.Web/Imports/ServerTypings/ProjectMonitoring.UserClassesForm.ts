namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserClassesForm {
        UserId: Serenity.IntegerEditor;
        ClassId: Serenity.IntegerEditor;
    }

    export class UserClassesForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.UserClasses';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserClassesForm.init)  {
                UserClassesForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;

                Q.initFormType(UserClassesForm, [
                    'UserId', w0,
                    'ClassId', w0
                ]);
            }
        }
    }
}

