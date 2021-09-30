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
    public class IndexModel : PageModel
    {
        private readonly EF_Database.models.MyBlogContext _context;

        public IndexModel(EF_Database.models.MyBlogContext context)
        {
            _context = context;
        }

        public IList<Article> Article { get;set; }

        public const int ITEM_PER_PAGE = 10;
        [BindProperty(SupportsGet = true, Name = "p")]
        public int currentPage {get; set;}
        public int countPages {get; set;}

        public async Task OnGetAsync(string searchString)
        {
            int totalArticle = await _context.articles.CountAsync();
            countPages = (int)Math.Ceiling((double)totalArticle/ITEM_PER_PAGE);

            if (currentPage <1 ) currentPage =1;
            if (currentPage > countPages) currentPage = countPages;

            // Article = await _context.articles.ToListAsync();
            var qr = (from a in _context.articles
                     orderby a.Created descending
                     select a)
                     .Skip((currentPage - 1) * ITEM_PER_PAGE)
                     .Take(ITEM_PER_PAGE);

            if (!string.IsNullOrEmpty(searchString))
            {
                Article = await qr.Where(a => a.Title.Contains(searchString)).ToListAsync();
            }
            else
            {
                Article = await qr.ToListAsync();
            }
        }
    }
}
