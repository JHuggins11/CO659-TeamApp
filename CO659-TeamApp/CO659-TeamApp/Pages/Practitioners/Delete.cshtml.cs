using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Practitioners
{
    public class DeleteModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public DeleteModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Practitioner Practitioner { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Practitioners == null)
            {
                return NotFound();
            }

            var practitioner = await _context.Practitioners.FirstOrDefaultAsync(m => m.ID == id);

            if (practitioner == null)
            {
                return NotFound();
            }
            else 
            {
                Practitioner = practitioner;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Practitioners == null)
            {
                return NotFound();
            }
            var practitioner = await _context.Practitioners.FindAsync(id);

            if (practitioner != null)
            {
                Practitioner = practitioner;
                _context.Practitioners.Remove(Practitioner);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
