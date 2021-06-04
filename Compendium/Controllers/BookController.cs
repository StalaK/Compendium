using System.Collections.Generic;
using Compendium.Common.Models;
using Compendium.Services;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }
        
        [HttpGet]
        public ActionResult<List<BookVm>> GetBooks()
        {
            var books = _bookService.GetBooks();
            return Ok(books);
        }

        [HttpGet]
        public ActionResult<BookVm> GetBook(string isbn)
        {
            var book = _bookService.Getbook(isbn);
            return Ok(book);
        }

        [HttpPost]
        public ActionResult<string> AddBook(NewBookModel model)
        {
            _bookService.Addbook(model);
            return Ok($"{model.Title} added!");
        }

        [HttpDelete]
        public ActionResult<string> DeleteBook(string isbn)
        {
            _bookService.DeleteBook(isbn);
            return Ok($"{isbn} deleted");
        }
    }
}
