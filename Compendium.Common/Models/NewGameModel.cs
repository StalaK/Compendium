
using Compendium.Common.Enums;

namespace Compendium.Common.Models
{
    public class NewGameModel
    {
        public string Title { get; set; }

        public string Publisher { get; set; }

        public Console Console { get; set; }

        public GameGenre Genre { get; set; }

        public Format Format { get; set; }
    }
}
