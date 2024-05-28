using BlazorWebAssemblyCrud.Shared.Entities;
using BlazorWebAssemblyDotNetCrud.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAssemblyDotNetCrud.Controllers
{
    [Route("api/videogames")]
    [ApiController]
    public class VideoGamesController : ControllerBase
    {
        private readonly DataContext _context;

        public VideoGamesController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<VideoGame>>> GetAllVideoGamesAsync()
        {
            return await _context.VideoGames.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<VideoGame>> GetGameByIdAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
            if (result == null)
            
                return NotFound("Game not foud");

                return Ok(result);
            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteGameAsync(int id)
        {
            var result = await _context.VideoGames.FindAsync(id);
            if (result == null)

                return NotFound("Game not foud");

            _context.Remove(result);
            await _context.SaveChangesAsync();

            return Ok();

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<VideoGame>> UpdateGameAsync(int id, VideoGame updateGame)
        {
            var DbGame = await _context.VideoGames.FindAsync(id);
            if (DbGame == null)

                return NotFound("Game not foud");

            DbGame.Title = updateGame.Title;
            DbGame.Publisher = updateGame.Publisher;
            DbGame.ReleaseYear = updateGame.ReleaseYear;

            await _context.SaveChangesAsync();

            return Ok(DbGame);

        }

        [HttpPost]
        public async Task<ActionResult<VideoGame>> AddGameAsync(VideoGame newGame)
        {
            _context.Add(newGame);
            await _context.SaveChangesAsync();

            return Ok(newGame);
        }

    }
}
