using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP_Asn_2_n_3.Models
{
    public partial class AbuserRelationship
    {
        public virtual int AbuserRelationshipId { get; set; }

        [MaxLength(50)]
        public virtual string Relationship { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}