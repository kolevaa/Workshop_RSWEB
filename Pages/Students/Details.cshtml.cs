﻿#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Workshop_RSWEB.Data;
using Workshop_RSWEB.Models;

namespace Workshop_RSWEB.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Workshop_RSWEB.Data.Workshop_RSWEBContext _context;

        public DetailsModel(Workshop_RSWEB.Data.Workshop_RSWEBContext context)
        {
            _context = context;
        }

        public Student Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Student.FirstOrDefaultAsync(m => m.Id == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
