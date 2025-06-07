using System.ComponentModel.DataAnnotations;

namespace BooksApi.Entities.Entities
{
    public class BookDetails
    {
        [Key]
        public int id { get; set; }

        public string title { get; set; }
        public string description { get; set; }
        public string author { get; set; }
    }
}
