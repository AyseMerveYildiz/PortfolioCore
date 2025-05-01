using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
	public class _DefaultAboutComponentPartial:ViewComponent
	{
		PortfolioContext context = new PortfolioContext();
		public IViewComponentResult Invoke()
		{
			var values = context.Abouts.ToList();
			return View(values);
		}
	}
}
