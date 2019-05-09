using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace ProjectMonitoring.ProjectMonitoring
{
    public partial class SCMUserNameFormatterAttribute : CustomFormatterAttribute
    {
        public const string Key = "ProjectMonitoring.ProjectMonitoring.SCMUserNameFormatter";

        public SCMUserNameFormatterAttribute()
            : base(Key)
        {
        }
    }
}

