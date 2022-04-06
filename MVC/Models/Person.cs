using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Models
{
    public class Person
    {
        [Required(ErrorMessage ="This Field Is Mandatory")]
        [Display(Name="Full Name")]
        public String name { get; set; } //fieldset/column inside our database 
        [Display(Name = "Age in years")]
        [Range(18,45)]
        public int age { get; set; }//these names must be similar to the names of fieldset in data source
        [DataType(DataType.MultilineText)]
        public string country { get; set; }
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
    }
}
