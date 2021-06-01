using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using MoviesApi.Movies.Domain;
using MoviesApi.Shared.Domain.Criterials;
using System.Net.Http;
using System.Net.Http.Headers;
using MoviesApi.Configuration;
using MoviesApi.Shared.Utils;
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
        async public Task<DataMovie> SearchAll()
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
                return await Task.Run(() => { return result.Data; });
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

        async public Task<DataMovie> SearchByCriteria(Criteria criteria)
        {
            try
            {
                ResponseMovie responseMovie = new ResponseMovie();
                HttpResponseMessage response = new HttpResponseMessage();

                response = await this.client.GetAsync($"list_movies.json?${this.QueryMapper(criteria)}");
                if (response.IsSuccessStatusCode)
                {
                    string jsonStr = await response.Content.ReadAsStringAsync();

                    responseMovie = JsonConvert.DeserializeObject<ResponseMovie>(jsonStr);

                    responseMovie.Data.Movies = criteria.HasFilters() ? await FilterFieldMapper(responseMovie.Data.Movies, criteria.Filters) : responseMovie.Data.Movies;

                }
                return await Task.Run(() => { return responseMovie.Data; });
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

        public async Task<List<Movie>> FilterFieldMapper(List<Movie> movies, List<Filter> filters)
        {
            List<Movie> movieFilered = movies;
            foreach(var filter in filters)
            {
                string queryBuilded = this.FilterMapper(filter.FilterField, filter.FilterOperator, filter.FilterValue);
                var expression = await MovieFilterHelper.ConvertStringToPredicate(queryBuilded);
                movieFilered = movieFilered.Where(expression).ToList();
            }

            return Task.Run(() => movieFilered).Result;
        }

        public string FilterMapper(string filterField, string filterOperator, string filterValue) 
        {
            if (filterOperator == "like")
                return $"movie => movie.{filterField}.Contains(\"{filterValue}\")";

            return $"movie => movie.{filterField} {filterOperator} {filterValue}";
        }

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