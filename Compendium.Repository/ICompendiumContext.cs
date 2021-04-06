using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace Compendium.Repository
{
    public interface ICompendiumContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<BoardGame> BoardGames { get; set; }
        public DbSet<LoanedBoardGame> LoanedBoardGames { get; set; }
        public DbSet<LoanedBook> LoanedBooks { get; set; }
        public DbSet<LoanedGame> LoanedGames { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<People> People { get; set; }
    }
}