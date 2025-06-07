using BooksApi.Models;
using BooksApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace BooksApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookservice)
        {
            _bookService = bookservice;
        }
        [HttpPost]
        [Route("Add")]
        public async Task<ActionResult> AddBook(BookDetails bookDetails)
        {
            await _bookService.InsertBook(bookDetails);
            return Ok("Books Created!!!");
        }

        [HttpGet]
        [Route("GetAll")]
        public ActionResult GetAll()
        {
            return Ok(_bookService.GetAll());
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult GetBookDetailsById(int id)
        {
            var res = _bookService.GetBookById(id);
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
            var res = _bookService.GetBookById(id);
            if (res != null)
            {
                _bookService.UpdateBook(id, book);
                return Ok("Book Updated!!!");
            }
            return NotFound("Book not Available");
        }
        [HttpDelete]
        [Route("Delete")]
        public ActionResult DeleteBook(int id)
        {
            var res = _bookService.GetBookById(id);
            if (res != null)
            {
                _bookService.DeleteBook(id);
                return Ok("Book Deleted!!!");
            }
            return NotFound("Book not Available");
        }
    }
}
