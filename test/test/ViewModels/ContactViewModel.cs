using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace test.ViewModels
{
    public class ContactViewModel
    {
        [Required]
         public string Name {get; set;}
         [Required]
         public string Email { get; set; }
        [Required]
        public string Subject {get; set;}
        [Required]
        public string Message {get; set;}

    }
}
