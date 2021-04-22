using System.Collections.Generic;

namespace MoviesApi.Shared.Domain.Criteria
{
    public class Criteria
    {
        private int limit;

        private int offset;

        private string order;

        private List<string> filters;


        public Criteria(List<string> filters, string order, int offset, int limit)
        {
            this.filters = filters;
            this.limit = limit;
            this.order = order;
            this.offset = offset;
        }

        public bool HasFilters()
        {
            return this.filters.Count > 0;
        }

        public bool HasOrder()
        {
            return !string.IsNullOrEmpty(this.order);
        }

        public string[] PlainFilters()
        {
            return this.filters.ToArray();
        }

        public string Order
        {
            get { return order; }
        }

        public int Offset
        {
            get { return offset; }
        }

        public int Limit
        {
            get { return limit; }
        }

        public string Serialize()
        {

            return $"{this.filters.ToString()}~~{this.order.ToString()}~~{this.offset}~~{this.limit}";
        }


    }
}