using Microsoft.EntityFrameworkCore;

namespace ConcertApi.Data;

public class ConcertContext : DbContext
{
    public ConcertContext(DbContextOptions<ConcertContext> options)
        : base(options) { }

    public DbSet<ConcertApi.Models.Concert>? Concerts { get; set; }
}
