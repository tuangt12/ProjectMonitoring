namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserClassesForm {
        UserId: Serenity.LookupEditor;
        UserDisplayName: Serenity.StringEditor;
        ClassId: Serenity.LookupEditor;
        ClassSubjectCode: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Point: Serenity.StringEditor;
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
                var w1 = s.StringEditor;

                Q.initFormType(UserClassesForm, [
                    'UserId', w0,
                    'UserDisplayName', w1,
                    'ClassId', w0,
                    'ClassSubjectCode', w1,
                    'Name', w1,
                    'Point', w1
                ]);
            }
        }
    }
}

