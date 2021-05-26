using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using MoviesApi.Shared.Utils;
using MoviesApi.Movies.Domain;
using System.Threading.Tasks;
namespace MoviesApi.Tests.Shared.Domain.Criterials
{
    public class FilterHelperUnitTest
    {
        [Fact]
        public async void Should_Convert_String_To_Lambda_Predicate()
        {
            var filter = "m => m.Title == \"Test\"";
            List<Movie> moviesMock = new List<Movie>();
            moviesMock.Add(new Movie(1,"","Lorem Ipsum", 2000, "", new string[]{"", ""}, "", "", "", "", "", 20, 0.0));
            moviesMock.Add(new Movie(1,"","Test", 2000, "", new string[]{"", ""}, "", "", "", "", "", 20, 0.0));
            
            Func<Movie, bool> movieFiltered = await Task.Run(() => { return FilterHelper<Movie>.ConvertStringToPredicate(filter); });

            List<Movie> moviesResult= moviesMock.Where(movieFiltered).ToList();

            Assert.Equal(moviesResult.Count, 1);
            Assert.Equal(moviesResult.First().Title,"Test");
        }
    }
}