using EmptyFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Controllers
{
	public class SportsController : Controller
	{
		//DI
		private readonly ISportsRepo _sportsRepo;
		private readonly ICategoryRepo _categoryRepo;

		public SportsController(ISportsRepo sportsRepo, ICategoryRepo categoryRepo)
		{
			_sportsRepo = sportsRepo;
			_categoryRepo = categoryRepo;
		}

		//public SportsController(ICategoryRepo categoryRepo)
		//{
		//	_categoryRepo = categoryRepo;
		//}

		public IActionResult Index(int category)
		{
			IEnumerable<Sports> sports;
			string currentCategory;

			//if(category==0)
			//{
				sports = _sportsRepo.AllSports.OrderBy(x => x.SportsId);
				currentCategory = "All Sports";
			//}

			//else
			//{
			//	sports = _sportsRepo.AllSports.Where()
			//}

			return View(sports);
		}

        public IActionResult SearchSports()
		{
            return View();
        }


    }
}
