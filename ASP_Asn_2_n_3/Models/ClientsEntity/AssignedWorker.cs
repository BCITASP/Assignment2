using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public class AssignedWorker
    {
        public virtual int AssignedWorkerId { get; set; }
        public virtual string Name {get; set;}

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}