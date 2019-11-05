using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SeasonFinaleApp.Models;

namespace SeasonFinaleApp.Views
{
    public class IndexModel : PageModel
    {
        private readonly SeasonFinaleApp.Models.SeasonFinaleDbContext _context;

        public IndexModel(SeasonFinaleApp.Models.SeasonFinaleDbContext context)
        {
            _context = context;
        }

        public IList<Usuario> Usuario { get;set; }

        public async Task OnGetAsync()
        {
            Usuario = await _context.Usuario.ToListAsync();
        }
    }
}
