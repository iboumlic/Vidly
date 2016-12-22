using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Customer
    {
        public int customerID { get; set; }
        [Required]
        [StringLength(255)]
        public string customerName { get; set; }
        public string customerEmail { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeID { get; set; }
    }
}