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
using MoviesApi.Shared.Domain.Criterials;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            HttpClient httpClient = new HttpClient();
            MoviesApiRepository movieRepository = new MoviesApiRepository(httpClient);
            var result = await movieRepository.SearchAll();
            return Ok(result);
        }

        [HttpGet]
        [Route("ByCriterial")]
        public async Task<IActionResult> GetByCriterial([FromBody] CriterialRequest criterialRequest)
        {
            HttpClient httpClient = new HttpClient();
            MoviesApiRepository movieRepository = new MoviesApiRepository(httpClient);
            Criteria criterial = new Criteria(null,criterialRequest.Order,criterialRequest.Offset,criterialRequest.Limit);
            var result = await movieRepository.SearchByCriteria(criterial);
            return Ok(result);
        }
    }
}