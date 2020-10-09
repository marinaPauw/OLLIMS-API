using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OLLIMS_API.Models
{
    public partial class SopTraineeDTO
    {
        public int Id { get; set; }
        public int? Sopid { get; set; }
        public int? PersonId { get; set; }
        public string CertificateUrl { get; set; }
        public DateTime? TrainedAt { get; set; }
        public virtual Employee Person { get; set; }
        public virtual Sop Sop { get; set; }
    }
}
