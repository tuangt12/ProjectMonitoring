namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMsForm {
        ScmTypeId: Serenity.LookupEditor;
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
                var w0 = s.LookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.IntegerEditor;

                Q.initFormType(SCMsForm, [
                    'ScmTypeId', w0,
                    'ScmLink', w1,
                    'UserClassId', w2
                ]);
            }
        }
    }
}

