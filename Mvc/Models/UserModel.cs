using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mvc.Models
{
    public class UserModel
    {
        [Key]
        public string Name { get; set; }
        public int PhoneNo { get; set; }
        public string Address { get; set; }
        public string CreatedAt { get; set; }
    }
}
