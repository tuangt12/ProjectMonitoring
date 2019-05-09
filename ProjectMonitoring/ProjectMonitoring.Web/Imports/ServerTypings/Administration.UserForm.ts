namespace ProjectMonitoring.Administration {
    export interface UserForm {
        Username: Serenity.StringEditor;
        UserCode: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Birthday: Serenity.DateTimeEditor;
        Phone: Serenity.StringEditor;
        Level: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        ClassList: ProjectMonitoring.UserClassesEditor;
        UserImage: Serenity.ImageUploadEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
    }

    export class UserForm extends Serenity.PrefixedContext {
        static formKey = 'Administration.User';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!UserForm.init)  {
                UserForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.DateTimeEditor;
                var w2 = s.EmailEditor;
                var w3 = ProjectMonitoring.UserClassesEditor;
                var w4 = s.ImageUploadEditor;
                var w5 = s.PasswordEditor;

                Q.initFormType(UserForm, [
                    'Username', w0,
                    'UserCode', w0,
                    'DisplayName', w0,
                    'Birthday', w1,
                    'Phone', w0,
                    'Level', w0,
                    'Email', w2,
                    'ClassList', w3,
                    'UserImage', w4,
                    'Password', w5,
                    'PasswordConfirm', w5
                ]);
            }
        }
    }
}

