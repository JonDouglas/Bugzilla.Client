using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugAttachment
{
    public class RootBugAttachment
    {
        [JsonProperty("attachments")]
        public Attachments Attachments { get; set; }

        [JsonProperty("bugs")]
        public Dictionary<string, List<BugAttachment>> Bugs { get; set; }
    }
}