using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class PeopleConfiguration : IEntityTypeConfiguration<People>
    {
        public void Configure(EntityTypeBuilder<People> builder)
        {
            builder.HasMany(e => e.LoanedBoardGames)
                .WithOne(e => e.Lender);

            builder.HasMany(e => e.LoanedBooks)
                .WithOne(e => e.Lender);

            builder.HasMany(e => e.LoanedGames)
                .WithOne(e => e.Lender);

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.FirstName)
                .IsRequired(true)
                .HasMaxLength(255);

            builder.Property(p => p.Surname)
                .IsRequired(false)
                .HasMaxLength(255);
        }
    }
}
