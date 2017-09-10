using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIWebApplication.data
{
    public class Repos
    {
        public string Name { get; set; }
        public string Description { get; set; }
        [JsonProperty("watchers_count")]
        public int Watchers { get; set; }
        [JsonProperty("stargazers_count")]
        public int Stars { get; set; }
    }
}
