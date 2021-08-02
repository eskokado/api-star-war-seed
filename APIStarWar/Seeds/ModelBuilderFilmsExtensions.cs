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
    public static class ModelBuilderFilmsExtensions
    {

        public static void SeedFilms(this ModelBuilder modelBuilder)
        {
            Repository<Film> repository = new();
            var fromList = repository.GetEntities().ToList();
            for (int i = 0; i < fromList.Count; i++)
            {
                modelBuilder.Entity<Models.Film>().HasData(new Models.Film
                {
                    Id = Guid.NewGuid(),
                    FilmId = ModelBuilderFilmsExtensions.GetId(fromList[i].Url),
                    Producer = fromList[i].Producer,
                    EpisodeId = int.Parse(fromList[i].EpisodeId),
                    //Starships = fromList[i].Starships,
                    //Species = fromList[i].Species,
                    OpeningCrawl = fromList[i].OpeningCrawl,
                    //Vehicles = fromList[i].Vehicles,
                    //Planets = fromList[i].Planets,
                    Title = fromList[i].Title,
                    Director = fromList[i].Director,
                    //Characters = fromList[i].Characters,
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
