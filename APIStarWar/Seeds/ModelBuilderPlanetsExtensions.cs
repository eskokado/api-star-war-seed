using APIStarWar.Controllers;
using APIStarWar.InMemory;
using Microsoft.EntityFrameworkCore;
using StarWarsApiCSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIStarWar.Seeds
{
    public static class ModelBuilderPlanetsExtensions
    {

        public static void SeedPlanets(this ModelBuilder modelBuilder)
        {
            Repository<StarWarsApiCSharp.Planet> repository = new();
            var fromList = repository.GetEntities().ToList();
            for (int i = 0; i < fromList.Count; i++)
            {
                modelBuilder.Entity<Models.Planet>().HasData(new Models.Planet
                {
                    Id = Guid.NewGuid(),
                    PlanetId = ModelBuilderPeoplesExtensions.GetId(fromList[i].Url),
                    RotationPeriod = fromList[i].RotationPeriod,
                    Diameter = fromList[i].Diameter,
                    Terrain = fromList[i].Terrain,
                    OrbitalPeriod = fromList[i].OrbitalPeriod,
                    SurfaceWater = fromList[i].SurfaceWater,
                    Gravity = fromList[i].Gravity,
                    Climate = fromList[i].Climate,
                    Name = fromList[i].Name,
                    Population = fromList[i].Residents.Count.ToString(),
                    Url = fromList[i].Url,
                    Created = fromList[i].Created,
                    Edited = fromList[i].Edited,
                });
            }
        }

        public static int GetId(string url)
        {
            //// filmUrl = https://swapi.dev/api/films/<Id>/

            int secondSlash = url.LastIndexOf("/");
            int firstSlash = url.LastIndexOf("/", secondSlash - 1);
            int lengthOfSubstring = (secondSlash - firstSlash) - 1;
            string stringId = url.Substring(firstSlash + 1, lengthOfSubstring);

            int result = int.Parse(stringId);
            return result;
        }
    }
}
