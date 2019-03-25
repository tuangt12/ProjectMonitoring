namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMsForm {
        ScmTypeId: Serenity.IntegerEditor;
        ScmLink: Serenity.StringEditor;
        UserClassId: Serenity.IntegerEditor;
    }

    export class SCMsForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.SCMs';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SCMsForm.init)  {
                SCMsForm.init = true;

                var s = Serenity;
                var w0 = s.IntegerEditor;
                var w1 = s.StringEditor;

                Q.initFormType(SCMsForm, [
                    'ScmTypeId', w0,
                    'ScmLink', w1,
                    'UserClassId', w0
                ]);
            }
        }
    }
}

