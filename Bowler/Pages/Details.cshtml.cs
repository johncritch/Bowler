using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bowler.Models;

namespace Bowler.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly Bowler.Models.BowlersDbContext _context;

        public DetailsModel(Bowler.Models.BowlersDbContext context)
        {
            _context = context;
        }

        public Bowlers Bowlers { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Bowlers = await _context.Bowlers
                .Include(b => b.Team).FirstOrDefaultAsync(m => m.BowlerID == id);

            if (Bowlers == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
