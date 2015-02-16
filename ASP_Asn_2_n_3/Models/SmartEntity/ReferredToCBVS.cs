using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.SmartEntity
{
    public class ReferredToCBVS
    {
        public virtual int ReferredToCBVSId { get; set; }
        public virtual string YesNoPVBSOnlyNA { get; set; }

        public virtual ICollection<Smart> Smart { get; set; }
    }
}