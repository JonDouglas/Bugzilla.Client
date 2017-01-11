using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Classification
{
    public class Product
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}