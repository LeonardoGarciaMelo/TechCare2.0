using AutoMapper;
using TechCare.Models.Address;

namespace TechCare.Profiles
{
    public class AddressProfile : Profile
    {
        public AddressProfile() 
        {
            CreateMap<AddressData, AddressModel>();
        }
    }
}
