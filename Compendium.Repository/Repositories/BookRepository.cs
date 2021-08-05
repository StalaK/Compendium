using System;
using System.Collections.Generic;
using System.Linq;
using Compendium.Repository.Models;

namespace Compendium.Repository
{
    public class BookRepository : IBookRepository
    {
        private readonly CompendiumContext _context;

        public BookRepository(CompendiumContext context)
        {
            _context = context;
        }

        public IEnumerable<Book> GetBooks()
        {
            var books = _context.Books.Where(b => !b.DateDeleted.HasValue);
            return books;
        }

        public Book GetBook(string isbn)
        {
            var book = _context.Books.FirstOrDefault(b => b.Isbn == isbn);
            return book;
        }

        public void AddBook(Book book)
        {
            _context.Books.Add(book);
        }

        public void DeleteBook(string isbn)
        {
            var book = _context.Books.FirstOrDefault(b => b.Isbn == isbn);
            book.DateDeleted ??= DateTime.Now;

            _context.Books.Update(book);
        }
    }
}
