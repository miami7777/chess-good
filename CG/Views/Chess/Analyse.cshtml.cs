using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ChessApp.Pages
{
    public class AnalyseModel : PageModel
    {
        private readonly ILogger<AnalyseModel> _logger;

        public AnalyseModel(ILogger<AnalyseModel> logger)
        {
            _logger = logger;
        }		

        public void OnGet()
        {

        }
    }
}
