using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Bug
{
    public class AssignedToDetail
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("real_name")]
        public string RealName { get; set; }
    }
}