using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models
{
    public partial class FamilyViolenceFile
    {
        public virtual int FamilyViolenceFileId { get; set; }

        [MaxLength(3)]
        public virtual string FileExists { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}