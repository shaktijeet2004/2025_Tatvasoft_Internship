

namespace BooksApi.Sevices.Services.Interface
{
    public interface IBookService
    {
        void AddBook(Book book);
        List<Book> GetAll();
        Book? GetBookById(int id);
        void UpdateBook(int id, Book book);
        void DeleteBook(int id);
        Task Insertion(BookDetails bookDetails);
        BookDetails GetBookDetailsById(int id);
    }
}
