using System.Collections.Generic;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Fields
{
    public class RootFields
    {
        [JsonProperty("fields")]
        public IList<Field> Fields { get; set; }
    }
}