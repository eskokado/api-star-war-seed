using APIStarWar.Dto;
using APIStarWar.InMemory;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace APIStarWar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehicleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<ApplicationDbContext> _logger;

        public VehicleController(ILogger<ApplicationDbContext> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Vehicle>> GetVehicles()
        {
            return _context.Vehicles;
        }

        [HttpPost]
        public IActionResult AddVehicle([FromBody] VehicleDto obj)
        {
            if (obj == null)
                return BadRequest();
            var objCreate = new Models.Vehicle
            {
                Id = Guid.NewGuid(),
                VehicleId = -1,
                VehicleClass = obj.VehicleClass,
                CostInCredits = obj.CostInCredits,
                MaxAtmospheringSpeed = obj.MaxAtmospheringSpeed,
                Crew = obj.Crew,
                Model = obj.Model,
                CargoCapacity = obj.CargoCapacity,
                Name = obj.Name,
                Length = obj.Length,
                Manufacturer = obj.Manufacturer,
                Consumables = obj.Consumables,
                Passengers = obj.Passengers,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            _context.Vehicles.Add(objCreate);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetVehicleById), new { id = objCreate.Id }, objCreate);
        }

        [HttpGet("{id}", Name = nameof(GetVehicleById))]
        public ActionResult GetVehicleById(Guid id)
        {
            var obj = _context.Vehicles.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();


            return Ok(obj);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdateVehicleById(Guid id, [FromBody] VehicleDto obj)
        {
            if (obj == null)
                return BadRequest();

            var objUpdate = _context.Vehicles.FirstOrDefault(i => i.Id == id);
            if (objUpdate == null)
                return NotFound();

            objUpdate.VehicleId = objUpdate.VehicleId;
            objUpdate.VehicleClass = obj.VehicleClass;
            objUpdate.CostInCredits = obj.CostInCredits;
            objUpdate.MaxAtmospheringSpeed = obj.MaxAtmospheringSpeed;
            objUpdate.Crew = obj.Crew;
            objUpdate.Model = obj.Model;
            objUpdate.CargoCapacity = obj.CargoCapacity;
            objUpdate.Name = obj.Name;
            objUpdate.Length = obj.Length;
            objUpdate.Manufacturer = obj.Manufacturer;
            objUpdate.Consumables = obj.Consumables;
            objUpdate.Passengers = obj.Passengers;
            objUpdate.Created = objUpdate.Created;
            objUpdate.Edited = DateTime.UtcNow;

            _context.Vehicles.Update(objUpdate);
            _context.SaveChanges();
            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteVehicleById(Guid id)
        {
            var obj = _context.Vehicles.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();

            _context.Vehicles.Remove(obj);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
