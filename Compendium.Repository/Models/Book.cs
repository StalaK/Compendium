using Compendium.Common.Enums;

namespace Compendium.Repository.Models
{
    public class Book : CompendiumItemBase
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public BookGenre Genre { get; set; }
        public int Edition { get; set; }
        public string Pages { get; set; }
        public Format Format { get; set; }

        public string LoanedBookId { get; set; }
        public LoanedBook LoanedBook { get; set; }
    }
}
