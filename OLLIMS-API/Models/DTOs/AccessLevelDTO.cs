using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class AccessLevelDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
