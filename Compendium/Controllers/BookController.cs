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
        public ActionResult<List<string>> GetBooks()
        {
            return Ok(new List<string> { "Book1", "Book2" });
        }

        [HttpGet]
        public ActionResult<string> GetBook(int isbn)
        {
            return Ok($"ISBN: {isbn}");
        }

        [HttpPost]
        public ActionResult<string> AddBook(NewBookModel model)
        {
            return Ok($"Book {model.Isbn} added!");
        }

        [HttpDelete]
        public ActionResult<string> DeleteBook(string isbn)
        {
            return Ok($"{isbn} deleted");
        }
    }
}
