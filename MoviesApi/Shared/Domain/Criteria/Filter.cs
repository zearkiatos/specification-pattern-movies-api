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
        public string Field
        {
            get { return field; }
        }

        public string OperatorOption
        {
            get { return operatorOption; }
        }

        public string Value
        {
            get { return value; }
        }

        public string Serialize()
        {
            return $"{this.field}.{this.operatorOption}.${this.value}";
        }

    }
}