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
    public class IndexModel : PageModel
    {
        private readonly Workshop_RSWEB.Data.Workshop_RSWEBContext _context;

        public IndexModel(Workshop_RSWEB.Data.Workshop_RSWEBContext context)
        {
            _context = context;
        }

        public IList<Predmet> Predmet { get;set; }

        public async Task OnGetAsync()
        {
            Predmet = await _context.Predmet.ToListAsync();
        }
    }
}
