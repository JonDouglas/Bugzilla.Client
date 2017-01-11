using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class Version
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("sort_key")]
        public int SortKey { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }
    }
}