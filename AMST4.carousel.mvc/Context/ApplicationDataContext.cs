

using AMST4.carousel.mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace AMST4.carousel.mvc.Context
{
    public class ApplicationDataContext :DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
    }
}
