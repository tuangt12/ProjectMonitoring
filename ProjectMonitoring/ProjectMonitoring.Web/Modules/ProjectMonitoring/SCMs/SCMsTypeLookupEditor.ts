namespace ProjectMonitoring.ProjectMonitoring {
    @Serenity.Decorators.registerEditor()
    export class SCMsTypeLookupEditor extends Serenity.LookupEditorBase<Serenity.LookupEditorOptions, ProjectMonitoring.SCMTypesRow> {

        constructor(container: JQuery, options: Serenity.LookupEditorOptions) {
            super(container, options);
        }

        // get Key Lookup từ bảng SCMType
        protected getLookupKey() {
            return ProjectMonitoring.SCMTypesRow.lookupKey;
        }

        // chuyển nội dung từ id sang Name
        // Hiển thị dạng tên loại mã nguồn thay vì id
        protected getItemText(item: ProjectMonitoring.SCMTypesRow, lookup: Q.Lookup<ProjectMonitoring.SCMTypesRow>) {
            return super.getItemText(item, lookup);
        }
    }
}