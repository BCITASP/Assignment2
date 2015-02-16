using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public class AbuserRelationship
    {
        public virtual int AbuserRelationshipId { get; set; }
        public virtual string Relationship { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}