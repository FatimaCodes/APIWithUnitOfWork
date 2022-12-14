using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIWithUnitOfWork.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Country Name Is Too Long")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 2, ErrorMessage = "Short Country Name Is Too Long")]
        public string ShortName { get; set; }

        public int FullName { get; set; }
    }
    public class UpdateCountryDTO : CreateCountryDTO
    {
        public IList<CreateDoctorDTO> Doctors { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int Id { get; set; }
        public IList<DoctorDTO> Doctors { get; set; }
    }
}
