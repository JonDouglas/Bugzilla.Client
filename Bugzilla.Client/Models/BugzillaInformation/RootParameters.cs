using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class RootParameters
    {
        [JsonProperty("parameters")]
        public Parameters Parameters { get; set; }
    }
}