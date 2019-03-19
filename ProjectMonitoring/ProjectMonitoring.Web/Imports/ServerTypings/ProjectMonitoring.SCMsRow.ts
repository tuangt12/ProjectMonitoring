namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMsRow {
        Id?: number;
        ScmTypeId?: number;
        ScmLink?: string;
        UserClassId?: number;
        ScmTypeName?: string;
        UserClassUserId?: number;
        UserClassClassId?: number;
    }

    export namespace SCMsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ScmLink';
        export const localTextPrefix = 'ProjectMonitoring.SCMs';

        export declare const enum Fields {
            Id = "Id",
            ScmTypeId = "ScmTypeId",
            ScmLink = "ScmLink",
            UserClassId = "UserClassId",
            ScmTypeName = "ScmTypeName",
            UserClassUserId = "UserClassUserId",
            UserClassClassId = "UserClassClassId"
        }
    }
}

