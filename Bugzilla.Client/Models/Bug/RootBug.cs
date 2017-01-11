using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Bug
{
    public class RootBug
    {
        [JsonProperty("bugs")]
        public IList<Bug> Bugs { get; set; }

        [JsonProperty("faults")]
        public IList<object> Faults { get; set; }
    }
}