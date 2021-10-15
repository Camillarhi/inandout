using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace inandout.Models
{
    public class ExpenseCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ExpenseName { get; set; }

       // public string ImportantExpenses { get; set; }

        //public string AverageExpenses { get; set; }

       // public string IrrelevantExpenses { get; set; }
    }
}
