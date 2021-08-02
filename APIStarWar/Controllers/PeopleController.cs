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
    public class PeopleController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<ApplicationDbContext> _logger;

        public PeopleController(ILogger<ApplicationDbContext> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.People>> GetPeoples()
        {
            return _context.Peoples;
        }

        [HttpPost]
        public IActionResult AddPeople([FromBody] PeopleDto obj)
        {
            if (obj == null)
                return BadRequest();
            var objCreate = new Models.People
            {
                Id = Guid.NewGuid(),
                PeopleId = -1,
                Gender = obj.Gender,
                Height = obj.Height,
                EyeColor = obj.EyeColor,
                HairColor = obj.HairColor,
                Mass = obj.Mass,
                Name = obj.Name,
                SkinColor = obj.SkinColor,
                Homeworld = obj.Homeworld,
                BirthYear = obj.BirthYear,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            _context.Peoples.Add(objCreate);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetPeopleById), new { id = objCreate.Id }, objCreate);
        }

        [HttpGet("{id}", Name = nameof(GetPeopleById))]
        public ActionResult GetPeopleById(Guid id)
        {
            var obj = _context.Peoples.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();


            return Ok(obj);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdatePeopleById(Guid id, [FromBody] PeopleDto obj)
        {
            if (obj == null)
                return BadRequest();

            var objUpdate = _context.Peoples.FirstOrDefault(i => i.Id == id);
            if (objUpdate == null)
                return NotFound();

            objUpdate.PeopleId = objUpdate.PeopleId;
            objUpdate.Gender = obj.Gender;
            objUpdate.Height = obj.Height;
            objUpdate.EyeColor = obj.EyeColor;
            objUpdate.HairColor = obj.HairColor;
            objUpdate.Mass = obj.Mass;
            objUpdate.Name = obj.Name;
            objUpdate.SkinColor = obj.SkinColor;
            objUpdate.Homeworld = obj.Homeworld;
            objUpdate.BirthYear = obj.BirthYear;
            objUpdate.Created = objUpdate.Created;
            objUpdate.Edited = DateTime.UtcNow;

            _context.Peoples.Update(objUpdate);
            _context.SaveChanges();
            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePeopleById(Guid id)
        {
            var obj = _context.Peoples.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();

            _context.Peoples.Remove(obj);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
