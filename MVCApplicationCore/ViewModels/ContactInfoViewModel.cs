using MVCApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplicationCore.ViewModels
{
    public class ContactInfoViewModel
    {      
        [DisplayName("First Name")]       
        public string FirstName { get; set; }      
        [DisplayName("Last Name")]
        public string LastName { get; set; }       
        [DisplayName("Email Id")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$", ErrorMessage = "Invalid EmailId")]
        public string EmailAddress { get; set; }       
        [DisplayName("Phone Number")]        
        public string PhoneNumber { get; set; }
        [DisplayName("Your Message")]
        public string Message { get; set; }
        [DisplayName("Contact Purpose")]
        public ContactPurpose? ContactPurpose { get; set; }
    }
}
