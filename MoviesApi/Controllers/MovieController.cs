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
            // var rng = new Random();
            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Summaries[rng.Next(Summaries.Length)],
            //     Environment = Environment.GetEnvironmentVariable("ASPNETCORE_BASE_YTS_URL")
            // })
            // .ToArray();

            return result.ToArray();
        }
    }
}