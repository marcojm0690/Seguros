using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DAL.Models
{

    public class Insurance
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CategoryID { get; set; }

        public int? ClientID { get; set; }

        [Required]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public decimal Price { get; set; }

        public int RiskTypeID { get; set; }

        public bool IsActive { get; set; }

    }
}

