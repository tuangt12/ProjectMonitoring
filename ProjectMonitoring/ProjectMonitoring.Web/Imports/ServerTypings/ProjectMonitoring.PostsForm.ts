namespace ProjectMonitoring.ProjectMonitoring {
    export interface PostsForm {
        Title: Serenity.StringEditor;
        ContentPost: Serenity.TextAreaEditor;
        UserClassId: Serenity.LookupEditor;
        CreateDate: Serenity.DateEditor;
        CreateBy: Serenity.LookupEditor;
        AttachFilePost: Serenity.ImageUploadEditor;
        AttachImagePost: Serenity.ImageUploadEditor;
    }

    export class PostsForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.Posts';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!PostsForm.init)  {
                PostsForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;
                var w1 = s.TextAreaEditor;
                var w2 = s.LookupEditor;
                var w3 = s.DateEditor;
                var w4 = s.ImageUploadEditor;

                Q.initFormType(PostsForm, [
                    'Title', w0,
                    'ContentPost', w1,
                    'UserClassId', w2,
                    'CreateDate', w3,
                    'CreateBy', w2,
                    'AttachFilePost', w4,
                    'AttachImagePost', w4
                ]);
            }
        }
    }
}

