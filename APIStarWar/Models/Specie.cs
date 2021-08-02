namespace APIStarWar.Models
{
    public class Specie : StarWarBase
    {
        public int SpecieId { get; set; }
        public string Classification { get; set; }
        public string EyeColors { get; set; }
        public string HairColors { get; set; }
        //public IEnumerable<string> Films { get; set; }
        //public virtual ICollection<Film> films { get; set; }
        public string Designation { get; set; }
        public string Name { get; set; }
        public string SkinColors { get; set; }
        public string Homeworld { get; set; }
        public string AverageLifespan { get; set; }
        public string AverageHeight { get; set; }
        public string Language { get; set; }
        //public IEnumerable<string> People { get; set; }
        //public virtual ICollection<People> peoples { get; set; }

    }

}