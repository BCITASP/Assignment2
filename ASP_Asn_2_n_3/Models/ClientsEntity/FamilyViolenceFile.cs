﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Asn_2_n_3.Models.ClientsEntity
{
    public class FamilyViolenceFile
    {
        public virtual int FamilyViolenceFileId { get; set; }
        public virtual string FileExists { get; set; }

        public virtual IEnumerable<Clients> Clients { get; set; }
    }
}