using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DAL.Models
{
    public class Client
    {
        [Key]
        public int ClientID { get; set; }
        
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
        
        public bool IsActive { get; set; }
    }
}
