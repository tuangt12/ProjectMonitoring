namespace ProjectMonitoring.ProjectMonitoring {
    export interface PostsRow {
        Id?: number;
        Title?: string;
        ContentPost?: string;
        UserClassId?: number;
        CreateDate?: string;
        CreateBy?: number;
        CreateByUserCode?: string;
        CreateByName?: string;
        CreateByBirthday?: string;
        CreateByPhone?: string;
        CreateByAddress?: string;
        CreateByEmail?: string;
    }

    export namespace PostsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Title';
        export const localTextPrefix = 'ProjectMonitoring.Posts';

        export declare const enum Fields {
            Id = "Id",
            Title = "Title",
            ContentPost = "ContentPost",
            UserClassId = "UserClassId",
            CreateDate = "CreateDate",
            CreateBy = "CreateBy",
            CreateByUserCode = "CreateByUserCode",
            CreateByName = "CreateByName",
            CreateByBirthday = "CreateByBirthday",
            CreateByPhone = "CreateByPhone",
            CreateByAddress = "CreateByAddress",
            CreateByEmail = "CreateByEmail"
        }
    }
}

