using AutoMapper;
using API.Customer;
using API.DTOS;
namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Client, ClientDto>().MaxDepth(1);   
            CreateMap<Company, CompanyDto>().MaxDepth(1); 
            CreateMap<User, UserDto>();
            
                // .ForMember(dest => dest.Logins, opt => opt.Ignore())
                // .ForMember(dest => dest.Emps, opt => opt.Ignore())
                // .ForMember(dest => dest.Company, opt => opt.Ignore());

            CreateMap<UserLogin, UserLoginDto>();
            CreateMap<Emp, EmpDto>();
            CreateMap<Paycheck, PaycheckDto>();
        }
    }
}