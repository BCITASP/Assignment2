using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class ReferringHospital
    {
        public virtual int ReferringHospitalId { get; set; }

        [MaxLength(50)]
        public virtual string HospitalName { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}