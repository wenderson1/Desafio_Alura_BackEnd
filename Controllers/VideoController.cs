using Desafio_Dev_Alura_BackEnd.Data;
using Desafio_Dev_Alura_BackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio_Dev_Alura_BackEnd.Controllers
{
    [ApiController]
    [Route("api/videos")]
    public class VideoController : Controller
    {


        [HttpGet]
        public async Task<ActionResult<List<Video>>> Get([FromServices] DataContext context)
        {
            var videos = await context.Videos.Where(v => v.Active == true).ToListAsync();
            return Ok(videos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromServices] DataContext context, int id)
        {
            var video = context.Videos.Where(v => v.Active == true).SingleOrDefault(v => v.Id == id);
            if (video == null)
                return NotFound("Vídeo não encontrado");

            return Ok(video);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromServices] DataContext context, [FromBody] Video video)
        {
            context.Videos.Add(video);
            context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = video.Id }, video);
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromServices] DataContext context, int id, [FromBody] Video videoUpdate)
        {
            var video = context.Videos.SingleOrDefault(v => v.Id == id);

            if (video == null)
                return NotFound();

            context.Update(videoUpdate);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete([FromServices] DataContext context, int id)
        {

            var video = context.Videos.SingleOrDefault(v => v.Id == id);
            if (video == null)
                return NotFound();

            video.Deactive();
            return Ok("Deletado");
        }

    }
}
