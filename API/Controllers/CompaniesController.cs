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
    public class CompaniesController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public CompaniesController(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet("{clientId}/companies")]
        public async Task<ActionResult<IEnumerable<CompanyDTO>>> GetCompaniesByClientId(int clientId)
        {
            var client = await _context.Clients
                .Include(c => c.Companies)
                .FirstOrDefaultAsync(c => c.Id == clientId);

            if (client == null)
            {
                return NotFound($"Client with ID {clientId} not found");
            }

            var companies = client.Companies.ToList();
            var companiesToReturn = _mapper.Map<IEnumerable<CompanyDTO>>(companies);
            return Ok(companiesToReturn);
        }
    }
}
