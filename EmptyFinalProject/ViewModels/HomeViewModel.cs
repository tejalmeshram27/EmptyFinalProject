using EmptyFinalProject.Models;

namespace EmptyFinalProject.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Sports> Sports { get; }
		//public bool isThereMatch { get; set; }
		public IEnumerable<Category> Categories { get; }

		public HomeViewModel(IEnumerable<Sports> sports, IEnumerable<Category> categories)
		{
			Sports = sports;
			Categories = categories;
			//isThereMatch = istherematch;
		}
	}
}
