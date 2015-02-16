using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.ClientsEntity
{
    public class RiskLevel
    {
        public virtual int RiskLevelId { get; set; }
        public virtual string Level { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}