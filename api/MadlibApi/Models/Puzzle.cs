using System.Collections.Generic;
using System.Linq;

namespace MadlibApi.Models
{
    public class Puzzle
    {
        public long Id  { get; set; }
        public IEnumerable<PuzzleSection> Sections { get; set; }
    }
}
