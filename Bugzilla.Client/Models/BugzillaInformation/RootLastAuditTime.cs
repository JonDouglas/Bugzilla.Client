using System;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class RootLastAuditTime
    {
        [JsonProperty("last_audit_time")]
        public DateTime LastAuditTime { get; set; }
    }
}