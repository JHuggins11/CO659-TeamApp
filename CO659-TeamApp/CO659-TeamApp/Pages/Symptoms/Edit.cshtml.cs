using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Symptoms
{
    public class EditModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public EditModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Symptom Symptom { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Symptoms == null)
            {
                return NotFound();
            }

            var symptom =  await _context.Symptoms.FirstOrDefaultAsync(m => m.ID == id);
            if (symptom == null)
            {
                return NotFound();
            }
            Symptom = symptom;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Symptom).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SymptomExists(Symptom.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool SymptomExists(int id)
        {
          return _context.Symptoms.Any(e => e.ID == id);
        }
    }
}
