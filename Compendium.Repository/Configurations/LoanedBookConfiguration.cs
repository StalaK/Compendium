using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class LoanedBookConfiguration : IEntityTypeConfiguration<LoanedBook>
    {
        public void Configure(EntityTypeBuilder<LoanedBook> builder)
        {
            builder.HasKey(k => k.Id);

            builder.Property(p => p.Id)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.LoanDate)
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.ReturnDate)
                .IsRequired(false);
        }
    }
}
