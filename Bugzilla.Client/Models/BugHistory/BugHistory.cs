using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugHistory
{
    public class BugHistory
    {
        [JsonProperty("alias")]
        public IList<object> Alias { get; set; }

        [JsonProperty("history")]
        public IList<History> History { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}