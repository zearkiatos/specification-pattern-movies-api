using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoviesApi.Movies.Domain;
using MoviesApi.Movies.Infraestructure;

namespace MoviesApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        [HttpGet]
        public async Task<Array> Get()
        {
            MoviesApiRepository movieRepository = new MoviesApiRepository();
            var result = await movieRepository.SearchAll();
            return result.ToArray();
        }
    }
}