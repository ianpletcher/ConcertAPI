using ConcertApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ConcertApi.Data;

public class VenueContext : DbContext
{
    public VenueContext(DbContextOptions<VenueContext> options)
        : base(options) { }

    public DbSet<ConcertApi.Models.Venue>? Venues { get; set; }
}
