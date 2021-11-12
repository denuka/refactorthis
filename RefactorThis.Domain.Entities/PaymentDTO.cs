using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorThis.Domain.Entities
{
    public class PaymentDTO
    {
        public decimal Amount { get; set; }
        public string Reference { get; set; }

    }
}
