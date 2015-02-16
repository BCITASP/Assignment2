using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.ClientsEntity
{
    public class Age
    {
        public virtual int AgeId { get; set; }
        public virtual string Range { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}