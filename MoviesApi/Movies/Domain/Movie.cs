using Newtonsoft.Json;
using MoviesApi.Configuration;

namespace MoviesApi.Movies.Domain
{
    public class Movie
    {
        public Movie(int id, string url, string title, int year, string summary, string[] genres, string description, string synopsis, string youtubeTrailerCode, string backgroundImage, string mediumCoverImage, int runtime, double rating)
        {
            this.id = id;
            this.url = url;
            this.title = title;
            this.year = year;
            this.summary = summary;
            this.genres = genres;
            this.description = description;
            this.synopsis = synopsis;
            this.youtubeTrailerCode = youtubeTrailerCode;
            this.backgroundImage = backgroundImage;
            this.mediumCoverImage = mediumCoverImage;
            this.runtime = runtime;
            this.rating = rating;
        }
        [JsonProperty("id")]
        private int id;
        public int Id
        {
            get { return id; }
        }
        [JsonProperty("url")]
        private string url;
        public string Url
        {
            get { return url; }
        }
        [JsonProperty("title_english")]
        private string title;
        public string Title
        {
            get { return title; }
        }
        [JsonProperty("year")]
        private int year;
        public int Year
        {
            get { return year; }
        }
        [JsonProperty("summary")]
        private string summary;
        public string Summary
        {
            get { return summary; }
        }

        [JsonProperty("genres")]
        private string[] genres;
        public string[] Genres
        {
            get { return genres; }
        }
        [JsonProperty("description_full")]
        private string description;
        public string Description
        {
            get { return description; }
        }
        [JsonProperty("synopsis")]
        private string synopsis;
        public string Synopsis
        {
            get { return synopsis; }
        }
        
        [JsonProperty("yt_trailer_code")]
        private string youtubeTrailerCode;
        public string YoutubeTrailerCode
        {
            get { return $"{Constants.BASE_SHORT_YOUTUBE_URL}{youtubeTrailerCode}"; }
        }
        [JsonProperty("background_image")]
        private string backgroundImage;
        public string BackgroundImage
        {
            get { return backgroundImage; }
        }
        [JsonProperty("medium_cover_image")]
        private string mediumCoverImage;
        public string MediumCoverImage
        {
            get { return mediumCoverImage; }
        }
        [JsonProperty("runtime")]
        private int runtime;
        public int Runtime
        {
            get { return runtime; }
        }
        [JsonProperty("rating")]
        private double rating;
        public double Rating
        {
            get { return rating; }
        }
    }
}