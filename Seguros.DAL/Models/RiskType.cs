using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros.DAL.Models
{
    public class RiskType
    {
        [Key]
        public int RiskTypeId { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
