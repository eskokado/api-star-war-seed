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
    public class SpecieController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<ApplicationDbContext> _logger;

        public SpecieController(ILogger<ApplicationDbContext> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Specie>> GetSpecies()
        {
            return _context.Species;
        }

        [HttpPost]
        public IActionResult AddSpecie([FromBody] SpecieDto obj)
        {
            if (obj == null)
                return BadRequest();
            var objCreate = new Models.Specie
            {
                Id = Guid.NewGuid(),
                SpecieId = -1,
                Classification = obj.Classification,
                EyeColors = obj.EyeColors,
                HairColors = obj.HairColors,
                Designation = obj.Designation,
                Name = obj.Name,
                SkinColors = obj.SkinColors,
                Homeworld = obj.Homeworld,
                AverageHeight = obj.AverageHeight,
                AverageLifespan = obj.AverageLifespan,
                Language = obj.Language,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            _context.Species.Add(objCreate);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetSpecieById), new { id = objCreate.Id }, objCreate);
        }

        [HttpGet("{id}", Name = nameof(GetSpecieById))]
        public ActionResult GetSpecieById(Guid id)
        {
            var obj = _context.Species.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();


            return Ok(obj);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdateSpecieById(Guid id, [FromBody] SpecieDto obj)
        {
            if (obj == null)
                return BadRequest();

            var objUpdate = _context.Species.FirstOrDefault(i => i.Id == id);
            if (objUpdate == null)
                return NotFound();

            objUpdate.SpecieId = objUpdate.SpecieId;
            objUpdate.Classification = obj.Classification;
            objUpdate.EyeColors = obj.EyeColors;
            objUpdate.HairColors = obj.HairColors;
            objUpdate.Designation = obj.Designation;
            objUpdate.Name = obj.Name;
            objUpdate.SkinColors = obj.SkinColors;
            objUpdate.Homeworld = obj.Homeworld;
            objUpdate.AverageHeight = obj.AverageHeight;
            objUpdate.AverageLifespan = obj.AverageLifespan;
            objUpdate.Language = obj.Language;
            objUpdate.Created = objUpdate.Created;
            objUpdate.Edited = DateTime.UtcNow;

            _context.Species.Update(objUpdate);
            _context.SaveChanges();
            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSpecieById(Guid id)
        {
            var obj = _context.Species.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();

            _context.Species.Remove(obj);
            _context.SaveChanges();
            return new NoContentResult();
        }

    }
}
