using EmptyFinalProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers
{
	public class OrderController : Controller
	{
		[Authorize (Roles ="Admin")]

		public IActionResult Checkout()
		{  
			return View();
		}

		[HttpPost]
		public IActionResult Checkout(Order order)

		{
			if(ModelState.IsValid)
			{
				return RedirectToAction("CheckoutComplete");
			}
			return View();
		}

		public IActionResult CheckoutComplete() 
		{
			ViewBag.CheckoutMsg = "Thanks for Visiting";
			return View();
		}
	}
}
