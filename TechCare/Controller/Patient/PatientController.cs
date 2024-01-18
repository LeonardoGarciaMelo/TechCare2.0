using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TechCare.Data;
using TechCare.Models.Patient;

namespace TechCare.Controller.Patient
{
    [ApiController]
    [Route("patients")]
    public class PatientController(PatientContext context, IMapper mapper) : ControllerBase
    {
        private PatientContext _context = context;
        private IMapper _mapper = mapper;

        [HttpGet]
        public IList<PatientModel> GetAll()
        {
            return _context.Patients.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult GetPatientById(long id) 
        {
            var patient = _context.Patients.FirstOrDefault(patient => patient.Id == id);
            return (patient == null) ? NotFound() : Ok(patient);
        }

        [HttpPost]
        public IActionResult Post([FromBody] PatientRegisterData data) 
        {
            PatientModel model = _mapper.Map<PatientModel>(data);

            _context.Patients.Add(model);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetPatientById), new { id = model.Id }, model);
        }
    }
}
