using AutoMapper;
using API.Customer;
using API.DTOS;
namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Company, CompanyDTO>().MaxDepth(1); 
            CreateMap<Client, ClientDTO>().MaxDepth(1);   
            CreateMap<User, UserDTO>();
        }
    }
}