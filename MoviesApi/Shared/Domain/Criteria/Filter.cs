namespace MoviesApi.Shared
{
    public class Filter
    {
        private string field;

        private string operatorOption;

        private string value;

        public Filter(string field, string operatorOption, string value)
        {
            this.field = field;
            this.operatorOption = operatorOption;
            this.value = value;
        }
    }
}