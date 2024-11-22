using ApiPruebaLinktic.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiPruebaLinktic.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Reservation> Reservation { get; set; }

    }
}