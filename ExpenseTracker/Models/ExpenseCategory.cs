using System;
using System.Collections.Generic;

namespace ExpenseTracker.Models
{
    public class ExpenseCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }

        // Navigation property for related expenses
        public ICollection<Expense> Expenses { get; set; }
    }
}
