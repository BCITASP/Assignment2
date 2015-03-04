using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class StatusOfFile
    {
        public virtual int StatusOfFileId { get; set; }

        [MaxLength(10)]
        public virtual string Status { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}