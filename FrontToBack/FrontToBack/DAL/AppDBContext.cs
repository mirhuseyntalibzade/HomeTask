using FrontToBack.Models;
using Microsoft.EntityFrameworkCore;

namespace FrontToBack.DAL
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options) {}
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
