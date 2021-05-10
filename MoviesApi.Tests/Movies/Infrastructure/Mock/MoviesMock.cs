using Newtonsoft.Json.Linq;
namespace MoviesApi.Tests.Movies.Infrastructure.Mock
{
    abstract class MoviesMock
    {

        public static JObject MovieOneResponseMock()
        {
            var json = JObject.Parse(MOVIES_ONE_RESPONSE);
            return json;
        }

        private const string MOVIES_ONE_RESPONSE = @"{
    'status': 'ok',
    'status_message': 'Query was successful',
    'data': {
        'movie_count': 30905,
        'limit': 20,
        'page_number': 1,
        'movies': [
            {
                'id': 31506,
                'url': 'https://yts.mx/movies/lost-in-the-moonlight-2016',
                'imdb_code': 'tt6043124',
                'title': 'Lost in the Moonlight',
                'title_english': 'Lost in the Moonlight',
                'title_long': 'Lost in the Moonlight (2016)',
                'slug': 'lost-in-the-moonlight-2016',
                'year': 2016,
                'rating': 6,
                'runtime': 80,
                'genres': [
                    'Animation'
                ],
                'summary': 'Hyunjuli, who accidentally falls into a fantasy world of the Moonlit Palace, fights against the evil Blossom Lady to protect her new friends.',
                'description_full': 'Hyunjuli, who accidentally falls into a fantasy world of the Moonlit Palace, fights against the evil Blossom Lady to protect her new friends.',
                'synopsis': 'Hyunjuli, who accidentally falls into a fantasy world of the Moonlit Palace, fights against the evil Blossom Lady to protect her new friends.',
                'yt_trailer_code': '5uJikUpZB8U',
                'language': 'ko',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/lost_in_the_moonlight_2016/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/E973262DA7C657AA8DF4D132184B09CD80F03D5D',
                        'hash': 'E973262DA7C657AA8DF4D132184B09CD80F03D5D',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '744.51 MB',
                        'size_bytes': 780675318,
                        'date_uploaded': '2021-05-09 14:50:42',
                        'date_uploaded_unix': 1620564642
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/6963C909606D756BA6F8AD9FDEA93D8470A736E4',
                        'hash': '6963C909606D756BA6F8AD9FDEA93D8470A736E4',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.35 GB',
                        'size_bytes': 1449551462,
                        'date_uploaded': '2021-05-09 15:40:55',
                        'date_uploaded_unix': 1620567655
                    }
                ],
                'date_uploaded': '2021-05-09 14:50:42',
                'date_uploaded_unix': 1620564642
            }
        ]
    }
}";

    }
}