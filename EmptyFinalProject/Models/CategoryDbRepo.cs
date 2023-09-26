namespace EmptyFinalProject.Models
{
	public class CategoryDbRepo : ICategoryRepo
	{
		private readonly SportsDbContext _sportsDbContext;

		public CategoryDbRepo(SportsDbContext sportsDbContext)
		{
			_sportsDbContext = sportsDbContext;
		}

		//public IEnumerable<Category> GetAllCategories => throw new NotImplementedException();

		//public IEnumerable<Category> GetAllCategies
		//{
		//	get { return _sportsDbContext.Categories; }
		//}

		public IEnumerable<Category> GetAllCategories => _sportsDbContext.Categories;

		//public IEnumerable<Category> GetAllCategories => throw new NotImplementedException();

		//public IEnumerable<Category> GetAllCategories => throw new NotImplementedException();
	}
}
