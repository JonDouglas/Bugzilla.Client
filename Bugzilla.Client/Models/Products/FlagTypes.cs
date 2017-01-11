using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class FlagTypes
    {

        [JsonProperty("bug")]
        public IList<object> Bug { get; set; }

        [JsonProperty("attachment")]
        public IList<object> Attachment { get; set; }
    }
}