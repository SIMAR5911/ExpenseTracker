using System;

namespace ExpenseTracker.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }

        // Foreign key to ExpenseCategory
        public int ExpenseCategoryId { get; set; }

        // Navigation property to ExpenseCategory
        public ExpenseCategory ExpenseCategory { get; set; }
    }
}
