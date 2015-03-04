using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Asn_2_n_3.Models
{
    [MetadataType(typeof(VictimOfIncidentMetaData))]
    public partial class VictimOfIncident { }

    public class VictimOfIncidentMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int VictimOfIncidentId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(10, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string PrimaryOrSecondary { get; set; }
    }
}