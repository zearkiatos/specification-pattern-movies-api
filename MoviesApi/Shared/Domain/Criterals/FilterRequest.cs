using System.Collections.Generic;
using Newtonsoft.Json;
namespace MoviesApi.Shared.Domain.Criterials
{
    public class FilterRequest
    {
        [JsonProperty("field")]
        public string Field { get; set; }
        [JsonProperty("operator")]
        public string Operator { get; set; }
        [JsonProperty("value")]
        public string Value { get; set; }


    }
}