using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class ExtraDataTokens
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}