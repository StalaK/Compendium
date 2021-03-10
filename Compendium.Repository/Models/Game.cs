using Compendium.Common.Enums;
using Console = Compendium.Common.Enums.Console;

namespace Compendium.Repository.Models
{
    public class Game : CompendiumItemBase
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public GameGenre Genre { get; set; }
        public Console Console { get; set; }
        public Format Format { get; set; }
        public bool LocalMultiplayer { get; set; }

        public int LoanedGameId { get; set; }
        public LoanedGame LoanedGame { get; set; }
    }
}
