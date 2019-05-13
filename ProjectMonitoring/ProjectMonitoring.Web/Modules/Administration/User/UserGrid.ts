namespace ProjectMonitoring.Administration {

    @Serenity.Decorators.registerClass()
    export class UserGrid extends Serenity.EntityGrid<UserRow, any> {
        protected getColumnsKey() { return "Administration.User"; }
        protected getDialogType() { return UserDialog; }
        protected getIdProperty() { return UserRow.idProperty; }
        protected getIsActiveProperty() { return UserRow.isActiveProperty; }
        protected getLocalTextPrefix() { return UserRow.localTextPrefix; }
        protected getService() { return UserService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getDefaultSortBy() {
            return [UserRow.Fields.Username];
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            let fld = UserRow.Fields;
            let txt = (s) => Q.text("Db." +
                UserRow.localTextPrefix + "." + s).toLowerCase();
            return [
                { name: "", title: "all" },
                { name: fld.Username, title: txt(fld.Username) },
                { name: fld.UserCode, title: txt(fld.UserCode) },
                { name: fld.DisplayName, title: txt(fld.DisplayName) },
                { name: fld.Level, title: txt(fld.Level) }
            ];
        }
    }
}