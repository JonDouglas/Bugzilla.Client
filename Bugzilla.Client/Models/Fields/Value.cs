using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Fields
{
    public class Value
    {
        [JsonProperty("can_change_to")]
        public IList<CanChangeTo> CanChangeTo { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("is_active")]
        public bool? IsActive { get; set; }

        [JsonProperty("is_open")]
        public bool? IsOpen { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("sortkey")]
        public int Sortkey { get; set; }

        [JsonProperty("sort_key")]
        public int SortKey { get; set; }

        [JsonProperty("visibility_values")]
        public IList<string> VisibilityValues { get; set; }
    }
}