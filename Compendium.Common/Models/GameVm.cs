using System;
using Compendium.Common.Enums;

namespace Compendium.Common.Models
{
    public class GameVm
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public GameGenre Genre { get; set; }
        public Enums.Console Console { get; set; }
        public Format Format { get; set; }
        public bool LocalMultiplayer { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
        public int UserAdded { get; set; }
    }
}
