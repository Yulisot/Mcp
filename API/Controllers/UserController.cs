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

        [HttpGet] // api/client with company
        public async Task<ActionResult<IEnumerable<Client>>> GetClients()
        {
            var clientsWithCompanies = await _context.Clients
                .Include(u => u.Companies)
                .ToListAsync();

            return clientsWithCompanies;
        }  
        [HttpGet("ByClient/{clientId}")] // GET: api/User/ByClient/1

        public async Task<ActionResult<IEnumerable<User>>> GetUsersByClient(int clientId)
        {
            var users = await _context.Users
                .Where(u => u.ClientId == clientId)
                .ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }

        [HttpGet("ByCompany/{companyId}")] // GET: api/User/ByCompany/1
        public async Task<ActionResult<IEnumerable<User>>> GetUsersByCompany(int companyId)
        {
            var users = await _context.Users
                .Where(u => u.CompanyId == companyId)
                .ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound();
            }

            return users;
        }

    }
}


