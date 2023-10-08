using AutoMapper;
using FluentValidationLib.DTOs;
using FluentValidationLib.Models;

namespace FluentValidationLib.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>().ReverseMap(); //tam tersini de gerçekleştirebilmek için ->reverse
        }
    }
}
