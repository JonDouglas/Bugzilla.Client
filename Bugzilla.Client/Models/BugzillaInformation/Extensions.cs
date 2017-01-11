using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class Extensions
    {
        [JsonProperty("ExtraDataTokens")]
        public ExtraDataTokens ExtraDataTokens { get; set; }

        [JsonProperty("GitHubAuth")]
        public GitHubAuth GitHubAuth { get; set; }
    }
}