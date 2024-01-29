using API.Customer;
using API.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;


[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly DataContext _context;

    public UserController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Client>>> GetClients()
    {
        var clients =await  _context.Clients.ToListAsync();

        return clients;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Client>> GetClient(int id)
    {

        return await  _context.Clients.FindAsync(id);
    }

    [HttpGet("airtime")]
    public IActionResult GetAirtime()
    {
        DateTime clientAirtime = DateTime.Now;
        return Ok(clientAirtime.ToString("yyyy-MM-ddTHH:mm:ss"));
    }
}

