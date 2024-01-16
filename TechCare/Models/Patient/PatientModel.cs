using System.ComponentModel.DataAnnotations;
using TechCare.Models.Address;
using TechCare.Models.Gender;

namespace TechCare.Models.Patient
{
    public class PatientModel
    {
        [Key]
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public EGenderModel Gender { get; set; }    
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressModel Address { get; set; }
        public string Diagnosis { get; set; }


    }
}
