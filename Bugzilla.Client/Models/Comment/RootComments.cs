using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Comment
{
    public class RootComments
    {
        [JsonProperty("bugs")]
        public Dictionary<string, BugComments> Bugs { get; set; }

        [JsonProperty("comments")]
        public Comments Comments { get; set; }
    }
}