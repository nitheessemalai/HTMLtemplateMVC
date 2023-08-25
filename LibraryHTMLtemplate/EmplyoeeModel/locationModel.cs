using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryHTMLtemplate.EmplyoeeModel
{
   public  class locationModel
    {
        public int locationid { get; set; }
        [Required]
        public string locationname { get; set; }
       
    }
}
