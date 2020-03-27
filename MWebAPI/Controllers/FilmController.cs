using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MData.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MServices;

namespace MWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilm _Film;

        public FilmController(IFilm Film)
        {
            _Film = Film;
        }

        [HttpPost]
        public async Task<IActionResult> Save([FromBody] Film _film)
        {
            if(_film == null)
            {
                return BadRequest();
            }
            POJO model = await _Film.Save(_film);
            if(model == null)
            {
                return NotFound();
            }
            return Ok(_film);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetFilm(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }
            Film data = await _Film.GetFilm(Id);
            if(data == null)
            {
                return NotFound();
            }
            return Ok(data);
        }

        [HttpGet]
        public IActionResult GetFilms()
        {
            IQueryable<Film> data = _Film.GetFilms;
            return Ok(data);
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteFilm(int? Id)
        {
            if (Id == null)
            {
                return BadRequest();
            }
            POJO model = await _Film.DeleteAsync(Id);
            if(model == null)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}