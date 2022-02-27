#nullable disable
using backend.Services;
using backend.Models;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]")]
public class PollController : ControllerBase
{
    PollService _service;

    public PollController(PollService service)
    {
        _service = service;
    }

    [HttpGet]
    public IEnumerable<Poll> GetAll()
    {
        return _service.GetAll();
    }

    [HttpGet("{id}")]
    public ActionResult<Poll> GetById(int id)
    {
        var poll = _service.GetById(id);

        if (poll is not null)
        {
            return poll;
        }
        else
        {
            return NotFound();
        }
    }

    [HttpPost("/poll/add")]
    public IActionResult Create(Poll newPoll)
    {
        var poll = _service.Create(newPoll);

        return CreatedAtAction(nameof(GetById), new { id = poll!.Id }, poll);
    }

    [HttpGet("{id}/vote/{option}")]
    public ActionResult<Option> Update(int id, int option)
    {
        var upd = _service.Update(id, option);

        return upd;
    }
}