using System.ComponentModel.DataAnnotations;

namespace APIWithUnitOfWork.Models
{
    public class CreateDoctorDTO
    {
        [Required]
        [StringLength(maximumLength: 20, ErrorMessage = "Doctor Name Is Too Long")]
        public string Name { get; set; }

        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Doctor Surname  Is Too Long")]
        public string Surname { get; set; }

        [Required]
        [StringLength(maximumLength: 250, ErrorMessage = "Doctor Address Is Too Long")]
        public string Address { get; set; }

        [Required]
        [Range(1, 5)]
        public double Rating { get; set; }

        [Required]
        public int CountryId { get; set; }
    }
    public class UpdateDoctorDTO : CreateDoctorDTO
    {

    }
    public class DoctorDTO : CreateDoctorDTO
    {
        public int Id { get; set; }
        public CountryDTO Country { get; set; }

    }
}
