using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("My Expenditures")]
        [Required]
        public string Expenditure { get; set; }
        [Required]
        [Range(1, int.MaxValue, ErrorMessage="Amount must be greater than 0!")]
        public int Amount { get; set; }
    }
}
