using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages.Admin
{
    public class AdminUsersPageModel : PageModel
    {
        private readonly ILogger<AdminUsersPageModel> _logger;

        public AdminUsersPageModel(ILogger<AdminUsersPageModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
