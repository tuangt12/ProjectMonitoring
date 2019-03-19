
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

        export namespace Fields {
            export declare const Id;
            export declare const Title;
            export declare const ContentPost;
            export declare const UserClassId;
            export declare const CreateDate;
            export declare const CreateBy;
            export declare const CreateByUserCode;
            export declare const CreateByName;
            export declare const CreateByBirthday;
            export declare const CreateByPhone;
            export declare const CreateByAddress;
            export declare const CreateByEmail;
        }

        [
            'Id',
            'Title',
            'ContentPost',
            'UserClassId',
            'CreateDate',
            'CreateBy',
            'CreateByUserCode',
            'CreateByName',
            'CreateByBirthday',
            'CreateByPhone',
            'CreateByAddress',
            'CreateByEmail'
        ].forEach(x => (<any>Fields)[x] = x);
    }
}