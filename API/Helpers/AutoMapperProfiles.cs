using AutoMapper;
using API.Customer;
using API.DTOS;
namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Company, CompanyDto>().MaxDepth(1); 
            CreateMap<Client, ClientDto>().MaxDepth(1);   
            CreateMap<User, UserDto>();
            CreateMap<UserLogin, UserLoginDto>();
            CreateMap<Emp, EmpDto>();
            CreateMap<Paycheck, PaycheckDto>();
        }
    }
}