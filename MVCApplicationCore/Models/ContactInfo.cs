using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplicationCore.Models
{
    public class ContactInfo
    {
        public int Id { get; set; }       
        public string FirstName { get; set; }      
        public string LastName { get; set; }       
        //[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
        public string EmailAddress { get; set; }
        //[RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Mobile Number.")]
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
        public ContactPurpose? ContactPurpose { get; set; }
    }
    public enum ContactPurpose
    {       
        Advertising = 1,
        SocialMedia = 2
    }
}
