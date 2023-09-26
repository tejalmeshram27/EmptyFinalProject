namespace EmptyFinalProject.Models
{
	public class MockSportsRepo : ISportsRepo
	{
		private readonly ICategoryRepo categoryRepo = new MockCategoryRepo();

		List<Sports> _sportsList;

		public MockSportsRepo()
		{
			_sportsList = new List<Sports>()
			{
				new Sports()
				{
					SportsId = 1,
					name = "Cricket",
					playersReq = 22,
					sportsType = "Outdoor",
					categoryId = 1,
					catergory = categoryRepo.GetAllCategories.ToList()[1],
				},
				new Sports()
				{
					SportsId = 2,
					name = "Badminton",
					playersReq = 2,
					sportsType = "Indoor",
					categoryId = 2,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 3,
					name = "Kabaddi",
					playersReq = 14,
					sportsType = "Indoor",
					categoryId = 3,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 4,
					name = "Football",
					playersReq = 22,
					sportsType = "Outdoor",
					categoryId = 1,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 5,
					name = "Tennis",
					playersReq = 2,
					sportsType = "Outdoor",
					categoryId = 2,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 6,
					name = "Golf",
					playersReq = 1,
					sportsType = "Outdoor",
					categoryId = 3,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 7,
					name = "Basketball",
					playersReq = 24,
					sportsType = "Indoor",
					categoryId = 2,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},
				new Sports()
				{
					SportsId = 8,
					name = "Baseball",
					playersReq = 18,
					sportsType = "Outdoor",
					categoryId = 3,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},

				new Sports()
				{
					SportsId = 9,
					name = "Chess",
					playersReq = 2,
					sportsType = "Indoor",
					categoryId = 2,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},

				new Sports()
				{
					SportsId = 10,
					name = "FoosBall",
					playersReq = 4,
					sportsType = "Indoor",
					categoryId = 3,
					catergory = categoryRepo.GetAllCategories.ToList()[1],

				},

			};
		}


		public IEnumerable<Sports> AllSports
		{
			get { return _sportsList; }
		}

		public Sports? GetSportsById(int sportsId)
		{
			return AllSports.FirstOrDefault(m => m.SportsId == sportsId);
		}

        public IEnumerable<Sports> SearchSports(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
