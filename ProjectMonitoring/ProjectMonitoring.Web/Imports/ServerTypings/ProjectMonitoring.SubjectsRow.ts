namespace ProjectMonitoring.ProjectMonitoring {
    export interface SubjectsRow {
        Id?: number;
        SubjectCode?: string;
        Name?: string;
    }

    export namespace SubjectsRow {
        export const idProperty = 'Id';
        export const nameProperty = 'SubjectCode';
        export const localTextPrefix = 'ProjectMonitoring.Subjects';

        export declare const enum Fields {
            Id = "Id",
            SubjectCode = "SubjectCode",
            Name = "Name"
        }
    }
}

