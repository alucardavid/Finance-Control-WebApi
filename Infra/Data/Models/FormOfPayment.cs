using System;
using System.Collections.Generic;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class FormOfPayment
    {
        public FormOfPayment()
        {
            MonthlyExpenses = new HashSet<MonthlyExpense>();
            VariableExpenses = new HashSet<VariableExpense>();
        }

        public int Id { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? BalanceId { get; set; }

        public virtual Balance? Balance { get; set; }
        public virtual ICollection<MonthlyExpense> MonthlyExpenses { get; set; }
        public virtual ICollection<VariableExpense> VariableExpenses { get; set; }
    }
}
