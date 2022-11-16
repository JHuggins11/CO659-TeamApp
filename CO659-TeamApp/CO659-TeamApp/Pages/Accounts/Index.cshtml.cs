using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Data;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Pages.Accounts
{
    public class IndexModel : PageModel
    {
        private readonly CO659_TeamApp.Data.ApplicationDbContext _context;

        public IndexModel(CO659_TeamApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Account> Account { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Accounts != null)
            {
                Account = await _context.Accounts.ToListAsync();
            }
        }
    }
}
