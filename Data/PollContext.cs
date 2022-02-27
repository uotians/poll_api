using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data;

public class PollContext : DbContext
{
    public PollContext(DbContextOptions<PollContext> options)
        : base(options)
    {
    }
    public DbSet<Poll> Polls => Set<Poll>();
    public DbSet<Option> Options => Set<Option>();

}