using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class EmployeeDTO
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Position { get; set; }
        public int? AccessLevelId { get; set; }
        public virtual ICollection<SopTrainee> SopTrainees { get; set; }
    }
}
