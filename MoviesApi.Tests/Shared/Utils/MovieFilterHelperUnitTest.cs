using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using MoviesApi.Shared.Utils;
using MoviesApi.Movies.Domain;
using System.Threading.Tasks;
namespace MoviesApi.Tests.Shared.Domain.Criterials
{
    public class MovieFilterHelperUnitTest
    {
        [Fact]
        public async void Should_Convert_String_To_Lambda_Predicate()
        {
            var filter = "movie => movie.Year >= 2021";
            List<Movie> moviesMock = new List<Movie>();
            moviesMock.Add(new Movie(1, "", "Lorem Ipsum", 2021, "", new string[] { "", "" }, "", "", "", "", "", 20, 0.0));
            moviesMock.Add(new Movie(1, "", "Test", 2000, "", new string[] { "", "" }, "", "", "", "", "", 20, 0.0));

            Func<Movie, bool> movieFiltered = await Task.Run(() => { return MovieFilterHelper.ConvertStringToPredicate(filter); });
            
            List<Movie> moviesResult = moviesMock.Where(movieFiltered).ToList();
            
            Assert.Equal(moviesResult.Count, 1);
            Assert.Equal(moviesResult.First().Title,"Lorem Ipsum");
        }

        [Fact]
        public async void Should_Convert_String_To_Lambda_Predicate_With_Contains_Method()
        {
            var filter = "movie => movie.Title.Contains(\"Tes\")";
            List<Movie> moviesMock = new List<Movie>();
            moviesMock.Add(new Movie(1, "", "Lorem Ipsum", 2021, "", new string[] { "", "" }, "", "", "", "", "", 20, 0.0));
            moviesMock.Add(new Movie(1, "", "Test", 2000, "", new string[] { "", "" }, "", "", "", "", "", 20, 0.0));

            Func<Movie, bool> movieFiltered = await Task.Run(() => { return MovieFilterHelper.ConvertStringToPredicate(filter); });
            
            List<Movie> moviesResult = moviesMock.Where(movieFiltered).ToList();
            
            Assert.Equal(moviesResult.Count, 1);
            Assert.Equal(moviesResult.First().Title,"Test");
        }
    }
}