namespace ProjectMonitoring.ProjectMonitoring {
    export interface ClassesRow {
        Id?: number;
        ClassCode?: string;
        SubjectCode?: string;
        MidExamCode?: string;
        FinalExamCode?: string;
        StartDate?: string;
        IsFinished?: number;
    }

    export namespace ClassesRow {
        export const idProperty = 'Id';
        export const nameProperty = 'ClassCode';
        export const localTextPrefix = 'ProjectMonitoring.Classes';

        export declare const enum Fields {
            Id = "Id",
            ClassCode = "ClassCode",
            SubjectCode = "SubjectCode",
            MidExamCode = "MidExamCode",
            FinalExamCode = "FinalExamCode",
            StartDate = "StartDate",
            IsFinished = "IsFinished"
        }
    }
}

