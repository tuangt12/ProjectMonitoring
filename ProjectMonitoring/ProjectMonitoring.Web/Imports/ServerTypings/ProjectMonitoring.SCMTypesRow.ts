namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMTypesRow {
        Id?: number;
        Name?: string;
    }

    export namespace SCMTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'ProjectMonitoring.SCMTypes';
        export const lookupKey = 'dbo.SCMsTypes';

        export function getLookup(): Q.Lookup<SCMTypesRow> {
            return Q.getLookup<SCMTypesRow>('dbo.SCMsTypes');
        }

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}

