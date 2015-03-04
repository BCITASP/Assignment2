using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class FiscalYear
    {
        public virtual int FiscalYearId { get; set; }

        [MaxLength(5)]
        public virtual string Years { get; set; }

        public virtual ICollection<Clients> Clients { get; set; }
    }
}