using Microsoft.AspNetCore.Mvc;
using TechCare.Models.Address;
using TechCare.Models.Patient;

namespace TechCare.Controller.Patient
{
    [ApiController]
    [Route("patients")]
    public class PatientController : ControllerBase
    {
        [HttpGet]
        public IList<PatientModel> GetId()
        {
            var model = new AddressModel()
            {
                City = "aksdjasdkfj",
                State = "kadsjakdsfjasdk",
                PostalCode = "12345"
            };

            return new List<PatientModel>()
            {
                new PatientModel()
                {
                    Id = 1,
                    Name = "Test",
                    Age = 1,
                    Phone = "09847987",
                    Email = "Test",
                    Address = model,
                    Diagnosis = "guilhotina"
                },
                new PatientModel()
                {
                    Id = 2,
                    Name = "Test",
                    Age = 11111,
                    Phone = "09847987",
                    Email = "Test",
                    Address = model,
                    Diagnosis = "guilhotina"
                }
            };
        }
    }
}
