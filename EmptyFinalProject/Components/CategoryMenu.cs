using EmptyFinalProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace EmptyFinalProject.Components
{
	public class CategoryMenu : ViewComponent
	{
		private readonly ICategoryRepo _categoryRepo;

		public CategoryMenu(ICategoryRepo categoryRepo)
		{
			_categoryRepo = categoryRepo;

		}

		public IViewComponentResult Invoke()
		{
			//var categories = _categoryRepo.GetAllCategories().OrderBy(c => c.Name);
			var categories = _categoryRepo.GetAllCategories.OrderBy(c => c.categoryName);

			return View(categories);
		}

	}
}
