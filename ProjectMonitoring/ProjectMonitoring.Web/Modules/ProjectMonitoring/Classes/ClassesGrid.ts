
namespace ProjectMonitoring.ProjectMonitoring {

    @Serenity.Decorators.registerClass()
    export class ClassesGrid extends Serenity.EntityGrid<ClassesRow, any> {
        protected getColumnsKey() { return 'ProjectMonitoring.Classes'; }
        protected getDialogType() { return ClassesDialog; }
        protected getIdProperty() { return ClassesRow.idProperty; }
        protected getLocalTextPrefix() { return ClassesRow.localTextPrefix; }
        protected getService() { return ClassesService.baseUrl; }

        constructor(container: JQuery) {
            super(container);
        }

        protected getQuickSearchFields(): Serenity.QuickSearchField[] {
            let fld = ClassesRow.Fields;
            let txt = (s) => Q.text("Db." +
                ClassesRow.localTextPrefix + "." + s).toLowerCase();
            return [
                { name: "", title: "all" },
                { name: fld.ClassCode, title: txt(fld.ClassCode) },
                { name: fld.SubjectCode, title: txt(fld.SubjectCode) }
            ];
        }
    }
}