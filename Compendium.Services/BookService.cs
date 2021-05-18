using System.Collections.Generic;
using System.Linq;
using Compendium.Common.Models;
using Compendium.Repository;
using Compendium.Repository.Models;

namespace Compendium.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public List<BookVm> GetBooks()
        {
            var books = _bookRepository.GetBooks();

            var bookVm = new List<BookVm>();

            books.ToList().ForEach(b =>
            {
                bookVm.Add(new BookVm
                {
                    Isbn = b.Isbn,
                    Title = b.Title,
                    Author = b.Author,
                    Publisher = b.Publisher,
                    Genre = b.Genre.ToString(),
                    Edition = b.Edition,
                    Pages = b.Pages,
                    Format = b.Format.ToString()
                    
                });
            });

            return bookVm;
        }

        public BookVm Getbook(string isbn)
        {
            var book = _bookRepository.GetBook(isbn);

            var bookVm = new BookVm
            {
                Isbn = book.Isbn,
                Title = book.Title,
                Author = book.Author,
                Publisher = book.Publisher,
                Genre = book.Genre.ToString(),
                Edition = book.Edition,
                Pages = book.Pages,
                Format = book.Format.ToString()
            };

            return bookVm;
        }

        public void Addbook(NewBookModel model)
        {
            var book = new Book
            {
                Isbn = model.Isbn,
                Title = model.Title,
                Author = model.Author,
                Genre = model.Genre,
                Edition = model.Edition,
                Format = model.Format
            };

            _bookRepository.AddBook(book);
        }

        public void DeleteBook(string isbn)
        {
            _bookRepository.DeleteBook(isbn);
        }
    }
}
