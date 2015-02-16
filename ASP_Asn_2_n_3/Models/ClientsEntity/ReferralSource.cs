using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.ClientsEntity
{
    public class ReferralSource
    {
        public virtual int ReferralSourceId { get; set; }
        public virtual string Source { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}