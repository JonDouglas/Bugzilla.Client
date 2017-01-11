using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class GitHubAuth
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}