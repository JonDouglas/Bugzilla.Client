using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Bug
{
    public class History
    {
        [JsonProperty("changes")]
        public IList<Change> Changes { get; set; }

        [JsonProperty("when")]
        public DateTime When { get; set; }

        [JsonProperty("who")]
        public string Who { get; set; }
    }
}