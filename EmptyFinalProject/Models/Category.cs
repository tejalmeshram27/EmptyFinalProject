using System.ComponentModel.DataAnnotations;

namespace EmptyFinalProject.Models
{
	public class Category
	{
		[Key]
		public int catergoryId { get; set; }

		public string categoryName { get; set; }

		public string description { get; set; }
	}
}
