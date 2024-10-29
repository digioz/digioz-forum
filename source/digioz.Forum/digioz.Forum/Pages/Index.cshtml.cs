using digioz.Forum.Data;
using digioz.Forum.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace digioz.Forum.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            var context = new DigiozForumContext();
            var users = context.AspNetUsers.ToList();
        }
    }
}
