using API.Customer;
using API.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;

        public UserController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{userName}")]
        public async Task<ActionResult<Client>> GetUser(string userName)
        {
            var user = await _context.Clients
                .Include(u => u.Companies)
                .FirstOrDefaultAsync(u => u.Name == userName);

            if (user == null)
            {
                return NotFound($"User {userName} not found.");
            }

            return user;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client>>> GetClientsWithCompanies() // api/user
        {
            var clientsWithCompanies = await _context.Clients
                .Include(u => u.Companies)
                .ToListAsync();

            return clientsWithCompanies;
        }

    }
}


