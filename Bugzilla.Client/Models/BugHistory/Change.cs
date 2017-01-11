using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugHistory
{
    public class Change
    {
        [JsonProperty("added")]
        public string Added { get; set; }

        [JsonProperty("field_name")]
        public string FieldName { get; set; }

        [JsonProperty("removed")]
        public string Removed { get; set; }
    }
}