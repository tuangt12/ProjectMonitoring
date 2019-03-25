namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMTypesRow {
        Id?: number;
        Name?: string;
    }

    export namespace SCMTypesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'Name';
        export const localTextPrefix = 'ProjectMonitoring.SCMTypes';

        export declare const enum Fields {
            Id = "Id",
            Name = "Name"
        }
    }
}

