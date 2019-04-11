namespace ProjectMonitoring.Administration {
    export interface UserForm {
        Username: Serenity.StringEditor;
        UserCode: Serenity.StringEditor;
        DisplayName: Serenity.StringEditor;
        Birthday: Serenity.DateTimeEditor;
        Phone: Serenity.StringEditor;
        Level: Serenity.StringEditor;
        Email: Serenity.EmailEditor;
        UserImage: Serenity.ImageUploadEditor;
        Password: Serenity.PasswordEditor;
        PasswordConfirm: Serenity.PasswordEditor;
        ClassList: Serenity.LookupEditor;
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
                var w3 = s.ImageUploadEditor;
                var w4 = s.PasswordEditor;
                var w5 = s.LookupEditor;

                Q.initFormType(UserForm, [
                    'Username', w0,
                    'UserCode', w0,
                    'DisplayName', w0,
                    'Birthday', w1,
                    'Phone', w0,
                    'Level', w0,
                    'Email', w2,
                    'UserImage', w3,
                    'Password', w4,
                    'PasswordConfirm', w4,
                    'ClassList', w5
                ]);
            }
        }
    }
}

