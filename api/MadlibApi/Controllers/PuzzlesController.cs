using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MadlibApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace MadlibApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PuzzleController : ControllerBase
    {
        private readonly PuzzleContext _context;

        public PuzzleController(PuzzleContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Puzzle>>> GetPuzzles()
        {
            return await _context.Puzzles
                .ToListAsync();
        }
        
        [HttpPost]
        public async Task<ActionResult<Puzzle>> PostPuzzle([FromBody] Puzzle puzzle)
        {
            _context.Puzzles.Add(puzzle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPuzzles), new { id = puzzle.Id }, puzzle);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPuzzle(long id, Puzzle puzzle)
        {
            if (id != puzzle.Id)
            {
                return BadRequest();
            }

            _context.Entry(puzzle).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PuzzleExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        private bool PuzzleExists(long id)
        {
            return _context.Puzzles.Any(e => e.Id == id);
        }
    }
}