using Microsoft.EntityFrameworkCore;
using TechCare.Models.Patient;


namespace TechCare.Data
{
    public class PatientContext(DbContextOptions<PatientContext> options) : DbContext(options) 
    {
        public DbSet<PatientModel> Patients { get; set; }
    }
}
