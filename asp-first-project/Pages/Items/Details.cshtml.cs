using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using asp_first_project.Models;

namespace asp_first_project.Pages_Items
{
    public class DetailsModel : PageModel
    {
        private readonly ItemContext _context;

        public DetailsModel(ItemContext context)
        {
            _context = context;
        }

        public Item Item { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Item = await _context.Item.FirstOrDefaultAsync(m => m.id == id);

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
