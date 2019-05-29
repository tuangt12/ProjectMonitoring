namespace ProjectMonitoring.ProjectMonitoring {
    export interface SCMsForm {
        ScmTypeId: SCMsTypeLookupEditor;
        ScmLink: Serenity.StringEditor;
        UserClassId: Serenity.LookupEditor;
    }

    export class SCMsForm extends Serenity.PrefixedContext {
        static formKey = 'ProjectMonitoring.SCMs';
        private static init: boolean;

        constructor(prefix: string) {
            super(prefix);

            if (!SCMsForm.init)  {
                SCMsForm.init = true;

                var s = Serenity;
                var w0 = SCMsTypeLookupEditor;
                var w1 = s.StringEditor;
                var w2 = s.LookupEditor;

                Q.initFormType(SCMsForm, [
                    'ScmTypeId', w0,
                    'ScmLink', w1,
                    'UserClassId', w2
                ]);
            }
        }
    }
}

