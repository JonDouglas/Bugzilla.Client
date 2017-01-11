using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class RootProducts
    {
        [JsonProperty("ids")]
        public IList<int> Ids { get; set; }
    }
}
