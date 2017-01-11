using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Users
{
    public class User
    {
        [JsonProperty("can_login")]
        public bool CanLogin { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("groups")]
        public IList<Group> Groups { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("real_name")]
        public string RealName { get; set; }

        [JsonProperty("saved_reports")]
        public IList<object> SavedReports { get; set; }

        [JsonProperty("saved_searches")]
        public IList<object> SavedSearches { get; set; }
    }
}