using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages.Admin
{
    public class AdminMainPageModel : PageModel
    {
        private readonly ILogger<AdminMainPageModel> _logger;
        public AdminMainPageModel(ILogger<AdminMainPageModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
