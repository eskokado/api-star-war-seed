namespace APIStarWar.Models
{

    public class Film : StarWarBase
    {
        public int FilmId { get; set; }
        public string Producer { get; set; }
        public int EpisodeId { get; set; }
//        public IEnumerable<string> Starships { get; set; }
//        public IEnumerable<string> Species { get; set; }
        public string OpeningCrawl { get; set; }
//        public IEnumerable<string> Vehicles { get; set; }
//        public IEnumerable<string> Planets { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
//        public IEnumerable<string> Characters { get; set; }

        public Film()
        {

        }

    }
}