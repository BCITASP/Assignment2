using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASP_Asn_2_n_3.Models
{
    public partial class Age
    {
        public virtual int AgeId { get; set; }

        [MaxLength(20)]
        public virtual string Range { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}