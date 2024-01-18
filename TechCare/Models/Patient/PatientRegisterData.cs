using System.ComponentModel.DataAnnotations;
using TechCare.Models.Address;
using TechCare.Models.Gender;

namespace TechCare.Models.Patient
{
    public class PatientRegisterData
    {
        [Required(ErrorMessage = "Please, name space is empty, write something")]
        [RegularExpression(@"^.+$")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Please, age space is empty, write something")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Please, gender space is empty, write something")]
        public EGenderModel Gender { get; set; }

        [Required(ErrorMessage = "Please, phone space is empty, write something")]
        public string Phone { get; set; } = null!;

        [Required(ErrorMessage = "Please, email space is empty, write something")]
        [EmailAddress(ErrorMessage = "Email space pattern is wrong, please write a valid email")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Please, address space is empty, write something")]
        public AddressData Address { get; set; } = null!;

        [Required(ErrorMessage = "Please, diagnosis space is empty, write something")]
        public string Diagnosis { get; set; } = null!;


    }
}
