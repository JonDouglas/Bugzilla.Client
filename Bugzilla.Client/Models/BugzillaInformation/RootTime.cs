using System;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugzillaInformation
{
    public class RootTime
    {
        [JsonProperty("db_time")]
        public DateTime DbTime { get; set; }

        [JsonProperty("tz_name")]
        public string TzName { get; set; }

        [JsonProperty("tz_offset")]
        public string TzOffset { get; set; }

        [JsonProperty("tz_short_name")]
        public string TzShortName { get; set; }

        [JsonProperty("web_time")]
        public DateTime WebTime { get; set; }

        [JsonProperty("web_time_utc")]
        public DateTime WebTimeUtc { get; set; }
    }
}