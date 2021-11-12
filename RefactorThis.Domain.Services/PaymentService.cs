#region System DLL's
using System;
using System.Collections.Generic;
using System.Text;
#endregion

#region Solution DLL's
using RefactorThis.Domain.Entities;
using RefactorThis.Persistence.Repository;
#endregion

namespace RefactorThis.Domain.Services
{
    public class PaymentService:IPaymentService
    {
        #region Private Properties
        private readonly InvoiceRepository _invoiceRepository;
        #endregion

        #region Param Constructor 
        public PaymentService(InvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
        #endregion


        #region
        ////private PaymentDTO EntityToDTO(Payme)


        #endregion

        #region Public Methods 
        ////public PaymentDTO GetInvoiceD(PaymentDTO dtoItem)
        ////{
        ////    try
        ////    {
        ////        var inv = _invoiceRepository.GetInvoice(dtoItem.Reference);
        ////        return inv;
        ////    }
        ////    catch (Exception ex )
        ////    {

        ////        throw ex;
        ////    }
            
        ////}
        #endregion


    }
}
