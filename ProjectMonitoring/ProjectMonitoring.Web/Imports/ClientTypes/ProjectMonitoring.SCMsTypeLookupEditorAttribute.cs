using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    public partial class SCMsTypeLookupEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "ProjectMonitoring.ProjectMonitoring.SCMsTypeLookupEditor";

        public SCMsTypeLookupEditorAttribute()
            : base(Key)
        {
        }
    }
}

