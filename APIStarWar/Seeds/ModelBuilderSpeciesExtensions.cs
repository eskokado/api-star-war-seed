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
    public static class ModelBuilderSpeciesExtensions
    {

        public static void SeedSpecies(this ModelBuilder modelBuilder)
        {
            Repository<StarWarsApiCSharp.Specie> repository = new();
            var fromList = repository.GetEntities().ToList();
            for (int i = 0; i < fromList.Count; i++)
            {
                modelBuilder.Entity<Models.Specie>().HasData(new Models.Specie
                {
                    Id = Guid.NewGuid(),
                    SpecieId = ModelBuilderPeoplesExtensions.GetId(fromList[i].Url),
                    EyeColors = fromList[i].EyeColors,
                    HairColors = fromList[i].HairColors,
                    Designation = fromList[i].Designation,
                    Name = fromList[i].Name,
                    SkinColors = fromList[i].SkinColors,
                    Homeworld = fromList[i].Homeworld,
                    AverageHeight = fromList[i].AverageHeight,
                    AverageLifespan = fromList[i].AverageLifespan,
                    Language = fromList[i].Language,
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
