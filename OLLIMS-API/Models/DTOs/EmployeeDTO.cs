using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public int AccessLevelId { get; set; }
        public AccessLevelDTO AccessLevel { get; set; }
    }
}
