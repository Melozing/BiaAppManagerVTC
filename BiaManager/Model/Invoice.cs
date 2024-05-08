using System;

public class Invoice
{
    public string IdInvoice { get; set; }
    public string TableID { get; set; }
    public DateTime InvoiceTime { get; set; }
    public int InvoiceStatus { get; set; }
    public int InvoiceTotalAmount { get; set; }
    public string TableNumber { get; set; }
}