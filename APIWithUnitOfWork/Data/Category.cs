using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIWithUnitOfWork.Data
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual IList<Doctor> Doctors { get; set; }
    }
}
