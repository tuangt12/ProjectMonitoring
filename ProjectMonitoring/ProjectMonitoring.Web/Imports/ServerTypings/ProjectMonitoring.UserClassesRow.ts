namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserClassesRow {
        Id?: number;
        UserId?: number;
        ClassId?: number;
        UserUserCode?: string;
        UserName?: string;
        UserBirthday?: string;
        UserPhone?: string;
        UserAddress?: string;
        UserEmail?: string;
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

        export declare const enum Fields {
            Id = "Id",
            UserId = "UserId",
            ClassId = "ClassId",
            UserUserCode = "UserUserCode",
            UserName = "UserName",
            UserBirthday = "UserBirthday",
            UserPhone = "UserPhone",
            UserAddress = "UserAddress",
            UserEmail = "UserEmail",
            ClassClassCode = "ClassClassCode",
            ClassSubjectCode = "ClassSubjectCode",
            ClassMidExamCode = "ClassMidExamCode",
            ClassFinalExamCode = "ClassFinalExamCode",
            ClassStartDate = "ClassStartDate",
            ClassIsFinished = "ClassIsFinished"
        }
    }
}

