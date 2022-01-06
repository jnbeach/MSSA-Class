namespace MovieApp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? MovieName { get; set; }
        public int? ReleaseYear { get; set; }
        public string? Genre { get; set; }
        public DateTime ShowTime { get; set; }
        public string? ImagePath { get; set; }

    }
}
