using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MoviesApi.Movies.Domain;
using MoviesApi.Shared.Domain.Criterials;
using System.Net.Http;
using System.Net.Http.Headers;
using MoviesApi.Configuration;
using System.Linq;
namespace MoviesApi.Movies.Infrastructure
{
    public class MoviesApiRepository : MovieRepository
    {

        private HttpClient client;

        public MoviesApiRepository(HttpClient client)
        {
            this.client = client;
            this.client.BaseAddress = new Uri(Constants.BASE_YTS_URL);
            this.client.DefaultRequestHeaders.Add("Accept", "application/json");
            this.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
        async public Task<List<Movie>> SearchAll()
        {
            try
            {
                ResponseMovie result = new ResponseMovie();
                HttpResponseMessage response = new HttpResponseMessage();

                response = await this.client.GetAsync($"list_movies.json?limit={Constants.DEFAULT_LIMIT}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonStr = await response.Content.ReadAsStringAsync();

                    result = JsonConvert.DeserializeObject<ResponseMovie>(jsonStr);
                }
                return await Task.Run(() => { return result.Data.Movies; });
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(string.Format("Error {0}", ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error {0}", ex.Message));
            }
        }

        async public Task<List<Movie>> SearchByCriteria(Criteria criteria)
        {
            try
            {
                ResponseMovie responseMovie = new ResponseMovie();
                List<Movie> movies = new List<Movie>();
                HttpResponseMessage response = new HttpResponseMessage();

                response = await this.client.GetAsync($"list_movies.json?${this.QueryMapper(criteria)}");
                if (response.IsSuccessStatusCode)
                {
                    string jsonStr = await response.Content.ReadAsStringAsync();

                    responseMovie = JsonConvert.DeserializeObject<ResponseMovie>(jsonStr);

                    movies = criteria.HasFilters() ? FilterFieldMapper(responseMovie.Data.Movies, criteria.Filters) : responseMovie.Data.Movies;
                }
                return await Task.Run(() => { return movies; });
            }
            catch (HttpRequestException ex)
            {
                throw new Exception(string.Format("Error {0}", ex.Message));
            }
            catch (Exception ex)
            {
                throw new Exception(string.Format("Error {0}", ex.Message));
            }
        }

        // public List<Movie> FilterFieldMapper(List<Movie> movies, List<Filter> filters)
        // {
        //     List<Movie> movieFilered = movies;
        //     foreach(var filter in filters)
        //     {
        //         var queryBuilded = $"{filter.FilterField} {filter.FilterOperator} {filter.FilterValue}";
        //         movieFilered = movieFilered.Where(queryBuilded).ToList();
        //     }
        // }

        public string QueryMapper(Criteria criteria)
        {
            string criteriaMapped = "";
            
            if (criteria.Limit > 0)
                criteriaMapped += $"?limit={criteria.Limit}";
            else
                criteriaMapped += $"?limit={Configuration.Constants.DEFAULT_LIMIT}";

            if (criteria.HasOrder())
            {
                criteriaMapped += $"&order_by={criteria.Order}";
            }
            else 
            {
                criteriaMapped += $"&order=asc";
            }

            if (criteria.Offset > 0)
            {
                criteriaMapped += $"&page={criteria.Offset}";
            }
            else 
            {
                criteriaMapped += $"&page=1";
            }

            return criteriaMapped;
        }
    }
}