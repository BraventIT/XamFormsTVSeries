using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XamFormsTVSeries.Models
{
    public class TVShowsApiData<TResult>
    {
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("limit")]
        public int Limit { get; set; }
        [JsonProperty("results")]
        public List<TResult> Results { get; set; }
    }
}
