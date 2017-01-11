using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Version
{
    public class RootVersion
    {
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}