using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Comment
{
    public class Comment
    {
        [JsonProperty("attachment_id")]
        public object AttachmentId { get; set; }

        [JsonProperty("bug_id")]
        public int BugId { get; set; }

        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_private")]
        public bool IsPrivate { get; set; }

        [JsonProperty("tags")]
        public IList<object> Tags { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("time")]
        public DateTime Time { get; set; }
    }
}