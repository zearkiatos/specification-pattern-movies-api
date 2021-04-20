using MoviesApi.Shared.Domain.ValueObject;
namespace MoviesApi.Shared.Domain.Criteria
{
    public class FilterOperator
    {
        public const string EQUAL = "=";
        public const string NOT_EQUAL = "!=";
        public const string GT = ">";
        public const string LT = "<";
        public const string CONTAINS = "CONTAINS";

        public const string NOT_CONTAINS = "NOT_CONTAINS";

        private static string containing = new string[]{CONTAINS, NOT_CONTAINS};

        public string[] isContaining() {
            return 
        }
    }
}