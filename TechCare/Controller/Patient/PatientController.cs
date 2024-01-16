using Microsoft.AspNetCore.Mvc;
using TechCare.Data;
using TechCare.Models.Address;
using TechCare.Models.Patient;

namespace TechCare.Controller.Patient
{
    [ApiController]
    [Route("patients")]
    public class PatientController(PatientContext context) : ControllerBase
    {
        private PatientContext _context = context;

        [HttpGet]
        public IList<PatientModel> GetId()
        {
            return _context.Patients.ToList();
        }
    }
}
