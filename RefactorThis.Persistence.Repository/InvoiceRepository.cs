#region System DLL's
using System;
#endregion


#region Solution DLL's
using RefactorThis.Persistence.Entities;
using RefactorThis.Domain.Entities;
#endregion

namespace RefactorThis.Persistence.Repository
{
    public class InvoiceRepository :IInvoiceRepository
    {
        #region Private Properties
        private Invoice _invoice;
        #endregion

        #region Private Methods
        private Invoice GetInvoice(string reference)
        {
            return _invoice;
        }

        private InvoiceDTO EntityToDTO(Invoice entity)
        {
            InvoiceDTO dtoItem = new InvoiceDTO();
            if (entity != null)
            {
                dtoItem.Amount = entity.Amount;
                dtoItem.AmountPaid = entity.AmountPaid;
                //dtoItem.Payments
            }

            return dtoItem;

        }

        

        #endregion


        #region Public Methods
        public InvoiceDTO GetInvoiceDTO(string reference)

        {
            InvoiceDTO dtoItem = null;
            Invoice entity = this.GetInvoice(reference);
            dtoItem= EntityToDTO(entity);
            return dtoItem;
        }


        public void SaveInvoice(Invoice invoice)
        {
            //saves the invoice to the database
        }

        public void Add(Invoice invoice)
        {
            _invoice = invoice;
        }
        #endregion
    }
}
