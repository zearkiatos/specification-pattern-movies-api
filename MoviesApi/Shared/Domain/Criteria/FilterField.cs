using MoviesApi.Shared.Domain.ValueObject;
namespace MoviesApi.Shared.Domain.Criteria
{
    public class FilterField : StringValueObject

    {
        public FilterField(string value)
        {
            this.value = value;
        }
    }
}