using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Kurs_24_Core2_RP.Models;

namespace Kurs_24_Core2_RP.Pages.Movies
{
    public class DetailsModel : PageModel
    {
        private readonly Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext _context;

        public DetailsModel(Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext context)
        {
            _context = context;
        }

        public Movie Movie { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Movie = await _context.Movie.FirstOrDefaultAsync(m => m.ID == id);

            if (Movie == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
