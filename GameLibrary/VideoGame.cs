using System;
namespace GameLibrary
{
    public class VideoGame
    {
        public string Name { get; set; }
        public String Platform { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public VideoGame(string name, string platform, DateTime releaseDate, string genre)
        {
            Name = name;
            Platform = platform;
            ReleaseDate = releaseDate;
            Genre = genre;
        }
        public override string ToString()
        {
            return $"{Name} - {Platform} - {ReleaseDate.ToShortDateString()} - {Genre}";
        }
    }
}
