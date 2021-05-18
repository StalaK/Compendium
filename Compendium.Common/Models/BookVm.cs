using Compendium.Common.Enums;

namespace Compendium.Common.Models
{
    public class BookVm
    {
        public string Isbn { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public string Genre { get; set; }
        public int? Edition { get; set; }
        public string Pages { get; set; }
        public string Format { get; set; }
    }
}
