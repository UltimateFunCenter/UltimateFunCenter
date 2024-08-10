using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages.Admin
{
    public class FacilityPageModel : PageModel
    {
        private readonly ILogger<FacilityPageModel> _logger;
        public FacilityPageModel(ILogger<FacilityPageModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
        }
    }
}
