using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Comment
{
    public class BugComments
    {
        [JsonProperty("comments")]
        public IList<Comment> Comments { get; set; }
    }
}