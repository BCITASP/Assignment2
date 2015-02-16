using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public class Incident
    {
        public virtual int IncidentId { get; set; }
        public virtual string Type { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}