using System;
using System.Text;
using Xunit;
using Moq;
using Moq.Protected;
using System.Net;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using MoviesApi.Movies.Domain;
using System.Threading;
using System.Threading.Tasks;
using MoviesApi.Tests.Movies.Infrastructure.Mock;
using MoviesApi.Movies.Infrastructure;
using MoviesApi.Shared.Domain.Criterials;
namespace MoviesApi.Tests.Movies.Infrastructure
{
    public class MoviesApiRepositoryIntegrationTest
    {

        [Fact]
        public async void Should_Return_Movies_List_Mapped()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(MoviesMock.MovieOneResponseMock().ToString(), Encoding.UTF8, "application/json")
            };

            handlerMock.Protected().Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            var httpClient = new HttpClient(handlerMock.Object);
            var moviesApiRepository = new MoviesApiRepository(httpClient);

            var result = await moviesApiRepository.SearchAll();

            Assert.NotNull(result);
            Assert.Equal(result.Count, 1);
            Assert.True(result.Exists(m => m.Id == 31506));
            Movie movie = result.Find(m => m.Id == 31506);
            Assert.Equal(movie.Description, "Hyunjuli, who accidentally falls into a fantasy world of the Moonlit Palace, fights against the evil Blossom Lady to protect her new friends.");
            Assert.Equal(movie.BackgroundImage, "https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/background.jpg");
            Assert.Equal(movie.YoutubeTrailerCode, "https://youtu.be/5uJikUpZB8U");
        }

        [Fact]
        public async void Should_Return_Movies_List_With_Limit_Ten()
        {
            var handlerMock = new Mock<HttpMessageHandler>();
            var response = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(MoviesMock.MovieLimitTenMock().ToString(), Encoding.UTF8, "application/json")
            };
            Criteria criteria = new Criteria(new List<string>(),"",1, 10);

            handlerMock.Protected().Setup<Task<HttpResponseMessage>>(
                  "SendAsync",
                  ItExpr.IsAny<HttpRequestMessage>(),
                  ItExpr.IsAny<CancellationToken>())
               .ReturnsAsync(response);

            var httpClient = new HttpClient(handlerMock.Object);
            var moviesApiRepository = new MoviesApiRepository(httpClient);

            var result = await moviesApiRepository.SearchByCriteria(criteria);
            Assert.NotNull(result);
            Assert.Equal(result.Count, 10);
            Assert.True(result.Exists(m => m.Id == 31663));
            Assert.Equal(result.Find(m => m.Id == 31663).Description, "Lorem Ipsum");
            Assert.Equal(result.Find(m => m.Id == 31660).BackgroundImage, "https://yts.mx/assets/images/movies/the_kings_case_note_2017/background.jpg");
            Assert.Equal(result.Find(m => m.Id == 31661).YoutubeTrailerCode, "https://youtu.be/");
        }
    }
}