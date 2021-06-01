using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesApi.Shared.Domain.Criterials;
namespace MoviesApi.Movies.Domain
{
    interface MovieRepository
    {
        Task<DataMovie> SearchAll();

        Task<DataMovie> SearchByCriteria(Criteria criteria);
    }
}