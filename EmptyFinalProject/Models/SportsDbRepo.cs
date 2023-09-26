using Microsoft.EntityFrameworkCore;

namespace EmptyFinalProject.Models
{
	public class SportsDbRepo : ISportsRepo
	{
		private readonly SportsDbContext _sportsDbContext;

		public SportsDbRepo( SportsDbContext sportsDbContext)
		{
			_sportsDbContext = sportsDbContext;
		}

		public IEnumerable<Sports> AllSports
		{
			get { return _sportsDbContext.Sports.Include(c => c.catergory) ; }
			//get { return _sportsDbContext.Sports ; }	

		}

		//public IEnumerable<Sports> SportsOfTheWeek { }

		public Sports GetSportsById(int sportsId)
		{
			return AllSports.FirstOrDefault(m => m.SportsId == sportsId);
		}

        public IEnumerable<Sports> SearchSports(string searchQuery)
        {
            return _sportsDbContext.Sports.Where(p=>p.name.Contains(searchQuery));
        }
    }
}
