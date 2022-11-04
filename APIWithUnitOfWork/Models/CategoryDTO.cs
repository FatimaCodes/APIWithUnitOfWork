using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APIWithUnitOfWork.Models
{
    public class CreateCategoryDTO
    {
        [Required]
        [StringLength(maximumLength: 50, ErrorMessage = "Category Name Is Too Long")]
        public string Name { get; set; }
    }
    public class CategoryDTO : CreateCategoryDTO
    {
        public int Id { get; set; }
        public IList<DoctorDTO> Doctors { get; set; }
    }
}
