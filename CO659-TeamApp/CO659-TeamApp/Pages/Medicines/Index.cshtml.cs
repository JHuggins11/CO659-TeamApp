using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Medicines
{
    public class IndexModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public IndexModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Medicine> Medicine { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Medicines != null)
            {
                Medicine = await _context.Medicines
                .Include(m => m.Prescriptions).ToListAsync();
            }
        }
    }
}
