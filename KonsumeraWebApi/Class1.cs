using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KonsumeraWebApi
{
    public class Class1
    {
        [property: JsonPropertyName("name")]
        public string Name { get; set; }

        [property: JsonPropertyName("description")]
        public string Description { get; set; }

        [property: JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [property: JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [property: JsonPropertyName("watchers")]
        public int Watchers { get; set; }

        [property: JsonPropertyName("pushed_at")]
        public DateTime PuashedAt { get; set; }
    }
}
