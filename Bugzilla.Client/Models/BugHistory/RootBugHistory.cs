using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugHistory
{
    public class RootBugHistory
    {
        [JsonProperty("bugs")]
        public IList<BugHistory> Bugs { get; set; }
    }
}