namespace EmptyFinalProject.Models
{
	public class MockCategoryRepo : ICategoryRepo
	{
		public IEnumerable<Category> GetAllCategories => new List<Category>
		{
			new Category
			{
				catergoryId = 1,
				categoryName = "High",
				description = "Popularity is High"

			},
			new Category
			{
				catergoryId = 2,
				categoryName = "Medium",
				description = "Popularity is Medium"

			},
			new Category
			{
				catergoryId = 3,
				categoryName = "Low",
				description = "Popularity is Low"
				
			}
		};
	}
}
