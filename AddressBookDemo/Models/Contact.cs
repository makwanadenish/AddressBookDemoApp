using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AddressBookDemo.Models
{
    public class Contact
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Phone(ErrorMessage = "Invalid Home Phone")]
        [Display(Name = "Home Phone")]
        public string HomePhone { get; set; }

        [Phone(ErrorMessage = "Invalid Mobile Number")]
        public string Mobile { get; set; }

        [Phone(ErrorMessage = "Invalid Work Phone")]
        [Display(Name = "Work Phone")]
        public string WorkPhone { get; set; }

        public string Address { get; set; }

        public string Notes { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }
    }
}