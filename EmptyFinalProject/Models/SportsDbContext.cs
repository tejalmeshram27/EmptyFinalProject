using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EmptyFinalProject.Models
{
	public class SportsDbContext : IdentityDbContext
	{
		public SportsDbContext( DbContextOptions<SportsDbContext> options ):base(options) { }

		public DbSet<Sports> Sports { get; set; }

		public DbSet<Category> Categories { get; set; }

		public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

		public DbSet<Order> Orders { get; set; }	


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			//seeding the db
			modelBuilder.Entity<Category>().HasData
				(new Category
				{
					catergoryId = 3,
					categoryName = "Boring",
					description = "Very Boring",
				});
			modelBuilder.Entity<Category>().HasData
				(new Category
				{
					catergoryId = 2,
					categoryName = "Watchable",
					description = "Can Watch",
				});
			modelBuilder.Entity<Category>().HasData
				(new Category
				{
					catergoryId = 1,
					categoryName = "Interesting",
					description = "Very Interesting",
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 1,
					name = "Cricket",
					playersReq = 22,
					sportsType = "Outdoor",
					categoryId = 1,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 2,
					name = "Badminton",
					playersReq = 2,
					sportsType = "Indoor",
					categoryId = 2,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 3,
					name = "Kabaddi",
					playersReq = 14,
					sportsType = "Indoor",
					categoryId = 3,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 4,
					name = "Football",
					playersReq = 22,
					sportsType = "Outdoor",
					categoryId = 1,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 5,
					name = "Tennis",
					playersReq = 2,
					sportsType = "Outdoor",
					categoryId = 2,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 6,
					name = "Golf",
					playersReq = 1,
					sportsType = "Outdoor",
					categoryId = 3,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 7,
					name = "Basketball",
					playersReq = 24,
					sportsType = "Indoor",
					categoryId = 2,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 8,
					name = "Baseball",
					playersReq = 18,
					sportsType = "Outdoor",
					categoryId = 3,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 9,
					name = "Chess",
					playersReq = 2,
					sportsType = "Indoor",
					categoryId = 2,
				});
			modelBuilder.Entity<Sports>().HasData
				(new Sports
				{
					SportsId = 10,
					name = "FoosBall",
					playersReq = 4,
					sportsType = "Indoor",
					categoryId = 3,
				});

		}

	}
}
