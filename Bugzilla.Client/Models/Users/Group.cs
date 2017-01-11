using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Users
{
    public class Group
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}