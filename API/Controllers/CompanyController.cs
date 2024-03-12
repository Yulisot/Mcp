using API.Customer;
using API.Database;
using API.DTOS;
using AutoMapper;
using AutoMapper.QueryableExtensions;
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

        [HttpGet("{clientId}")]
        public async Task<ActionResult<IEnumerable<CompanyDto>>> GetCompaniesByClientId(int clientId)
        {
            var companies = await _context.Companies
                .Where(c => c.ClientId == clientId)
                .ProjectTo<CompanyDto>(_mapper.ConfigurationProvider)
                .ToListAsync();

            
            if (companies == null)
            {
                return NotFound();
            }

            return Ok(companies);
        }
    }
}
