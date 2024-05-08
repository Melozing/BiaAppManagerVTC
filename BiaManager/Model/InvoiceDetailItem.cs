using System;

namespace BiaManager.Model
{
    public class InvoiceDetailItem
    {
        public string IdInvoice { get; set; }
        public string TableID { get; set; }
        public DateTime InvoiceTime { get; set; }
        public int InvoiceStatus { get; set; }
        public string IdItem { get; set; }
        public int InvoiceTotalAmount { get; set; }
        public string ItemName { get; set; }
        public int ItemPrice { get; set; }
        public string IdTable { get; set; }
        public int TableStatus { get; set; }
        public string ItemCategoryName { get; set; }
    }
}
