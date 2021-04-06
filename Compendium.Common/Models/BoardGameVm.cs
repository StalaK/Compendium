using Compendium.Common.Enums;

namespace Compendium.Common.Models
{
    public class BoardGameVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public int MinGameLength { get; set; }
        public int MaxGameLength { get; set; }
        public int MinNoOfPlayers { get; set; }
        public int MaxNoOfPlayers { get; set; }
        public BoardGameGenre Genre { get; set; }
    }
}
