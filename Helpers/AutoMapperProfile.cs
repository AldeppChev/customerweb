using AutoMapper;
using DTO;
using Models;

namespace Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Customer, UserModel>();
            CreateMap<RegisterModel, Customer>();
            CreateMap<UpdateModel, Customer>();
        }
    }
}