namespace EmptyFinalProject.Models
{
	public class Sports
	{
		public int SportsId { get; set; }
		public string name { get; set; }

		public int playersReq { get; set; }

		public string sportsType { get; set; }

		//public int ticketPrice { get; set; }

		public int categoryId { get; set; }

		public Category catergory { get; set; }
	}
}
