namespace ProjectMonitoring.ProjectMonitoring {
    export interface UserRow {
        Id?: number;
        UserCode?: string;
        Name?: string;
        Birthday?: string;
        Phone?: string;
        Address?: string;
        Email?: string;
    }

    export namespace UserRow {
        export const idProperty = 'Id';
        export const nameProperty = 'UserCode';
        export const localTextPrefix = 'ProjectMonitoring.User';

        export declare const enum Fields {
            Id = "Id",
            UserCode = "UserCode",
            Name = "Name",
            Birthday = "Birthday",
            Phone = "Phone",
            Address = "Address",
            Email = "Email"
        }
    }
}

