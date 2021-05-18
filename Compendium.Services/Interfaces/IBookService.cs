using System.Collections.Generic;
using Compendium.Common.Models;

namespace Compendium.Services
{
    public interface IBookService
    {
        List<BookVm> GetBooks();
        BookVm Getbook(string isbn);
        void Addbook(NewBookModel model);
        void DeleteBook(string isbn);
    }
}
