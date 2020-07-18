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
        public int InsuranceId { get; set; }


        public Insurance Insurance { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        public string Age { get; set; }


    }
}
