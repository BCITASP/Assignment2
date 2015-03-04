using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class VictimServicesAttendance
    {
        public virtual int VictimServicesAttendanceId { get; set; }

        [MaxLength(3)]
        public virtual string YesNoNA { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}