using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAPP_NEW.Models;

namespace WebAPP_NEW.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<ERegistration> registrations { get; set; }
        public DbSet<Report> reports { get; set; }
    }
}
