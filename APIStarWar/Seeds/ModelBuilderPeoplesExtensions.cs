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
    public static class ModelBuilderPeoplesExtensions
    {

        public static void SeedPeoples(this ModelBuilder modelBuilder)
        {
            Repository<StarWarsApiCSharp.Person> repository = new();
            var fromList = repository.GetEntities().ToList();
            for (int i = 0; i < fromList.Count; i++)
            {
                modelBuilder.Entity<Models.People>().HasData(new Models.People
                {
                    Id = Guid.NewGuid(),
                    PeopleId = ModelBuilderPeoplesExtensions.GetId(fromList[i].Url),
                    Gender = fromList[i].Gender,
                    Height = fromList[i].Height,
                    EyeColor = fromList[i].EyeColor,
                    HairColor = fromList[i].HairColor,
                    Mass = fromList[i].Mass,
                    Name = fromList[i].Name,
                    SkinColor = fromList[i].SkinColor,
                    Homeworld = fromList[i].Homeworld,
                    BirthYear = fromList[i].BirthYear,
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
