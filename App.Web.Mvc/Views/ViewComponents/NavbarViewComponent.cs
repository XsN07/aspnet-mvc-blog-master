using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;

namespace App.Web.Mvc.Views.ViewComponents
{    
	public class NavbarViewComponent: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View("_Navbar");
		}
	}
}
