#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Workshop_RSWEB.Data;
using Workshop_RSWEB.Models;

namespace Workshop_RSWEB.Pages.Predmets
{
    public class DeleteModel : PageModel
    {
        private readonly Workshop_RSWEB.Data.Workshop_RSWEBContext _context;

        public DeleteModel(Workshop_RSWEB.Data.Workshop_RSWEBContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Predmet Predmet { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Predmet = await _context.Predmet.FirstOrDefaultAsync(m => m.Id == id);

            if (Predmet == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Predmet = await _context.Predmet.FindAsync(id);

            if (Predmet != null)
            {
                _context.Predmet.Remove(Predmet);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
