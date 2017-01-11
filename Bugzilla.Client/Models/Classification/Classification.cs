using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Classification
{
    public class Classification
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("products")]
        public IList<Product> Products { get; set; }

        [JsonProperty("sort_key")]
        public int SortKey { get; set; }
    }
}