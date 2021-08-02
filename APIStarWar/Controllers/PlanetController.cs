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
    public class PlanetController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<ApplicationDbContext> _logger;

        public PlanetController(ILogger<ApplicationDbContext> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Planet>> GetPlanets()
        {
            return _context.Planets;
        }

        [HttpPost]
        public IActionResult AddPlanet([FromBody] PlanetDto obj)
        {
            if (obj == null)
                return BadRequest();
            var objCreate = new Models.Planet
            {
                Id = Guid.NewGuid(),
                PlanetId = -1,
                RotationPeriod = obj.RotationPeriod,
                Diameter = obj.Diameter,
                Terrain = obj.Terrain,
                OrbitalPeriod = obj.OrbitalPeriod,
                Name = obj.Name,
                SurfaceWater = obj.SurfaceWater,
                Gravity = obj.Gravity,
                Population = obj.Population,
                Climate = obj.Climate,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            _context.Planets.Add(objCreate);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetPlanetById), new { id = objCreate.Id }, objCreate);
        }

        [HttpGet("{id}", Name = nameof(GetPlanetById))]
        public ActionResult GetPlanetById(Guid id)
        {
            var obj = _context.Planets.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();


            return Ok(obj);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdatePlanetById(Guid id, [FromBody] PlanetDto obj)
        {
            if (obj == null)
                return BadRequest();

            var objUpdate = _context.Planets.FirstOrDefault(i => i.Id == id);
            if (objUpdate == null)
                return NotFound();

            objUpdate.PlanetId = objUpdate.PlanetId;
            objUpdate.RotationPeriod = obj.RotationPeriod;
            objUpdate.Diameter = obj.Diameter;
            objUpdate.Terrain = obj.Terrain;
            objUpdate.OrbitalPeriod = obj.OrbitalPeriod;
            objUpdate.Name = obj.Name;
            objUpdate.SurfaceWater = obj.SurfaceWater;
            objUpdate.Gravity = obj.Gravity;
            objUpdate.Population = obj.Population;
            objUpdate.Climate = obj.Climate;
            objUpdate.Created = objUpdate.Created;
            objUpdate.Edited = DateTime.UtcNow;

            _context.Planets.Update(objUpdate);
            _context.SaveChanges();
            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePlanetById(Guid id)
        {
            var obj = _context.Planets.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();

            _context.Planets.Remove(obj);
            _context.SaveChanges();
            return new NoContentResult();
        }

    }
}
