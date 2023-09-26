using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers
{
	public class ContactController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
