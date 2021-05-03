using System.Collections.Generic;
using System.Threading.Tasks;
using MoviesApi.Shared.Domain.Criterials;
namespace MoviesApi.Movies.Domain
{
    interface MovieRepository
    {
        Task<List<Movie>> SearchAll();

        Task<List<Movie>> SearchByCriteria(Criteria criteria);
    }
}