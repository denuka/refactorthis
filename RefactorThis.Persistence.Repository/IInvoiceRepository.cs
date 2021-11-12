#region System DLL's
using System;
using System.Collections.Generic;
using System.Text;
#endregion

#region Solution DLL's 
using RefactorThis.Domain.Entities;
#endregion
namespace RefactorThis.Persistence.Repository

{
    public interface IInvoiceRepository
    {
        InvoiceDTO GetInvoiceDTO(string reference);
    }
}
