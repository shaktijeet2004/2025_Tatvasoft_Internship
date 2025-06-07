
using BooksApi.Entities.Context;
using BooksApi.Entities.Entities;
using BooksApi.Entities.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BooksApi.Entities.Repositories
{
    public class BookRepository(BooksDbContext booksDbContext) : IBookRepository
    {
        private readonly BooksDbContext _dbContext = booksDbContext;

        public async Task Insertion(BookDetails bookDetails)
        {
            await _dbContext.BookDetails.AddAsync(bookDetails);
            await _dbContext.SaveChangesAsync();
        }
        public BookDetails GetById(int id)
        {
            return _dbContext.BookDetails.Where(x => x.id == id).FirstOrDefaultAsync();
        }
    }
}
