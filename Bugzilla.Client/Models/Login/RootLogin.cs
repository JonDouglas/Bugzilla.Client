using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace Bugzilla.Client.Models.Login
{
    public class RootLogin
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
