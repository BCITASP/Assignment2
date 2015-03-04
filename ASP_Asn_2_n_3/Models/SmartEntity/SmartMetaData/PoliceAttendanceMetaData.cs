using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ASP_Asn_2_n_3.Models
{
    [MetadataType(typeof(PoliceAttendanceMetaData))]
    public partial class PoliceAttendance { }

    public class PoliceAttendanceMetaData
    {
        [HiddenInput(DisplayValue = false)]
        public virtual int PoliceAttendanceId { get; set; }

        [Required(ErrorMessage = "{0} is required.")]
        [MaxLength(3, ErrorMessage = "{0} cannot be longer than {1} characters.")]
        public virtual string YesNoNA { get; set; }
    }
}