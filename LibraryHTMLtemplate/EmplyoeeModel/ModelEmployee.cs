
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHTMLtemplate.EmplyoeeModel
{
    public class ModelEmployee
    {
        public ModelEmployee()
        {
            locationModels = new List<locationModel>();
        }
        public int id { get; set; }
        [Required]

        public string Name { get; set; }

        [Required (ErrorMessage = "AadharNumber is requirede.")]
        [RegularExpression(@"^([0-9]{12})$", ErrorMessage = "Please Enter Valid Adhaar Number.")]

        public long AadharNumber {get;set;}
        [Required]

        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Please Enter Valid Mobile Number.")]
        public long phonenumber { get; set; }

        [Required]
        public string location { get; set; }


        public List<locationModel> locationModels { get; set; }
    }
}
