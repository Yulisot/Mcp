
using API.Customer;
using API.Database;
using API.DTOS;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {   
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public UserController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{clientId}/users")]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetUsersByClientId(int clientId)
        {
            var client = await _context.Clients
                .Include(c => c.Companies)
                .ThenInclude(comp => comp.Users)
                .FirstOrDefaultAsync(c => c.Id == clientId);

            if (client == null)
            {
                return NotFound($"Client with ID {clientId} not found");
            }

            var users = client.Companies.SelectMany(comp => comp.Users).ToList();
            var usersToReturn = _mapper.Map<IEnumerable<UserDTO>>(users);
            return Ok(usersToReturn);
        }
    }
}

// using API.Customer;
// using API.Database;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.EntityFrameworkCore;


// namespace API.Controllers
// {
//     [ApiController]
//     [Route("api/[controller]")]
//     public class UserController : ControllerBase
//     {
//         private readonly DataContext _context;

//         public UserController(DataContext context)
//         {
//             _context = context;
//         }

//         // [HttpGet] // api/client with company
//         // public async Task<ActionResult<IEnumerable<Client>>> GetClients()
//         // {
//         //     var clientsWithCompanies = await _context.Clients
//         //         .Include(u => u.Companies)
//         //         .ToListAsync();

//         //     return clientsWithCompanies;
//         // }  

//         // [HttpGet("ByClient/{clientId}")] // GET: api/User/ByClient/1

//         // public async Task<ActionResult<List<User>>> GetUsersByClient(int clientId)
//         // {
//         //     var users = await _context.Users
//         //         .Where(u => u.ClientId == clientId)
//         //         .ToListAsync();

//         //     if (users == null || users.Count == 0)
//         //     {
//         //         return NotFound();
//         //     }

//         //     return users;
//         // }

//         [HttpGet("ByCompany/{companyId}")] // GET: api/User/ByCompany/1
//         public async Task<ActionResult<IEnumerable<User>>> GetUsersByCompany(int companyId)
//         {
//             var users = await _context.Users
//                 .Where(u => u.CompanyId == companyId)
//                 .ToListAsync();

//             if (users == null || users.Count == 0)
//             {
//                 return NotFound();
//             }

//             return users;
//         }

//     }
// }