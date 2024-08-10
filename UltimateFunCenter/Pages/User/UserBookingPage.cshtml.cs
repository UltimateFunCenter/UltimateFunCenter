using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages.User
{
    public class UserBookingPageModel : PageModel
    {
        private readonly ILogger<UserBookingPageModel> _logger;

        public UserBookingPageModel(ILogger<UserBookingPageModel> logger)
        {
            _logger = logger;
        }
            public void OnGet()
        {
        }
    }
}
