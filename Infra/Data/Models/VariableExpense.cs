using System;
using System.Collections.Generic;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class VariableExpense
    {
        public int Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Description { get; set; }
        public string? Type { get; set; }
        public decimal Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdateAt { get; set; }
        public int? FormOfPaymentId { get; set; }
        public string? UserCpf { get; set; }
        public string? Place { get; set; }

        public virtual FormOfPayment? FormOfPayment { get; set; }

    }
}
