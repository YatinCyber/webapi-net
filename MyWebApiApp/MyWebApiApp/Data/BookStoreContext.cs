using Microsoft.EntityFrameworkCore;

namespace MyWebApiApp.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt) : base(opt)
        {

        }
        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion
    }
}
