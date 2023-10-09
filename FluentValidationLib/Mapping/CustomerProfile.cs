using AutoMapper;
using FluentValidationLib.DTOs;
using FluentValidationLib.Models;

namespace FluentValidationLib.Mapping
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerDto>() //ReverseMap();//tam tersini de gerçekleştirebilmek için ->reverse
                .ForMember(dest => dest.Isim, opt => opt.MapFrom(x => x.Name))
                .ForMember(dest => dest.Eposta, opt => opt.MapFrom(x => x.Email))
                .ForMember(dest => dest.Yas, opt => opt.MapFrom(x => x.Age))
                .ForMember(dest => dest.FullName, opt => opt.MapFrom(x => x.FullName2()));  //methodu propertye map     
        }
    }
}
