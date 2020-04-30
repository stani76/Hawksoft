using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HawkSoftContacts.Models
{
    public class Contact
    {
            [Key]
            public int ContactId{ get; set; }

            [ForeignKey("User")]
            public int UserRefId { get; set; }
            public User User { get; set; }

            [Required]
            public string Name{ get; set; }

            [Required]
            public string Email{ get; set; }

            [Required]
            public string Address { get; set; }
    }
}
