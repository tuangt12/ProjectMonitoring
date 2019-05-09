namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserClassesRow {
        Id?: number;
        UserId?: number;
        ClassId?: number;
        UserUserCode?: string;
        UserName?: string;
        UserDisplayName?: string;
        UserBirthday?: string;
        UserPhone?: string;
        UserEmail?: string;
        SubjectId?: number;
        SubjectName?: string;
        ClassClassCode?: string;
        ClassSubjectCode?: string;
        ClassMidExamCode?: string;
        ClassFinalExamCode?: string;
        ClassStartDate?: string;
        ClassIsFinished?: number;
    }

    export namespace UserClassesRow {
        export const idProperty = 'Id';
        export const localTextPrefix = 'ProjectMonitoring.UserClasses';
        export const lookupKey = 'dbo.UserClasses';

        export function getLookup(): Q.Lookup<UserClassesRow> {
            return Q.getLookup<UserClassesRow>('dbo.UserClasses');
        }

        export declare const enum Fields {
            Id = "Id",
            UserId = "UserId",
            ClassId = "ClassId",
            UserUserCode = "UserUserCode",
            UserName = "UserName",
            UserDisplayName = "UserDisplayName",
            UserBirthday = "UserBirthday",
            UserPhone = "UserPhone",
            UserEmail = "UserEmail",
            SubjectId = "SubjectId",
            SubjectName = "SubjectName",
            ClassClassCode = "ClassClassCode",
            ClassSubjectCode = "ClassSubjectCode",
            ClassMidExamCode = "ClassMidExamCode",
            ClassFinalExamCode = "ClassFinalExamCode",
            ClassStartDate = "ClassStartDate",
            ClassIsFinished = "ClassIsFinished"
        }
    }
}

