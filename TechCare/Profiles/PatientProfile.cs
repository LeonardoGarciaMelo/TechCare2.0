using AutoMapper;
using TechCare.Models.Patient;

namespace TechCare.Profiles
{
    public class PatientProfile : Profile
    {
        public PatientProfile() 
        {
            CreateMap<PatientRegisterData, PatientModel>();
        }
    }
}
