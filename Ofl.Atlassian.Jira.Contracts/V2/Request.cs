﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Ofl.Core;

namespace Ofl.Atlassian.Jira.V2
{
    public abstract class Request
    {
        [JsonConverter(typeof(ExpandsPropertyPathConverter))]
        public List<PropertyPath> Expand { get; } = new List<PropertyPath>();
    }
}
