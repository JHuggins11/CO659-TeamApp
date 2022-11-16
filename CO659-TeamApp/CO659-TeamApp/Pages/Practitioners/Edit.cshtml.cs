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

namespace CO659_TeamApp.Pages.Practitioners
{
    public class EditModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public EditModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Practitioner Practitioner { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Practitioners == null)
            {
                return NotFound();
            }

            var practitioner =  await _context.Practitioners.FirstOrDefaultAsync(m => m.ID == id);
            if (practitioner == null)
            {
                return NotFound();
            }
            Practitioner = practitioner;
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

            _context.Attach(Practitioner).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PractitionerExists(Practitioner.ID))
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

        private bool PractitionerExists(int id)
        {
          return _context.Practitioners.Any(e => e.ID == id);
        }
    }
}
