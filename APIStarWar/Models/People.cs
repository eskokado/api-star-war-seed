namespace APIStarWar.Models
{

    public class People : StarWarBase
    {
        public int PeopleId { get; set; }
        public string Gender { get; set; }
        //public IEnumerable<string> Starships { get; set; }
        public string Height { get; set; }
        public string EyeColor { get; set; }
        //public IEnumerable<string> Vehicles { get; set; }
        public string HairColor { get; set; }
        public string Mass { get; set; }
        //public IEnumerable<string> Species { get; set; }
        public string Name { get; set; }
        public string SkinColor { get; set; }
        //public IEnumerable<string> Films { get; set; }
        //public virtual ICollection<Film> films { get; set; }
        public string Homeworld { get; set; }
        public string BirthYear { get; set; }      
    }
}