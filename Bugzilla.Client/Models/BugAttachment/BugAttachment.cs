using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.BugAttachment
{
    public class BugAttachment
    {
        [JsonProperty("bug_id")]
        public int BugId { get; set; }

        [JsonProperty("content_type")]
        public string ContentType { get; set; }

        [JsonProperty("creation_time")]
        public DateTime CreationTime { get; set; }

        [JsonProperty("creator")]
        public string Creator { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("file_name")]
        public string FileName { get; set; }

        [JsonProperty("flags")]
        public IList<object> Flags { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("is_obsolete")]
        public int IsObsolete { get; set; }

        [JsonProperty("is_patch")]
        public int IsPatch { get; set; }

        [JsonProperty("is_private")]
        public int IsPrivate { get; set; }

        [JsonProperty("last_change_time")]
        public DateTime LastChangeTime { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("summary")]
        public string Summary { get; set; }
    }
}