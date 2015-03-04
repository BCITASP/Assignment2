using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Asn_2_n_3.Models
{
    [MetadataType(typeof(ReferredToCBVSMetaData))]
    public partial class ReferredToCBVS { }

    public class ReferredToCBVSMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int ReferredToCBVSId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(10, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoPVBSOnlyNA { get; set; }
    }
}