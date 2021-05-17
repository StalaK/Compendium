using System.Collections.Generic;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(string isbn);
        void AddBook(Book book);
        void DeleteBook(string isbn);
    }
}
