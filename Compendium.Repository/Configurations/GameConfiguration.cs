using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class GameConfiguration : IEntityTypeConfiguration<Game>
    {       
        public void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasMany(e => e.LoanedGame)
                .WithOne();

            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Title)
                .IsRequired(true)
                .HasMaxLength(255);

            builder.Property(p => p.Publisher)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.Property(p => p.Genre)
                .IsRequired(true);

            builder.Property(p => p.Console)
                .IsRequired(true);

            builder.Property(p => p.Format)
                .IsRequired(true);

            builder.Property(p => p.LocalMultiplayer)
                .IsRequired(true);

            builder.Property(p => p.DateAdded)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.DateUpdated)
                .IsRequired(false)
                .ValueGeneratedOnUpdate();

            builder.Property(p => p.DateDeleted)
                .IsRequired(false);
        }
    }
}
