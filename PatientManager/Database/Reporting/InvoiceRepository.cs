using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatientManager.Database
{
    public static class InvoiceRepository
    {
        public static IQueryable<InvoiceViewModel> GetInvoices(int? invID)
        {
            var context = new PatientManagerEntities();
            var query = from inv in context.inv_line
                        where inv.invID == invID
                        select new InvoiceViewModel
                        {
                            invID = inv.invoice.invID,
                            itryName = inv.inventory.itryName,
                            ItryDesc = inv.inventory.itryDesc,
                            ItryQty = inv.itryQty,
                            LinePrice = (decimal)inv.linePrice,
                            invDate = inv.invoice.invDate,
                            Patient = inv.invoice.patient,
                            Doctor = inv.invoice.doctor
                        };
            return query;
        }
    }
}
