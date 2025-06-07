using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly BookService bookService;
        public BookController(BookService book)
        {
            this.bookService = book;
        }
        [HttpPost]
        [Route("Add")]
        public ActionResult AddBook(Book book)
        {
            this.bookService.AddBook(book);
            return Ok("Books Created!!!");
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(this.bookService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult GetById(int id)
        {
            var res = this.bookService.GetBookById(id);
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound("Book not Available");
        }
        [HttpPut]
        [Route("Update")]
        public ActionResult UpdateBook(int id, Book book)
        {
            var res = this.bookService.GetBookById(id);
            if (res != null)
            {
                this.bookService.UpdateBook(id, book);
                return Ok("Book Updated!!!");
            }
            return NotFound("Book not Available");
        }
        [HttpDelete]
        [Route("Delete")]
        public ActionResult DeleteBook(int id)
        {
            var res = this.bookService.GetBookById(id);
            if (res != null)
            {
                this.bookService.DeleteBook(id);
                return Ok("Book Deleted!!!");
            }
            return NotFound("Book not Available");
        }
    }
}
