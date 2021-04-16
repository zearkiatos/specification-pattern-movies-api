namespace MoviesApi.Shared.Domain.ValueObject
{
    public class StringValueObject
    {
        public StringValueObject(string value) 
        {
            this.value = value;
        }

        protected string value;
        public string Value
        {
            get { return value; }
        }
        
    }
}