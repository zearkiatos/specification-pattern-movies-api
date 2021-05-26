using System.Collections.Generic;
using Newtonsoft.Json;
namespace MoviesApi.Shared.Domain.Criterials
{
    public class CriterialRequest 
    {
        [JsonProperty("limit")]
        private int limit;
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        [JsonProperty("order")]
        private string order;
        public string Order
        {
            get { return order; }
            set { order = value; }
        }

        [JsonProperty("offset")]
        private int offset;
        public int Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        [JsonProperty("filters")]

        private List<FilterRequest> filters;
        public List<FilterRequest> Filters
        {
            get { return filters; }
            set { filters = value; }
        }
        
        
        
        
    }
}