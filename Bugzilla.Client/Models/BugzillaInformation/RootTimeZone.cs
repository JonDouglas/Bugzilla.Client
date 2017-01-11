using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class RootTimeZone
    {
        [JsonProperty("timezone")]
        public string Timezone { get; set; }
    }
}