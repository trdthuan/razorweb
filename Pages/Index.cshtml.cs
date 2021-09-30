using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Database.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace EF_Database.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly MyBlogContext myBlogContext;

        public IndexModel(ILogger<IndexModel> logger, MyBlogContext _myBlogContext)
        {
            _logger = logger;
            myBlogContext = _myBlogContext;
        }

        public void OnGet()
        {
            
        }
    }
}
