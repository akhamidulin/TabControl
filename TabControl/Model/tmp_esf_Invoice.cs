//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TabControl.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tmp_esf_Invoice
    {
        public Nullable<int> Id { get; set; }
        public int InvoiceNumber { get; set; }
        public System.DateTime Workmonth { get; set; }
        public string date { get; set; }
        public string invoiceType { get; set; }
        public Nullable<int> num { get; set; }
        public string operatorFullname { get; set; }
        public string relatedInvoiceDate { get; set; }
        public string relatedInvoiceNum { get; set; }
        public string relatedInvoiceRegistrationNumber { get; set; }
        public string signature { get; set; }
        public string signatureType { get; set; }
        public string consignee_address { get; set; }
        public string consignee_name { get; set; }
        public string consignee_tin { get; set; }
        public string consignor_address { get; set; }
        public string consignor_name { get; set; }
        public string consignor_tin { get; set; }
        public string customer_address { get; set; }
        public string customer_name { get; set; }
        public string customer_tin { get; set; }
        public string customer_status { get; set; }
        public string contractDate { get; set; }
        public string contractNum { get; set; }
        public string destination { get; set; }
        public string exerciseWay { get; set; }
        public string term { get; set; }
        public string totalExciseAmount { get; set; }
        public string totalNdsAmount { get; set; }
        public string totalPriceWithTax { get; set; }
        public string totalPriceWithoutTax { get; set; }
        public string totalTurnoverSize { get; set; }
        public string publicOffice_bik { get; set; }
        public string publicOffice_iik { get; set; }
        public string publicOffice_payPurpose { get; set; }
        public string publicOffice_productCode { get; set; }
        public Nullable<byte> SellerId { get; set; }
        public string deliveryDocDate { get; set; }
        public string deliveryDocNum { get; set; }
        public string turnoverDate { get; set; }
    
        public virtual tmp_esf_Seller tmp_esf_Seller { get; set; }
    }
}
