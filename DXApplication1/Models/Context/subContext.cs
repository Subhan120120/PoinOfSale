﻿using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
//using System.Data.Entity;
//using System.Data.Entity.Core.Objects;
//using System.Data.Entity.Infrastructure;
//using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PointOfSale.Models
{
    public partial class subContext : DbContext
    {
        public subContext() { }

        public subContext(DbContextOptions<subContext> options)
            : base(options) { }

        public DbSet<DcCurrAcc> DcCurrAccs { get; set; }
        public DbSet<DcCurrAccType> DcCurrAccTypes { get; set; }
        public DbSet<DcOffice> DcOffices { get; set; }
        public DbSet<DcPaymentType> DcPaymentTypes { get; set; }
        public DbSet<DcProcess> DcProcesses { get; set; }
        public DbSet<DcProduct> DcProducts { get; set; }
        public DbSet<DcProductType> DcProductTypes { get; set; }
        public DbSet<DcStore> DcStores { get; set; }
        public DbSet<DcTerminal> DcTerminals { get; set; }
        public DbSet<DcWarehouse> DcWarehouses { get; set; }
        public DbSet<MigrationHistory> MigrationHistory { get; set; }
        public DbSet<Sysdiagrams> Sysdiagrams { get; set; }
        public DbSet<TrInvoiceHeader> TrInvoiceHeaders { get; set; }
        public DbSet<TrInvoiceLine> TrInvoiceLines { get; set; }
        public DbSet<TrPaymentHeader> TrPaymentHeaders { get; set; }
        public DbSet<TrPaymentLine> TrPaymentLines { get; set; }
        public DbSet<TrShipmentHeader> TrShipmentHeaders { get; set; }
        public DbSet<TrShipmentLine> TrShipmentLines { get; set; }
        //public DbSet<ReturnFromProc> returnFromProc { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Properties.Settings.Default.subConnString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DcCurrAcc>(entity =>
            {
                entity.HasIndex(e => e.CurrAccTypeCode)
                    .HasName("IX_CurrAccTypeCode");

                entity.Property(e => e.Address)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.BirthDate)
                    .HasDefaultValue(new DateTime(1901, 1, 1));

                entity.Property(e => e.BonusCardNum)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreditLimit)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DataLanguageCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.FatherName)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.FirstName)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.IdentityNum)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.IsVip)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LastName)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.OfficeCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.PhoneNum)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.TaxNum)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<DcCurrAcc>().HasData(
                new DcCurrAcc { CurrAccCode = "CA-1", FirstName = "Sübhan", LastName = "Hüseynzadə", PhoneNum = "0519678909", CurrAccTypeCode = 1 },
                new DcCurrAcc { CurrAccCode = "CA-2", FirstName = "Orxan", LastName = "Hüseynzadə", PhoneNum = "0773628800", CurrAccTypeCode = 2 });

            modelBuilder.Entity<DcCurrAccType>(entity =>
            {
                entity.Property(e => e.CurrAccTypeDescription)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcCurrAccType>().HasData(

                new DcCurrAccType { CurrAccTypeCode = 1, CurrAccTypeDescription = "Müştəri" },
                new DcCurrAccType { CurrAccTypeCode = 2, CurrAccTypeDescription = "Tədarikçi" },
                new DcCurrAccType { CurrAccTypeCode = 3, CurrAccTypeDescription = "Personal" }
                );

            modelBuilder.Entity<DcOffice>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.OfficeDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcOffice>().HasData(
                new DcOffice { OfficeCode = "OFS01", OfficeDesc = "Bakıxanov Ofisi" },
                new DcOffice { OfficeCode = "OFS02", OfficeDesc = "Elmlər Ofisi" });

            modelBuilder.Entity<DcPaymentType>(entity =>
            {
                entity.Property(e => e.PaymentTypeDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcPaymentType>().HasData(
                new DcPaymentType { PaymentTypeCode = 1, PaymentTypeDesc = "Nağd" },
                new DcPaymentType { PaymentTypeCode = 2, PaymentTypeDesc = "Visa" });

            modelBuilder.Entity<DcProcess>(entity =>
            {
                entity.Property(e => e.ProcessDescription).HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcProduct>(entity =>
            {
                entity.HasIndex(e => e.ProductTypeCode)
                    .HasName("IX_ProductTypeCode");

                entity.Property(e => e.Barcode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ProductDescription)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.RetailPrice)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PurchasePrice)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.WholesalePrice)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosDiscount)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PromotionCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.PromotionCode2)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.UsePos)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.UseInternet)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.TaxRate)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsDisabled)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsBlocked)
                    .HasDefaultValueSql("0");

            });

            modelBuilder.Entity<DcProduct>().HasData(
                new DcProduct { ProductCode = "test01", ProductDescription = "Papaq", Barcode = "123456", RetailPrice = 4.5 },
                new DcProduct { ProductCode = "test02", ProductDescription = "Salvar", Barcode = "2000000000013", RetailPrice = 2.5 }
            );

            modelBuilder.Entity<DcProductType>(entity =>
            {
                entity.Property(e => e.ProductTypeDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcProductType>().HasData(
                new DcProductType { ProductTypeCode = 1, ProductTypeDesc = "Məhsul" });

            modelBuilder.Entity<DcStore>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.StoreDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcStore>().HasData(
                new DcStore { StoreCode = "mgz-01", StoreDesc = "Bakıxanov" },
                new DcStore { StoreCode = "mgz-02", StoreDesc = "Elmlər" });

            modelBuilder.Entity<DcTerminal>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.TerminalDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcWarehouse>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.OfficeCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.StoreCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.WarehouseDesc)
                    .HasDefaultValueSql("space(0)");
            });

            modelBuilder.Entity<DcWarehouse>().HasData(
                new DcWarehouse { WarehouseCode = "depo-01", WarehouseDesc = "Bakıxanov deposu" },
                new DcWarehouse { WarehouseCode = "depo-02", WarehouseDesc = "Elmlər deposu" });

            modelBuilder.Entity<MigrationHistory>(entity =>
            {
                entity.HasKey(e => new { e.MigrationId, e.ContextKey })
                    .HasName("PK_dbo.__MigrationHistory");

                entity.ToTable("__MigrationHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ContextKey).HasMaxLength(300);

                entity.Property(e => e.Model).IsRequired();

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Sysdiagrams>(entity =>
            {
                entity.HasKey(e => e.DiagramId)
                    .HasName("PK_dbo.sysdiagrams");

                entity.ToTable("sysdiagrams");

                entity.Property(e => e.DiagramId).HasColumnName("diagram_id");

                entity.Property(e => e.Definition).HasColumnName("definition");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(128);

                entity.Property(e => e.PrincipalId).HasColumnName("principal_id");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<TrInvoiceHeader>(entity =>
            {
                entity.HasIndex(e => e.CurrAccCode)
                    .HasName("IX_CurrAccCode");

                entity.Property(e => e.InvoiceHeaderId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomsDocumentNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.Description)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.DocumentDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DocumentNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.IsReturn)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.DocumentTime)
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.OfficeCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.OperationDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.OperationTime)
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.PosTerminalId)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ProcessCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.StoreCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.WarehouseCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.IsSuspended)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsCompleted)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsPrinted)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.IsLocked)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.FiscalPrintedState)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.IsSalesViaInternet)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<TrInvoiceLine>(entity =>
            {
                entity.Property(e => e.InvoiceLineId)
                    .ValueGeneratedNever();

                entity.HasIndex(e => e.InvoiceHeaderId)
                    .HasName("IX_InvoiceHeaderId");

                entity.HasIndex(e => e.ProductCode)
                    .HasName("IX_ProductCode");

                entity.Property(e => e.Qty)
                    .HasDefaultValueSql("1");

                entity.Property(e => e.CurrencyCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.DiscountCampaign)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Amount)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.NetAmount)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.Price)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.VatRate)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExchangeRate)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.PosDiscount)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.LineDescription)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.SalespersonCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<TrPaymentHeader>(entity =>
            {
                entity.Property(e => e.CurrAccCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CurrencyCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.Description)
                        .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.DocumentDate)
                    .HasDefaultValue(new DateTime(1901, 1, 1));

                entity.Property(e => e.DocumentNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.DocumentTime)
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.InvoiceHeaderId)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.InvoiceNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.OfficeCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.PosterminalId)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.StoreCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<TrPaymentLine>(entity =>
            {
                entity.Property(e => e.CurrencyCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.LineDescription)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.Payment)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.ExchangeRate)
                    .HasDefaultValueSql("0");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<TrShipmentHeader>(entity =>
            {
                entity.Property(e => e.CustomsDocumentNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.Description)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.OfficeCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.OperationDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.OperationTime)
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.ProcessCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ShippingDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ShippingNumber)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ShippingPostalAddressId)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ShippingTime)
                    .HasDefaultValueSql("'00:00:00'");

                entity.Property(e => e.StoreCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ToWarehouseCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.TransferApprovedDate)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.WarehouseCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            modelBuilder.Entity<TrShipmentLine>(entity =>
            {
                entity.HasIndex(e => e.ShipmentHeaderId)
                    .HasName("IX_ShipmentHeaderID");

                entity.Property(e => e.ColorCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CurrencyCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.LineDescription)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.Price)
                    .HasDefaultValue(0);

                entity.Property(e => e.ProductCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.ProductDimensionCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.SalespersonCode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.UsedBarcode)
                    .HasDefaultValueSql("space(0)");

                entity.Property(e => e.CreatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");

                entity.Property(e => e.LastUpdatedDate)
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.LastUpdatedUserName)
                    .HasDefaultValueSql(@"substring(suser_name(),patindex('%\%',suser_name())+(1),(20))");
            });

            //modelBuilder.Entity<ReturnFromProc>().HasNoKey().ToView(null);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
