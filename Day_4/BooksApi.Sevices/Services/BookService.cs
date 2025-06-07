using BooksApi.Entities.Repositories.Interfaces;
using BooksApi.Models;
using BooksApi.Entities.Entities;

namespace BooksApi.Services
{
    // For CRUD operations on Books
    public class BookService : IBookService
    {
        private List<Book> _books;
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository) { 
            _bookRepository = bookRepository;
            _books = new List<Book>();
        }

        // For adding books
        public void AddBook(Book book)
        {
            _books.Add(book);
        }
        // For getting all books
        public List<Book> GetAll()
        {
            return _books;
        }
        // For getting a particular book
        public Book? GetBookById(int id)
        {
            return _books.Find(x => x.id == id);
        }

        // For updating a book
        public void UpdateBook(int id, Book book)
        {
            var existingBook = _books.Find(x => x.id == id);
            if (existingBook != null)
            {
                existingBook.title = book.title;
                existingBook.description = book.description;
                existingBook.author = book.author;
            }
        }
        // For deleting a book
        public void DeleteBook(int id)
        {
            var book = _books.Find(x => x.id == id);
            if (book != null)
            {
                _books.Remove(book);
            }
        }

        public async Task Insertion(BookDetails bookDetails)
        {
            await _bookRepository.Insertion(bookDetails);
        }

        public BookDetails GetBookDetailsById(int id)
        {
            return _bookRepository.GetById(id);

        }
}
