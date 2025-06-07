
using BooksApi.Entities.Entities;
namespace BooksApi.Entities.Repositories.Interfaces
{
    public interface IBookRepository
    {
       
        Task Insertion(BookDetails bookDetails);
        BookDetails GetById(int id);
    }
}
