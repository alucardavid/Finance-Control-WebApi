using System;
using System.Collections.Generic;

namespace Control_Finance_WebAPI.Infra.Data.Models
{
    public partial class Balance
    {
        public Balance()
        {
            FormOfPayments = new HashSet<FormOfPayment>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string UserCpf { get; set; }
        public virtual ICollection<FormOfPayment> FormOfPayments { get; set; }
    }
}
