using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class LoanedBoardGameConfiguration : IEntityTypeConfiguration<LoanedBoardGame>
    {
        public void Configure(EntityTypeBuilder<LoanedBoardGame> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();
        }
    }
}
