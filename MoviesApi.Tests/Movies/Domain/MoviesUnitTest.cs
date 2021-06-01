using System;
using Xunit;
using Newtonsoft.Json;
using System.Collections.Generic;
using MoviesApi.Movies.Domain;
namespace MoviesApi.Tests.Movies.Domain
{
    public class MoviesUnitTest
    {
        [Fact]
        public void Should_Declarate_Movies_And_Mapper_To_Json()
        {
            Movie movie = new Movie(
                31224,
                "https://yts.mx/movies/mandabi-1968",
                "Mandabi",
                1968,
                "Lorem Ipsum",
                new string[]{"Drama"},
                "Lorem Ipsum",
                "Lorem Ipsum",
                "UpjM1PY6toks",
                "https://yts.mx/assets/images/movies/mandabi_1968/background.jpg",
                "https://yts.mx/assets/images/movies/mandabi_1968/medium-cover.jpg",
                92,
                7.2
            );

            string json = JsonConvert.SerializeObject(movie);

            Assert.Contains("\"title_english\":\"Mandabi\"",json);
            Assert.Contains("\"description_full\":\"Lorem Ipsum\"",json);
            Assert.Contains("\"yt_trailer_code\":\"UpjM1PY6toks\"",json);
            Assert.Contains("\"background_image\":\"https://yts.mx/assets/images/movies/mandabi_1968/background.jpg\"",json);
            Assert.Contains("\"medium_cover_image\":\"https://yts.mx/assets/images/movies/mandabi_1968/medium-cover.jpg\"",json);
        }
    }
}