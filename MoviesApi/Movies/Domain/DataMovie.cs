using Newtonsoft.Json;
using System.Collections.Generic;
namespace MoviesApi.Movies.Domain
{
    public class DataMovie
    {
        public DataMovie(List<Movie> movies)
        {
            this.movies = movies;
        }

        public DataMovie()
        {

        }
        [JsonProperty("movies")]
        private List<Movie> movies;
        public List<Movie> Movies
        {
            get { return movies; }
        }
    }
}