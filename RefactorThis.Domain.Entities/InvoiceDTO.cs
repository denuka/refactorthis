using System.Collections.Generic;


namespace RefactorThis.Domain.Entities
{
    /// <summary>
    /// Represent Invoice Data Transfer Object
    /// </summary>
    public class InvoiceDTO
    {
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public List<PaymentDTO> Payments { get; set; }
    }
}
