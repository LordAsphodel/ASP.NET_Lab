using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages.Vechicles
{
    public class DeleteModel : PageModel
    {
        private readonly Lab4.Data.Lab4Context _context;

        public DeleteModel(Lab4.Data.Lab4Context context)
        {
            _context = context;
        }

        [BindProperty]
        public VechicleModel VechicleModel { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VechicleModel = await _context.VechicleModel.FirstOrDefaultAsync(m => m.ID == id);

            if (VechicleModel == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            VechicleModel = await _context.VechicleModel.FindAsync(id);

            if (VechicleModel != null)
            {
                _context.VechicleModel.Remove(VechicleModel);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
