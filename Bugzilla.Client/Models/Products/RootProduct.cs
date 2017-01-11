using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Products
{
    public class RootProduct
    {
        [JsonProperty("products")]
        public IList<Product> Products { get; set; }
    }
}
