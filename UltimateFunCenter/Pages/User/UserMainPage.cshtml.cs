using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages.User
{
    public class UserMainPageModel : PageModel
    {
        private readonly ILogger<UserMainPageModel> _logger;

        public UserMainPageModel(ILogger<UserMainPageModel> logger) {
                _logger= logger;
        }
            public void OnGet()
        {
        }
    }
}
