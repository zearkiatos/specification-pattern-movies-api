using System.Collections.Generic;
using Newtonsoft.Json;
namespace MoviesApi.Shared.Domain.Criterials
{
    public class FilterRequest
    {
        [JsonProperty("field")]
        private string filterField;
        public string FilterField
        {
            get { return filterField; }
            set { filterField = value; }
        }
        [JsonProperty("operator")]
        private string filterOperator;
        public string FilterOperator
        {
            get { return filterOperator; }
            set { filterOperator = value; }
        }
        [JsonProperty("value")]
        private string filterValue;
        public string FilterValue
        {
            get { return filterValue; }
            set { filterValue = value; }
        }
        
        
        
    }
}