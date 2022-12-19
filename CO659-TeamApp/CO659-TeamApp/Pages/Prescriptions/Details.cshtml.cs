using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Prescriptions
{
    public class DetailsModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public DetailsModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

      public Prescription Prescription { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Prescriptions == null)
            {
                return NotFound();
            }

            var prescription = await _context.Prescriptions.FirstOrDefaultAsync(m => m.PrescriptionID == id);
            if (prescription == null)
            {
                return NotFound();
            }
            else 
            {
                Prescription = prescription;
            }
            return Page();
        }
    }
}
