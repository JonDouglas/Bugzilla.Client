using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Fields
{
    public class Field
    {
        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_custom")]
        public bool IsCustom { get; set; }

        [JsonProperty("is_mandatory")]
        public bool IsMandatory { get; set; }

        [JsonProperty("is_on_bug_entry")]
        public bool IsOnBugEntry { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public int Type { get; set; }

        [JsonProperty("value_field")]
        public string ValueField { get; set; }

        [JsonProperty("values")]
        public IList<Value> Values { get; set; }

        [JsonProperty("visibility_field")]
        public string VisibilityField { get; set; }

        [JsonProperty("visibility_values")]
        public IList<string> VisibilityValues { get; set; }
    }
}