using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class RootExtensions
    {
        [JsonProperty("extensions")]
        public Extensions Extensions { get; set; }
    }
}