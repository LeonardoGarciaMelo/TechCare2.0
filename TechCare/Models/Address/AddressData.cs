using System.ComponentModel.DataAnnotations;

namespace TechCare.Models.Address
{
    public class AddressData
    {
        [Required(ErrorMessage = "City space is empty, please write something")]
        public string City { get; set; } = null!;

        [Required(ErrorMessage = "State space is empty, please write something")]
        public string State { get; set; } = null!;

        [Required(ErrorMessage = "PostalCode space is empty, please write something")]
        [RegularExpression(@"^\d{8}$")]
        public string PostalCode { get; set; } = null!;

    }
}
