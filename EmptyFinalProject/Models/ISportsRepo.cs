namespace EmptyFinalProject.Models
{
	public interface ISportsRepo
	{
		public IEnumerable<Sports> AllSports { get; }

		//public IEnumerable<Sports> SportsOfTheWeek { get; }

		Sports GetSportsById(int SportsId);

		IEnumerable<Sports> SearchSports(string searchQuery);
	}
}
