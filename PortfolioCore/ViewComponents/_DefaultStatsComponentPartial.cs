using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatsComponentPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            PortfolioContext context = new PortfolioContext();
            ViewBag.testimonialCount = context.Testimonials.Count();
            ViewBag.portfolioCount = context.Portfolios.Count();
            ViewBag.skillCount = context.Skills.Count();
            Random random = new Random();
            int randomNumber = random.Next(10, 21);
            ViewBag.randomNumber = randomNumber;
            return View();
        }
    }
   
}
