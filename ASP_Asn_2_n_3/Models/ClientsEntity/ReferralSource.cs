﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class ReferralSource
    {
        public virtual int ReferralSourceId { get; set; }

        [MaxLength(20)]
        public virtual string Source { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}