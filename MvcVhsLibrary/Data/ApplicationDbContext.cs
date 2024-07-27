using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MvcVhsLibrary.Models;

namespace MvcVhsLibrary.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<MvcVhsLibrary.Models.VHSTape> VHSTape { get; set; } = default!;
    }
}
