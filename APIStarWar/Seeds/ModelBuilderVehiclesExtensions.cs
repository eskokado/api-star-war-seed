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
    public static class ModelBuilderVehiclesExtensions
    {

        public static void SeedVehicles(this ModelBuilder modelBuilder)
        {
            Repository<StarWarsApiCSharp.Vehicle> repository = new();
            var fromList = repository.GetEntities().ToList();
            for (int i = 0; i < fromList.Count; i++)
            {
                modelBuilder.Entity<Models.Vehicle>().HasData(new Models.Vehicle
                {
                    Id = Guid.NewGuid(),
                    VehicleId = ModelBuilderPeoplesExtensions.GetId(fromList[i].Url),
                    VehicleClass = fromList[i].VehicleClass,
                    CostInCredits = fromList[i].CostInCredits,
                    MaxAtmospheringSpeed = fromList[i].MaxAtmospheringSpeed,
                    Crew = fromList[i].Crew,
                    Model = fromList[i].Model,
                    CargoCapacity = fromList[i].CargoCapacity,
                    Name = fromList[i].Name,
                    Length = fromList[i].Length,
                    Manufacturer = fromList[i].Manufacturer,
                    Consumables = fromList[i].Consumables,
                    Passengers = fromList[i].Passengers,
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
