using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Fields
{
    public class CanChangeTo
    {
        [JsonProperty("comment_required")]
        public bool CommentRequired { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}