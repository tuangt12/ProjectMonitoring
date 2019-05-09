namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserClassesForm {
        ClassId: Serenity.LookupEditor;
    }

    export class UserClassesForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.UserClasses';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserClassesForm.init)  {
                UserClassesForm.init = true;

                var s = Serenity;
                var w0 = s.LookupEditor;

                Q.initFormType(UserClassesForm, [
                    'ClassId', w0
                ]);
            }
        }
    }
}

