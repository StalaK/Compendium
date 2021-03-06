using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Compendium.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : ControllerBase
    {
        public BookController()
        {

        }
        
        [HttpGet]
        public List<string> GetBooks()
        {
            return new List<string> { "Book1", "Book2" };
        }

        [HttpGet]
        public string GetBook(int isbn)
        {
            return $"ISBN: {isbn}";
        }

        [HttpPost]
        public string AddBook(string isbn)
        {
            return $"Book {isbn} added!";
        }

        [HttpDelete]
        public string DeleteBook(string isbn)
        {
            return $"{isbn} deleted";
        }
    }
}
