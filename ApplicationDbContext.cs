using CrudOperationWithDTOs.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudOperationWithDTOs
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        /// <summary>
        /// DbSet representing the Products table in the database.
        /// </summary>
        /// 
        public DbSet<Product> Products { get; set; }
    }
}
