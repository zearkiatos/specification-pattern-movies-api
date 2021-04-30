using System.Collections.Generic;

namespace MoviesApi.Shared.Domain.Criterials
{
    public class Criteria
    {
        private int limit;

        private int offset;

        private string order;

        private List<string> filters;

#nullable enable
        public Criteria(List<string> filters, string order, int offset, int limit)
        {
            this.filters = filters == null ? new List<string>() : filters;
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
            string serialized = "";

            serialized += this.filters.Count > 0 ? $"{string.Join(",", this.filters.ToArray())}~~" : "";

            serialized += string.IsNullOrEmpty(this.order) ? "" : $"{this.order}~~";

            serialized += $"{this.offset}~~{this.limit}";

            return serialized;
        }


    }
}