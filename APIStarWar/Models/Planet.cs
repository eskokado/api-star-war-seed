namespace APIStarWar.Models
{

    public class Planet : StarWarBase
    {
        public int PlanetId { get; set; }
        public string RotationPeriod { get; set; }
        public string Diameter { get; set; }
        public string Terrain { get; set; }
        public string OrbitalPeriod { get; set; }
        //public IEnumerable<string> Residents { get; set; }
        public string Name { get; set; }
        public string SurfaceWater { get; set; }
        public string Gravity { get; set; }
        //public IEnumerable<string> Films { get; set; }
        //public virtual ICollection<Film> films { get; set; }
        public string Population { get; set; }
        public string Climate { get; set; }
    }
}