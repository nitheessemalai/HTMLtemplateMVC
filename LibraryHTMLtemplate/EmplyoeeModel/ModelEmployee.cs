
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
        [Required]

        public long AadharNumber {get;set;}
        [Required]

        public string Email { get; set; }
        [Required]

        public long phonenumber { get; set; }
        [Required]

        public string location { get; set; }
        [Required]


        public List<locationModel> locationModels { get; set; }
    }
}
