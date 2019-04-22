using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    public partial class UserClassesEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "ProjectMonitoring.ProjectMonitoring.UserClassesEditor";

        public UserClassesEditorAttribute()
            : base(Key)
        {
        }
    }
}

