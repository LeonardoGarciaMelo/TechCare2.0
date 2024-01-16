using System.ComponentModel.DataAnnotations;

namespace TechCare.Models.Address
{
    public class AddressModel
    {
        [Key]
        public long Id { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}
