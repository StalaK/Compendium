using System;
namespace Compendium.Repository.Models
{
    public class LoanBase
    {
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
    }
}
