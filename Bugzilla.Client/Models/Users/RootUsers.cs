using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Users
{
    public class RootUsers
    {
        [JsonProperty("users")]
        public IList<User> Users { get; set; }
    }
}