using System;

namespace Compendium.Repository.Models
{
    public class CompendiumItemBase
    {
        public DateTime DateAdded { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
    }
}
