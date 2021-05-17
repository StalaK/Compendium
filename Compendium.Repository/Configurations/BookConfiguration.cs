using Compendium.Repository.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Compendium.Repository.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasMany(e => e.LoanedBook)
                .WithOne();

            builder.HasKey(k => k.Isbn);

            builder.Property(p => p.Isbn)
                .IsRequired(true)
                .ValueGeneratedNever()
                .HasMaxLength(13);

            builder.Property(p => p.Title)
                .IsRequired(true)
                .HasMaxLength(255);

            builder.Property(p => p.Author)
                .IsRequired(true)
                .HasMaxLength(255);

            builder.Property(p => p.Publisher)
                .IsRequired(false)
                .HasMaxLength(255);

            builder.Property(p => p.Genre)
                .IsRequired(true);

            builder.Property(p => p.Edition)
                .IsRequired(false);

            builder.Property(p => p.Pages)
                .IsRequired(false);

            builder.Property(p => p.Format)
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
