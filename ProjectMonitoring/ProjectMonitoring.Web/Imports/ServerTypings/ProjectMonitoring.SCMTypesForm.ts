namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMTypesForm {
        Name: Serenity.StringEditor;
    }

    export class SCMTypesForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.SCMTypes';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SCMTypesForm.init)  {
                SCMTypesForm.init = true;

                var s = Serenity;
                var w0 = s.StringEditor;

                Q.initFormType(SCMTypesForm, [
                    'Name', w0
                ]);
            }
        }
    }
}

