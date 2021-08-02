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
    public class FilmController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        private readonly ILogger<ApplicationDbContext> _logger;

        public FilmController(ILogger<ApplicationDbContext> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.Film>> GetFilms()
        {
            return _context.Films;
        }

        [HttpPost]
        public IActionResult AddFilm([FromBody] FilmDto obj)
        {
            if (obj == null)
                return BadRequest();
            var objCreate = new Models.Film
            {
                Id = Guid.NewGuid(),
                Producer = obj.Producer,
                EpisodeId = obj.EpisodeId,
                OpeningCrawl = obj.OpeningCrawl,
                Title = obj.Title,
                Director = obj.Director,
                FilmId = -1,
                Created = DateTime.UtcNow,
                Edited = DateTime.UtcNow
            };

            _context.Films.Add(objCreate);
            _context.SaveChanges();

            return CreatedAtRoute(nameof(GetFilmById), new { id = objCreate.Id }, objCreate);
        }

        [HttpGet("{id}", Name = nameof(GetFilmById))]
        public ActionResult GetFilmById(Guid id)
        {
            var obj = _context.Films.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();


            return Ok(obj);
        }

        [HttpPut("{id}")] // means that this id will come from route  
        public IActionResult UpdateFilmById(Guid id, [FromBody] FilmDto obj)
        {
            if (obj == null)
                return BadRequest();

            var objUpdate = _context.Films.FirstOrDefault(i => i.Id == id);
            if (objUpdate == null)
                return NotFound();

            objUpdate.Producer = obj.Producer;
            objUpdate.EpisodeId = obj.EpisodeId;
            objUpdate.OpeningCrawl = obj.OpeningCrawl;
            objUpdate.Title = obj.Title;
            objUpdate.FilmId = objUpdate.FilmId;
            objUpdate.Director = obj.Director;
            objUpdate.Created = objUpdate.Created;
            objUpdate.Edited = DateTime.UtcNow;

            _context.Films.Update(objUpdate);
            _context.SaveChanges();
            return Ok(objUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFilmById(Guid id)
        {
            var obj = _context.Films.FirstOrDefault(i => i.Id == id);
            if (obj == null)
                return NotFound();

            _context.Films.Remove(obj);
            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
