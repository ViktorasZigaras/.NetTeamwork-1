using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Domain.Models
{
    public class Topup
    {
        public int Id { get; set; }
        [Required]
        [Range(0.01, 1000000.00)]
        public decimal Balance { get; set; }
    }
}
