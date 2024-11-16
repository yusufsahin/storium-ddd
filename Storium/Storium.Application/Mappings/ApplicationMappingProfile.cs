using AutoMapper;
using Storium.Application.DTOs;
using Storium.Domain.ValueObjects;

namespace Storium.Application.Mappings
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            // Money Mapping
            CreateMap<Money, MoneyDto>().ReverseMap();

            // Address Mapping
            CreateMap<Address, AddressDto>().ReverseMap();
        }
    }
}