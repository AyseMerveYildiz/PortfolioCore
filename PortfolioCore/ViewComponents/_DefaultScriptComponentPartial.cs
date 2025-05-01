using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultScriptComponentPartial : ViewComponent
    {
        // PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            // var values = context.Portfolios.ToList();
            return View();
        }
    }
}
