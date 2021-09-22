﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PointOfSale.Models
{
    public partial class TrInvoiceLine
    {
        [Key]
        public Guid InvoiceLineId { get; set; }
        public Guid InvoiceHeaderId { get; set; }
        public Guid? RelatedLineId { get; set; }

        [StringLength(30)]
        public string ProductCode { get; set; }
        public int? Qty { get; set; }
        public double? Price { get; set; }

        [Column(TypeName = "money")]
        public decimal? Amount { get; set; }

        [Column(TypeName = "money")]
        public decimal? PosDiscount { get; set; }

        [Column(TypeName = "money")]
        public decimal? DiscountCampaign { get; set; }

        [Column(TypeName = "money")]
        public decimal? NetAmount { get; set; }
        public float? VatRate { get; set; }
        public string LineDescription { get; set; }

        [StringLength(50)]
        public string SalespersonCode { get; set; }
        
        [StringLength(10)]
        public string CurrencyCode { get; set; }
        public double? ExchangeRate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedUserName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string LastUpdatedUserName { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime LastUpdatedDate { get; set; }

        public virtual TrInvoiceHeader InvoiceHeader { get; set; }
        public virtual DcProduct ProductCodeNavigation { get; set; }
    }
}
