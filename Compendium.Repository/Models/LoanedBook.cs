using System.Collections.Generic;

namespace Compendium.Repository.Models
{
    public class LoanedBook
    {
        public int Id { get; set; }

        public List<Book> Books { get; set; }
        public List<User> User { get; set; }
    }
}
