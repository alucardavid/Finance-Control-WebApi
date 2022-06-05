using System;
using System.Collections.Generic;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class ExpenseCategory
    {
        public ExpenseCategory()
        {
            MonthlyExpenses = new HashSet<MonthlyExpense>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime DtCreated { get; set; }

        public virtual ICollection<MonthlyExpense> MonthlyExpenses { get; set; }
    }
}
