using System.Collections.Generic;

namespace MoviesApi.Shared.Domain.Criterials
{
    public class Filter
    {
        public Filter()
        {

        }

        public Filter(string filterField, string filterOperator, string filterValue)
        {
            this.filterField = filterField;
            this.filterOperator = filterOperator;
            this.filterValue = filterValue;
        }
        private string filterField;
        public string FilterField
        {
            get { return filterField; }
            set { filterField = value; }
        }

        private string filterOperator;
        public string FilterOperator
        {
            get { return filterOperator; }
            set { filterOperator = value; }
        }

        private string filterValue;
        public string FilterValue
        {
            get { return filterValue; }
            set { filterValue = value; }
        }

        public string Serialization()
        {
            return $"{this.filterField} {this.filterOperator} {this.filterValue}";
        }



    }
}