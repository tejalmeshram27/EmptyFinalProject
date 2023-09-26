namespace EmptyFinalProject.Models
{
	public interface ICategoryRepo
	{
		public IEnumerable<Category> GetAllCategories { get; }
	}
}
