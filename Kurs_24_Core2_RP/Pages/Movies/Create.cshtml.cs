using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Kurs_24_Core2_RP.Models;

namespace Kurs_24_Core2_RP.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext _context;

        public CreateModel(Kurs_24_Core2_RP.Models.Kurs_24_Core2_RPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}