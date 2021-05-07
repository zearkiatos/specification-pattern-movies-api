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
                Content = new StringContent(MoviesMock.MOVIES_ONE_RESPONSE, Encoding.UTF8, "application/json")
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
        }
    }
}