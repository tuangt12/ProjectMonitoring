
namespace ProjectMonitoring.ProjectMonitoring {
    export class PostsForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.Posts';
    }

    export interface PostsForm {
        Title: Serenity.StringEditor;
        ContentPost: Serenity.StringEditor;
        UserClassId: Serenity.IntegerEditor;
        CreateDate: Serenity.DateEditor;
        CreateBy: Serenity.IntegerEditor;
    }

    [,
        ['Title', () => Serenity.StringEditor],
        ['ContentPost', () => Serenity.StringEditor],
        ['UserClassId', () => Serenity.IntegerEditor],
        ['CreateDate', () => Serenity.DateEditor],
        ['CreateBy', () => Serenity.IntegerEditor]
    ].forEach(x => Object.defineProperty(PostsForm.prototype, <string>x[0], {
        get: function () {
            return this.w(x[0], (x[1] as any)());
        },
        enumerable: true,
        configurable: true
    }));
}