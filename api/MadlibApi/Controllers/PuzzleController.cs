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
        public async Task<ActionResult<Puzzle>> PostTodoItem(Puzzle puzzle)
        {
            _context.Puzzles.Add(puzzle);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPuzzles), new { id = puzzle.Id }, puzzle);
        }
    }
}