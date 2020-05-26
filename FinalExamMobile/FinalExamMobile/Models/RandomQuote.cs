using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExamMobile.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    class RandomQuote
    {
        [JsonProperty(PropertyName = "quote")]
        public string quote { get; set; }
        [JsonProperty(PropertyName = "author")]
        public string author { get; set; }

        [JsonProperty(PropertyName = "category")]
        public string category { get; set; }
    }
}
