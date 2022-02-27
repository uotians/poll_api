#nullable disable
using backend.Models;
using backend.Data;
using Microsoft.EntityFrameworkCore;

namespace backend.Services;

public class PollService
{
    private readonly PollContext _context;
    public PollService(PollContext context)
    {
        _context = context;
    }
    

    public IEnumerable<Poll> GetAll()
    {
        return _context.Polls
            .AsNoTracking()
            .ToList();
    }

    public Poll GetById(int id)
    {
        return _context.Polls
            .Include(p => p.Options)
            .AsNoTracking()
            .SingleOrDefault(p => p.Id == id);
    }

    public Poll Create(Poll newPoll)
    {
        _context.Polls.Add(newPoll);
        _context.SaveChanges();

        return newPoll;
    }

    public Option Update(int id, int option)
    {
        var update = _context.Options.Where(x => x.Id == option);
        update.ForEachAsync(c => c.Votes += 1);

        _context.SaveChanges();

        return null;
    }
}