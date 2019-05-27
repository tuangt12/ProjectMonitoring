namespace ProjectMonitoring.ProjectMonitoring {
    export interface PostsForm {
        Title: Serenity.StringEditor;
        ContentPost: Serenity.StringEditor;
        UserClassId: Serenity.LookupEditor;
        CreateDate: Serenity.DateEditor;
        CreateBy: Serenity.LookupEditor;
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
                var w1 = s.LookupEditor;
                var w2 = s.DateEditor;

                Q.initFormType(PostsForm, [
                    'Title', w0,
                    'ContentPost', w0,
                    'UserClassId', w1,
                    'CreateDate', w2,
                    'CreateBy', w1
                ]);
            }
        }
    }
}

