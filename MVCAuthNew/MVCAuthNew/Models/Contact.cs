using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCAuthNew.Models
{
    public class Contact
    {
        public int ID { get; set; }
        /// <summary>
        /// this is the validation and requirement to allow the information to be accepted
        /// before it can be put into a database
        /// </summary>
        [Required(ErrorMessage = "Name is a required field")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "Must be between 2 and 60 chars")]
        public string Name { get; set; }

        [StringLength(20)]
        [RegularExpression(@"^[0-9\s]+$", ErrorMessage = "Only numbers are accepted")]
        public string Phone { get; set; }

        [StringLength(20)]
        [EmailAddress(ErrorMessage = "Email Address is not valid")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:yyyy/MM/dd}")]
        public DateTime Birthday { get; set; }

    }

    public class ContactDbContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
    }
}