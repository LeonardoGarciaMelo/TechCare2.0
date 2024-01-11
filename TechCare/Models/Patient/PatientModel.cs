using TechCare.Models.Address;

namespace TechCare.Models.Patient
{
    public class PatientModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public AddressModel Address { get; set; }
        public string Diagnosis { get; set; }


    }
}
