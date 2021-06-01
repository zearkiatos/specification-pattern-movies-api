using Newtonsoft.Json;
using System.Collections.Generic;

namespace MoviesApi.Movies.Domain
{
    public class ResponseMovie
    {
        public ResponseMovie(DataMovie data)
        {
            this.data = data;
        }

        public ResponseMovie()
        {

        }
        [JsonProperty("data")]
        private DataMovie data;
        public DataMovie Data
        {
            get { return data; }
        }

    }
}