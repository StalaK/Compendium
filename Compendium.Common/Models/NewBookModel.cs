using Compendium.Common.Enums;

namespace Compendium.Common.Models
{
    public class NewBookModel
    {
        public string Isbn { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public BookGenre Genre { get; set; }

        public int Edition { get; set; }

        public Format Format { get; set; }
    }
}
