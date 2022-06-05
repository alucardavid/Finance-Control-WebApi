using System;
using System.Collections.Generic;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class MonthlyExpense
    {
        public int Id { get; set; }
        public string? Place { get; set; }
        public string? Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Value { get; set; }
        public int QtdPlots { get; set; }
        public int CurrentPlot { get; set; }
        public DateTime DueDate { get; set; }
        public string? Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public int? ExpenseCategoryId { get; set; }
        public int? FormOfPaymentId { get; set; }
        public string? UserCpf { get; set; }

        public virtual ExpenseCategory? ExpenseCategory { get; set; }
        public virtual FormOfPayment? FormOfPayment { get; set; }
        
    }
}
