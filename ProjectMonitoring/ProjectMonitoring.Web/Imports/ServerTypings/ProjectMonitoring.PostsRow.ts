namespace ProjectMonitoring.ProjectMonitoring {
    export interface PostsRow {
        Id?: number;
        Title?: string;
        ContentPost?: string;
        UserClassId?: number;
        CreateDate?: string;
        CreateBy?: number;
        CreateByUserCode?: string;
        CreateByUsername?: string;
        CreateByBirthday?: string;
        CreateByPhone?: string;
        CreateByEmail?: string;
    }

    export namespace PostsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'ProjectMonitoring.Posts';
        export const lookupKey = 'dbo.Posts';

        export function getLookup(): Q.Lookup<PostsRow> {
            return Q.getLookup<PostsRow>('dbo.Posts');
        }

        export declare const enum Fields {
            Id = "Id",
            Title = "Title",
            ContentPost = "ContentPost",
            UserClassId = "UserClassId",
            CreateDate = "CreateDate",
            CreateBy = "CreateBy",
            CreateByUserCode = "CreateByUserCode",
            CreateByUsername = "CreateByUsername",
            CreateByBirthday = "CreateByBirthday",
            CreateByPhone = "CreateByPhone",
            CreateByEmail = "CreateByEmail"
        }
    }
}

