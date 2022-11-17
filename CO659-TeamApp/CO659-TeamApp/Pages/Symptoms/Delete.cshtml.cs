﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Symptoms
{
    public class DeleteModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public DeleteModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Symptom Symptom { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Symptoms == null)
            {
                return NotFound();
            }

            var symptom = await _context.Symptoms.FirstOrDefaultAsync(m => m.ID == id);

            if (symptom == null)
            {
                return NotFound();
            }
            else 
            {
                Symptom = symptom;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Symptoms == null)
            {
                return NotFound();
            }
            var symptom = await _context.Symptoms.FindAsync(id);

            if (symptom != null)
            {
                Symptom = symptom;
                _context.Symptoms.Remove(Symptom);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}