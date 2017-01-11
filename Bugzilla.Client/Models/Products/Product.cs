using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class Product
    {

        [JsonProperty("versions")]
        public IList<Version> Versions { get; set; }

        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("default_milestone")]
        public string DefaultMilestone { get; set; }

        [JsonProperty("components")]
        public IList<Component> Components { get; set; }

        [JsonProperty("milestones")]
        public IList<Milestone> Milestones { get; set; }

        [JsonProperty("classification")]
        public string Classification { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("has_unconfirmed")]
        public bool HasUnconfirmed { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}