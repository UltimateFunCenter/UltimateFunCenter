using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UltimateFunCenter.Pages
{
    public class InformationModel : PageModel
    {
        private readonly ILogger<InformationModel> _logger;

        public InformationModel(ILogger<InformationModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
