using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab4.Data;
using Lab4.Models;

namespace Lab4.Pages.Vechicles
{
    public class EditModel : PageModel
    {
        private readonly Lab4.Data.Lab4Context _context;

        public EditModel(Lab4.Data.Lab4Context context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(VechicleModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VechicleModelExists(VechicleModel.ID))
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

        private bool VechicleModelExists(Guid id)
        {
            return _context.VechicleModel.Any(e => e.ID == id);
        }
    }
}
