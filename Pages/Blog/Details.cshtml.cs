using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EF_Database.models;

namespace EF_Database.Pages.Blog
{
    public class DetailsModel : PageModel
    {
        private readonly EF_Database.models.MyBlogContext _context;

        public DetailsModel(EF_Database.models.MyBlogContext context)
        {
            _context = context;
        }

        public Article Article { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Article = await _context.articles.FirstOrDefaultAsync(m => m.id == id);

            if (Article == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
