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

        public static JObject MovieLimitTenMock()
        {
            var json = JObject.Parse(MOVIE_LIMIT_TEN_RESPONSE);
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

        private const string MOVIE_LIMIT_TEN_RESPONSE = @"{
    'status': 'ok',
    'status_message': 'Query was successful',
    'data': {
        'movie_count': 31051,
        'limit': 10,
        'page_number': 1,
        'movies': [
            {
                'id': 31663,
                'url': 'https://yts.mx/movies/these-days-2016',
                'imdb_code': 'tt5784568',
                'title': 'These Days',
                'title_english': 'These Days',
                'title_long': 'These Days (2016)',
                'slug': 'these-days-2016',
                'year': 2016,
                'rating': 6.3,
                'runtime': 120,
                'genres': [
                    'Drama'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'en',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/these_days_2016/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/these_days_2016/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/these_days_2016/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/these_days_2016/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/these_days_2016/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/21D9403D584A5FA882782C2345B67BD5B840C214',
                        'hash': '21D9403D584A5FA882782C2345B67BD5B840C214',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 106,
                        'peers': 22,
                        'size': '1.06 GB',
                        'size_bytes': 1138166333,
                        'date_uploaded': '2021-05-13 21:03:31',
                        'date_uploaded_unix': 1620932611
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/41EAA079354AA52597DC4A9071890071CDCBF870',
                        'hash': '41EAA079354AA52597DC4A9071890071CDCBF870',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 97,
                        'peers': 22,
                        'size': '2.18 GB',
                        'size_bytes': 2340757176,
                        'date_uploaded': '2021-05-13 22:12:35',
                        'date_uploaded_unix': 1620936755
                    }
                ],
                'date_uploaded': '2021-05-13 21:03:31',
                'date_uploaded_unix': 1620932611
            },
            {
                'id': 31660,
                'url': 'https://yts.mx/movies/the-kings-case-note-2017',
                'imdb_code': 'tt6817202',
                'title': 'The Kings Case Note',
                'title_english': 'The Kings Case Note',
                'title_long': 'The Kings Case Note (2017)',
                'slug': 'the-kings-case-note-2017',
                'year': 2017,
                'rating': 6.4,
                'runtime': 114,
                'genres': [
                    'Comedy',
                    'Mystery'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': 'zWDKP-tOXJE',
                'language': 'ko',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/the_kings_case_note_2017/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/the_kings_case_note_2017/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/the_kings_case_note_2017/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/the_kings_case_note_2017/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/the_kings_case_note_2017/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/42CDBDCFB7D5C9793C3162A29463BE9B756A52F0',
                        'hash': '42CDBDCFB7D5C9793C3162A29463BE9B756A52F0',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.02 GB',
                        'size_bytes': 1095216660,
                        'date_uploaded': '2021-05-13 22:48:33',
                        'date_uploaded_unix': 1620938913
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/5A36E8F22CBC1364B3619D2195ABB190E5A26323',
                        'hash': '5A36E8F22CBC1364B3619D2195ABB190E5A26323',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.9 GB',
                        'size_bytes': 2040109466,
                        'date_uploaded': '2021-05-13 23:52:17',
                        'date_uploaded_unix': 1620942737
                    }
                ],
                'date_uploaded': '2021-05-13 22:48:33',
                'date_uploaded_unix': 1620938913
            },
            {
                'id': 31661,
                'url': 'https://yts.mx/movies/the-priest-who-knocked-out-1943',
                'imdb_code': 'tt0036280',
                'title': 'The Priest Who Knocked Out',
                'title_english': 'The Priest Who Knocked Out',
                'title_long': 'The Priest Who Knocked Out (1943)',
                'slug': 'the-priest-who-knocked-out-1943',
                'year': 1943,
                'rating': 4.5,
                'runtime': 86,
                'genres': [
                    'Comedy',
                    'Drama',
                    'Sport'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'sv',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/the_priest_who_knocked_out_1943/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/the_priest_who_knocked_out_1943/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/the_priest_who_knocked_out_1943/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/the_priest_who_knocked_out_1943/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/the_priest_who_knocked_out_1943/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/9C7A6D36EC75AB096FD17DF1E22A67778F5F871B',
                        'hash': '9C7A6D36EC75AB096FD17DF1E22A67778F5F871B',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '788.85 MB',
                        'size_bytes': 827169178,
                        'date_uploaded': '2021-05-13 21:20:33',
                        'date_uploaded_unix': 1620933633
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/30589FE6E1DBA7E07A014CC2521F9DFE65509447',
                        'hash': '30589FE6E1DBA7E07A014CC2521F9DFE65509447',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.43 GB',
                        'size_bytes': 1535450808,
                        'date_uploaded': '2021-05-13 22:16:45',
                        'date_uploaded_unix': 1620937005
                    }
                ],
                'date_uploaded': '2021-05-13 21:20:33',
                'date_uploaded_unix': 1620933633
            },
            {
                'id': 31659,
                'url': 'https://yts.mx/movies/when-today-ends-2021',
                'imdb_code': 'tt5246704',
                'title': 'When Today Ends',
                'title_english': 'When Today Ends',
                'title_long': 'When Today Ends (2021)',
                'slug': 'when-today-ends-2021',
                'year': 2021,
                'rating': 0,
                'runtime': 97,
                'genres': [
                    'Drama'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': '',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/when_today_ends_2021/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/when_today_ends_2021/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/when_today_ends_2021/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/when_today_ends_2021/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/when_today_ends_2021/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/37E72C7A700504933E436958326BEEB8B6B3CF54',
                        'hash': '37E72C7A700504933E436958326BEEB8B6B3CF54',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '895.04 MB',
                        'size_bytes': 938517463,
                        'date_uploaded': '2021-05-13 23:49:00',
                        'date_uploaded_unix': 1620942540
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/5852299CAFB422D4310F7564D6F2B135ECAE7D94',
                        'hash': '5852299CAFB422D4310F7564D6F2B135ECAE7D94',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.79 GB',
                        'size_bytes': 1921997865,
                        'date_uploaded': '2021-05-14 02:03:39',
                        'date_uploaded_unix': 1620950619
                    }
                ],
                'date_uploaded': '2021-05-13 23:49:00',
                'date_uploaded_unix': 1620942540
            },
            {
                'id': 31658,
                'url': 'https://yts.mx/movies/great-white-2021',
                'imdb_code': 'tt8435002',
                'title': 'Great White',
                'title_english': 'Great White',
                'title_long': 'Great White (2021)',
                'slug': 'great-white-2021',
                'year': 2021,
                'rating': 4.8,
                'runtime': 91,
                'genres': [
                    'Horror',
                    'Thriller'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '_yNmismaJkY',
                'language': 'en',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/great_white_2021/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/great_white_2021/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/great_white_2021/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/great_white_2021/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/great_white_2021/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/3A8B5CE7E5D34277256B3BC18083423601004746',
                        'hash': '3A8B5CE7E5D34277256B3BC18083423601004746',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 1345,
                        'peers': 903,
                        'size': '835.84 MB',
                        'size_bytes': 876441764,
                        'date_uploaded': '2021-05-13 20:11:01',
                        'date_uploaded_unix': 1620929461
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/E50E16F86E1280AB1BDABC2EAF477A5E75E2F07E',
                        'hash': 'E50E16F86E1280AB1BDABC2EAF477A5E75E2F07E',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.68 GB',
                        'size_bytes': 1803886264,
                        'date_uploaded': '2021-05-13 22:06:25',
                        'date_uploaded_unix': 1620936385
                    }
                ],
                'date_uploaded': '2021-05-13 20:11:01',
                'date_uploaded_unix': 1620929461
            },
            {
                'id': 31657,
                'url': 'https://yts.mx/movies/being-a-human-person-2020',
                'imdb_code': 'tt9308410',
                'title': 'Being a Human Person',
                'title_english': 'Being a Human Person',
                'title_long': 'Being a Human Person (2020)',
                'slug': 'being-a-human-person-2020',
                'year': 2020,
                'rating': 7.5,
                'runtime': 90,
                'genres': [
                    'Documentary'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'en',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/being_a_human_person_2020/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/being_a_human_person_2020/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/being_a_human_person_2020/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/being_a_human_person_2020/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/being_a_human_person_2020/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/8E9345273F64241A8E261C6C47C5D544734F3E6D',
                        'hash': '8E9345273F64241A8E261C6C47C5D544734F3E6D',
                        'quality': '720p',
                        'type': 'bluray',
                        'seeds': 0,
                        'peers': 0,
                        'size': '879.11 MB',
                        'size_bytes': 921813647,
                        'date_uploaded': '2021-05-13 16:49:16',
                        'date_uploaded_unix': 1620917356
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/92F5603E94F70D2A6A9A00E421EDCC5FF8724B40',
                        'hash': '92F5603E94F70D2A6A9A00E421EDCC5FF8724B40',
                        'quality': '1080p',
                        'type': 'bluray',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.59 GB',
                        'size_bytes': 1707249500,
                        'date_uploaded': '2021-05-13 19:09:30',
                        'date_uploaded_unix': 1620925770
                    }
                ],
                'date_uploaded': '2021-05-13 16:49:16',
                'date_uploaded_unix': 1620917356
            },
            {
                'id': 31656,
                'url': 'https://yts.mx/movies/unbridled-2017',
                'imdb_code': 'tt5498056',
                'title': 'Unbridled',
                'title_english': 'Unbridled',
                'title_long': 'Unbridled (2017)',
                'slug': 'unbridled-2017',
                'year': 2017,
                'rating': 6.9,
                'runtime': 115,
                'genres': [
                    'Drama'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'en',
                'mpa_rating': 'PG-13',
                'background_image': 'https://yts.mx/assets/images/movies/unbridled_2017/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/unbridled_2017/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/unbridled_2017/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/unbridled_2017/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/unbridled_2017/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/3A710DEA60C90651E529586B6E2D9BE2F5B7F779',
                        'hash': '3A710DEA60C90651E529586B6E2D9BE2F5B7F779',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 76,
                        'peers': 16,
                        'size': '1.01 GB',
                        'size_bytes': 1084479242,
                        'date_uploaded': '2021-05-13 12:05:02',
                        'date_uploaded_unix': 1620900302
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/78BBE8D125576EF699E5C0600BCDCA05E5B37282',
                        'hash': '78BBE8D125576EF699E5C0600BCDCA05E5B37282',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.88 GB',
                        'size_bytes': 2018634629,
                        'date_uploaded': '2021-05-13 13:21:37',
                        'date_uploaded_unix': 1620904897
                    }
                ],
                'date_uploaded': '2021-05-13 12:05:02',
                'date_uploaded_unix': 1620900302
            },
            {
                'id': 31655,
                'url': 'https://yts.mx/movies/the-mark-of-the-angels-miserere-2013',
                'imdb_code': 'tt2354215',
                'title': 'The Mark of the Angels - Miserere',
                'title_english': 'The Mark of the Angels - Miserere',
                'title_long': 'The Mark of the Angels - Miserere (2013)',
                'slug': 'the-mark-of-the-angels-miserere-2013',
                'year': 2013,
                'rating': 5.7,
                'runtime': 106,
                'genres': [
                    'Thriller'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'fr',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/the_mark_of_the_angels_miserere_2013/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/the_mark_of_the_angels_miserere_2013/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/the_mark_of_the_angels_miserere_2013/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/the_mark_of_the_angels_miserere_2013/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/the_mark_of_the_angels_miserere_2013/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/3BB771E1AC824A8C7CDC981E48D2CB3121FA4EF6',
                        'hash': '3BB771E1AC824A8C7CDC981E48D2CB3121FA4EF6',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 75,
                        'peers': 39,
                        'size': '968.57 MB',
                        'size_bytes': 1015619256,
                        'date_uploaded': '2021-05-13 11:46:56',
                        'date_uploaded_unix': 1620899216
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/A9676DDE93F5324B584B084793063B402D40378C',
                        'hash': 'A9676DDE93F5324B584B084793063B402D40378C',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.94 GB',
                        'size_bytes': 2083059139,
                        'date_uploaded': '2021-05-13 12:48:27',
                        'date_uploaded_unix': 1620902907
                    }
                ],
                'date_uploaded': '2021-05-13 11:46:56',
                'date_uploaded_unix': 1620899216
            },
            {
                'id': 31652,
                'url': 'https://yts.mx/movies/holbein-eye-of-the-tudors-2015',
                'imdb_code': 'tt5657380',
                'title': 'Holbein: Eye of the Tudors',
                'title_english': 'Holbein: Eye of the Tudors',
                'title_long': 'Holbein: Eye of the Tudors (2015)',
                'slug': 'holbein-eye-of-the-tudors-2015',
                'year': 2015,
                'rating': 7.6,
                'runtime': 0,
                'genres': [
                    'Documentary'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'en',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/holbein_eye_of_the_tudors_2015/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/holbein_eye_of_the_tudors_2015/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/holbein_eye_of_the_tudors_2015/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/holbein_eye_of_the_tudors_2015/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/holbein_eye_of_the_tudors_2015/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/B357B414DB745DC4A46EE002A6FD91B448BF761A',
                        'hash': 'B357B414DB745DC4A46EE002A6FD91B448BF761A',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '553.7 MB',
                        'size_bytes': 580596531,
                        'date_uploaded': '2021-05-13 11:36:14',
                        'date_uploaded_unix': 1620898574
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/960719535F6550CC5511AE4BD580D91D5F6F76B8',
                        'hash': '960719535F6550CC5511AE4BD580D91D5F6F76B8',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1 GB',
                        'size_bytes': 1073741824,
                        'date_uploaded': '2021-05-13 12:19:33',
                        'date_uploaded_unix': 1620901173
                    }
                ],
                'date_uploaded': '2021-05-13 11:36:14',
                'date_uploaded_unix': 1620898574
            },
            {
                'id': 31653,
                'url': 'https://yts.mx/movies/the-50-best-horror-movies-youve-never-seen-2014',
                'imdb_code': 'tt1671746',
                'title': 'The 50 Best Horror Movies You have Never Seen',
                'title_english': 'The 50 Best Horror Movies You have Never Seen',
                'title_long': 'The 50 Best Horror Movies You have Never Seen (2014)',
                'slug': 'the-50-best-horror-movies-youve-never-seen-2014',
                'year': 2014,
                'rating': 6.1,
                'runtime': 139,
                'genres': [
                    'Horror'
                ],
                'summary': 'Lorem Ipsum',
                'description_full': 'Lorem Ipsum',
                'synopsis': 'Lorem Ipsum',
                'yt_trailer_code': '',
                'language': 'en',
                'mpa_rating': '',
                'background_image': 'https://yts.mx/assets/images/movies/the_50_best_horror_movies_youve_never_seen_2014/background.jpg',
                'background_image_original': 'https://yts.mx/assets/images/movies/the_50_best_horror_movies_youve_never_seen_2014/background.jpg',
                'small_cover_image': 'https://yts.mx/assets/images/movies/the_50_best_horror_movies_youve_never_seen_2014/small-cover.jpg',
                'medium_cover_image': 'https://yts.mx/assets/images/movies/the_50_best_horror_movies_youve_never_seen_2014/medium-cover.jpg',
                'large_cover_image': 'https://yts.mx/assets/images/movies/the_50_best_horror_movies_youve_never_seen_2014/large-cover.jpg',
                'state': 'ok',
                'torrents': [
                    {
                        'url': 'https://yts.mx/torrent/download/DCC943D944AE5B4DF5B720FCCBAB6C3A544BD4A4',
                        'hash': 'DCC943D944AE5B4DF5B720FCCBAB6C3A544BD4A4',
                        'quality': '720p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '1.26 GB',
                        'size_bytes': 1352914698,
                        'date_uploaded': '2021-05-13 12:46:27',
                        'date_uploaded_unix': 1620902787
                    },
                    {
                        'url': 'https://yts.mx/torrent/download/44EDD502B18C6F86FEACCB26A49ECD84FDA949F7',
                        'hash': '44EDD502B18C6F86FEACCB26A49ECD84FDA949F7',
                        'quality': '1080p',
                        'type': 'web',
                        'seeds': 0,
                        'peers': 0,
                        'size': '2.33 GB',
                        'size_bytes': 2501818450,
                        'date_uploaded': '2021-05-13 14:20:38',
                        'date_uploaded_unix': 1620908438
                    }
                ],
                'date_uploaded': '2021-05-13 12:46:27',
                'date_uploaded_unix': 1620902787
            }
        ]
    },
    '@meta': {
        'server_time': 1620958991,
        'server_timezone': 'CET',
        'api_version': 2,
        'execution_time': '0.01 ms'
    }
}";

    }
}