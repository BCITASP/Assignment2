using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class ReferredToCBVS
    {
        public virtual int ReferredToCBVSId { get; set; }

        [MaxLength(10)]
        public virtual string YesNoPVBSOnlyNA { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}