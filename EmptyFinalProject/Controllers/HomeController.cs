using EmptyFinalProject.Models;
using EmptyFinalProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers
{
	public class HomeController : Controller
	{
		private readonly ISportsRepo _sportsRepo;
		private readonly ICategoryRepo _categoryRepo;

		public HomeController (ISportsRepo sportsRepo, ICategoryRepo categoryRepo)
		{
			_sportsRepo = sportsRepo;
			_categoryRepo = categoryRepo;
		}

		public IActionResult Index()
		{
			//var homeViewModel = new HomeViewModel
			//{
			//	SportsOfTheWeek = _sportsRepo.AllSports
			//};
			IEnumerable<Sports> sports;
			IEnumerable<Category> categories;
			sports = _sportsRepo.AllSports.OrderBy(s => s.name);
			categories = _categoryRepo.GetAllCategories;

			HomeViewModel homeViewModel=new HomeViewModel(sports,categories);

			return View(homeViewModel);
		}
	}
}
