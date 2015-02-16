using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.ClientsEntity
{
    public class StatusOfFile
    {
        public virtual int StatusOfFileId { get; set; }
        public virtual string Status { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}