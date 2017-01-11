using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Classification
{
    public class RootClassification
    {
        [JsonProperty("classifications")]
        public IList<Classification> Classifications { get; set; }
    }
}