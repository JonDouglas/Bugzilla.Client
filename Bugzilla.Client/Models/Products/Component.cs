using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class Component
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("sort_key")]
        public int SortKey { get; set; }

        [JsonProperty("default_qa_contact")]
        public string DefaultQaContact { get; set; }

        [JsonProperty("flag_types")]
        public FlagTypes FlagTypes { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("default_assigned_to")]
        public string DefaultAssignedTo { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}