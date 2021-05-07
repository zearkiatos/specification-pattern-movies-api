using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApi.Movies.Domain;
using System.Net.Http;
using System.Net.Http.Headers;
using MoviesApi.Movies.Infrastructure;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        [HttpGet]
        public async Task<Array> Get()
        {
            HttpClient httpClient = new HttpClient();
            MoviesApiRepository movieRepository = new MoviesApiRepository(httpClient);
            var result = await movieRepository.SearchAll();
            return result.ToArray();
        }
    }
}