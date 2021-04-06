using Compendium.Repository.Configurations;
using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Compendium.Repository
{
    public class CompendiumContext : DbContext, ICompendiumContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<LoanedBoardGame> LoanedBoardGames { get; set; }
        public DbSet<LoanedBook> LoanedBooks { get; set; }
        public DbSet<LoanedGame> LoanedGames { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<People> People { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            //options.UsePostgres
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BoardGameConfiguration());
            modelBuilder.ApplyConfiguration(new BookConfiguration());
            modelBuilder.ApplyConfiguration(new GameConfiguration());
            modelBuilder.ApplyConfiguration(new LoanedBoardGameConfiguration());
            modelBuilder.ApplyConfiguration(new LoanedBookConfiguration());
            modelBuilder.ApplyConfiguration(new LoanedGameConfiguration());
            modelBuilder.ApplyConfiguration(new PeopleConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
        }
    }
}
