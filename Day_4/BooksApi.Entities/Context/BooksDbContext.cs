using Microsoft.EntityFrameworkCore;
using BooksApi.Entities.Entities;

namespace BooksApi.Entities.Context
{
    public class BooksDbContext(DbContextOptions<BooksDbContext> options) : DbContext(options)
    {
        public DbSet<BookDetails> BookDetails { get; set; }
    }
}
