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

        [JsonProperty("movie_count")]
        private int movieCount;
        public int MovieCount
        {
            get { return movieCount; }
            set { movieCount = value; }
        }
        
        [JsonProperty("limit")]
        private int limit;
        public int Limit
        {
            get { return limit; }
            set { limit = value; }
        }

        [JsonProperty("page_number")]
        private int pageNumber;
        public int PageNumber
        {
            get { return pageNumber; }
            set { pageNumber = value; }
        }
        
        [JsonProperty("movies")]
        private List<Movie> movies;
        public List<Movie> Movies
        {
            get { return movies; }
            set { movies = value; }
        }
    }
}