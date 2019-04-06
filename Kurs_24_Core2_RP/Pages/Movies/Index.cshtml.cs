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
    public class IndexModel : PageModel
    {
        private readonly Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext _context;

        public IndexModel(Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
