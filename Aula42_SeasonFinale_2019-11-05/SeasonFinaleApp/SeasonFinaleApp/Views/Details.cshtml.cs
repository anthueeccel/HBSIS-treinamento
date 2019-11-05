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
    public class DetailsModel : PageModel
    {
        private readonly SeasonFinaleApp.Models.SeasonFinaleDbContext _context;

        public DetailsModel(SeasonFinaleApp.Models.SeasonFinaleDbContext context)
        {
            _context = context;
        }

        public Usuario Usuario { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Usuario = await _context.Usuario.FirstOrDefaultAsync(m => m.Id == id);

            if (Usuario == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
