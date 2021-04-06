using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class BoardGameConfiguration : IEntityTypeConfiguration<BoardGame>
    {
        public BoardGameConfiguration()
        {
        }

        public void Configure(EntityTypeBuilder<BoardGame> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Name)
                .HasMaxLength(255)
                .IsRequired(true);

            builder.Property(p => p.Publisher)
                .HasMaxLength(255)
                .IsRequired(false);

            builder.Property(p => p.MinGameLength)
                .IsRequired(false);

            builder.Property(p => p.MaxGameLength)
                .IsRequired(false);

            builder.Property(p => p.MinNoOfPlayers)
                .IsRequired(false);

            builder.Property(p => p.MaxNoOfPlayers)
                .IsRequired(false);

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
