
namespace MoviesApi.Movies.Domain
{
    class Movies
    {
        public Movies(int id, string url, string title, int year, string summary, string[] genres, string description, string youtubeTrailerCode, string backgroundImage, string mediumCoverImage, int runtime, double rating)
        {
            this.id = id;
            this.url = url;
            this.title = title;
            this.year = year;
            this.summary = summary;
            this.genres = genres;
            this.description = description;
            this.youtubeTrailerCode = youtubeTrailerCode;
            this.backgroundImage = backgroundImage;
            this.mediumCoverImage = mediumCoverImage;
            this.runtime = runtime;
            this.rating = rating;
        }
        private int id;
        public int Id
        {
            get { return id; }
        }

        private string url;
        public string Url
        {
            get { return url; }
        }

        private string title;
        public string Title
        {
            get { return title; }
        }

        private int year;
        public int Year
        {
            get { return year; }
        }

        private string summary;
        public string Summary
        {
            get { return summary; }
        }

        private string[] genres;
        public string[] Genres
        {
            get { return genres; }
        }

        private string description;
        public string Description
        {
            get { return description; }
        }

        private string youtubeTrailerCode;
        public string YoutubeTrailerCode
        {
            get { return youtubeTrailerCode; }
        }

        private string backgroundImage;
        public string BackgroundImage
        {
            get { return backgroundImage; }
        }

        private string mediumCoverImage;
        public string MediumCoverImage
        {
            get { return mediumCoverImage; }
        }

        private int runtime;
        public int Runtime
        {
            get { return runtime; }
        }

        private double rating;
        public double Rating
        {
            get { return rating; }
        }







    }
}