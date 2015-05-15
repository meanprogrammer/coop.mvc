using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coop.Mvc.Entity
{
    [MetadataType(typeof(CollegeMeta))]
    public partial class College
    {
        
    }

    public class CollegeMeta
    {
        [Display(Name="College Name : ")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "This is required.")]
        public string CollegeName { get; set; }
    }
}
