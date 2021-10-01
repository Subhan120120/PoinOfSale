﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PointOfSale.Models
{
    public partial class DcWarehouse
    {
        [Key]
        [StringLength(50)]
        public string WarehouseCode { get; set; }

        [Required]
        [StringLength(150)]
        public string WarehouseDesc { get; set; }
        public byte WarehouseTypeCode { get; set; }

        [Required]
        [StringLength(5)]
        public string OfficeCode { get; set; }

        [Required]
        [StringLength(50)]
        public string StoreCode { get; set; }
        public bool PermitNegativeStock { get; set; }
        public bool WarnNegativeStock { get; set; }
        public bool ControlStockLevel { get; set; }
        public bool WarnStockLevelRate { get; set; }
        public bool IsDefault { get; set; }
        public bool IsDisabled { get; set; }

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
        public Guid RowGuid { get; set; }
    }
}