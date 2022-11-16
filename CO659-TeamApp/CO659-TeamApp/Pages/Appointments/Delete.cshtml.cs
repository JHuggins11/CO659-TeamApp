using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Appointments
{
    public class DeleteModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public DeleteModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Appointment Appointment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Appointments == null)
            {
                return NotFound();
            }

            var appointment = await _context.Appointments.FirstOrDefaultAsync(m => m.ID == id);

            if (appointment == null)
            {
                return NotFound();
            }
            else 
            {
                Appointment = appointment;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Appointments == null)
            {
                return NotFound();
            }
            var appointment = await _context.Appointments.FindAsync(id);

            if (appointment != null)
            {
                Appointment = appointment;
                _context.Appointments.Remove(Appointment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
