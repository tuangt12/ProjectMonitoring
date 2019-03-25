namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserForm {
        UserCode: Serenity.StringEditor;
        Name: Serenity.StringEditor;
        Birthday: Serenity.DateEditor;
        Phone: Serenity.StringEditor;
        Address: Serenity.StringEditor;
        Email: Serenity.StringEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateEditor;

                Q.initFormType(UserForm, [
                    'UserCode', w0,
                    'Name', w0,
                    'Birthday', w1,
                    'Phone', w0,
                    'Address', w0,
                    'Email', w0
                ]);
            }
        }
    }
}

