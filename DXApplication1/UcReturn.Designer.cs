﻿
namespace DXApplication1
{
    partial class UcReturn
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gridControl3 = new DevExpress.XtraGrid.GridControl();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPosDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountCampaign = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLineDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSalespersonCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVatRate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colInvoiceHeaderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDocumentTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrAccCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSuspended = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSalesViaInternet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPrinted = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStoreCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCreatedUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroupPayment = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupInvoiceLine = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlGroupInvoiceHeader = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colReturn = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInvoiceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInvoiceHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gridControl3);
            this.layoutControl1.Controls.Add(this.gridControl2);
            this.layoutControl1.Controls.Add(this.gridControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1106, 659);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gridControl3
            // 
            this.gridControl3.Location = new System.Drawing.Point(811, 364);
            this.gridControl3.MainView = this.gridView3;
            this.gridControl3.Name = "gridControl3";
            this.gridControl3.Size = new System.Drawing.Size(271, 271);
            this.gridControl3.TabIndex = 6;
            this.gridControl3.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // gridView3
            // 
            this.gridView3.GridControl = this.gridControl3;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // gridControl2
            // 
            this.gridControl2.Location = new System.Drawing.Point(24, 364);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl2.Size = new System.Drawing.Size(759, 271);
            this.gridControl2.TabIndex = 5;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceLineId,
            this.colProductCode,
            this.colQty,
            this.colPrice,
            this.colAmount,
            this.colPosDiscount,
            this.colDiscountCampaign,
            this.colNetAmount,
            this.colLineDescription,
            this.colSalespersonCode,
            this.colVatRate,
            this.colReturn});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colInvoiceLineId
            // 
            this.colInvoiceLineId.Caption = "Sətir Kodu";
            this.colInvoiceLineId.FieldName = "InvoiceLineId";
            this.colInvoiceLineId.Name = "colInvoiceLineId";
            // 
            // colProductCode
            // 
            this.colProductCode.Caption = "Məhsul Kodu";
            this.colProductCode.FieldName = "ProductCode";
            this.colProductCode.Name = "colProductCode";
            this.colProductCode.Visible = true;
            this.colProductCode.VisibleIndex = 0;
            // 
            // colQty
            // 
            this.colQty.Caption = "Say";
            this.colQty.FieldName = "Qty";
            this.colQty.Name = "colQty";
            this.colQty.Visible = true;
            this.colQty.VisibleIndex = 1;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Qiymət";
            this.colPrice.FieldName = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "Tutar";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colPosDiscount
            // 
            this.colPosDiscount.Caption = "Pos Endirimi";
            this.colPosDiscount.FieldName = "PosDiscount";
            this.colPosDiscount.Name = "colPosDiscount";
            this.colPosDiscount.Visible = true;
            this.colPosDiscount.VisibleIndex = 4;
            // 
            // colDiscountCampaign
            // 
            this.colDiscountCampaign.Caption = "Endirim Kampaniyası";
            this.colDiscountCampaign.FieldName = "DiscountCampaign";
            this.colDiscountCampaign.Name = "colDiscountCampaign";
            this.colDiscountCampaign.Visible = true;
            this.colDiscountCampaign.VisibleIndex = 5;
            // 
            // colNetAmount
            // 
            this.colNetAmount.Caption = "Net Tutar";
            this.colNetAmount.FieldName = "NetAmount";
            this.colNetAmount.Name = "colNetAmount";
            this.colNetAmount.Visible = true;
            this.colNetAmount.VisibleIndex = 6;
            // 
            // colLineDescription
            // 
            this.colLineDescription.Caption = "Sətir Açıqlaması";
            this.colLineDescription.FieldName = "LineDescription";
            this.colLineDescription.Name = "colLineDescription";
            this.colLineDescription.Visible = true;
            this.colLineDescription.VisibleIndex = 7;
            // 
            // colSalespersonCode
            // 
            this.colSalespersonCode.Caption = "Satıcı";
            this.colSalespersonCode.FieldName = "SalespersonCode";
            this.colSalespersonCode.Name = "colSalespersonCode";
            this.colSalespersonCode.Visible = true;
            this.colSalespersonCode.VisibleIndex = 8;
            // 
            // colVatRate
            // 
            this.colVatRate.Caption = "ƏDV";
            this.colVatRate.FieldName = "VatRate";
            this.colVatRate.Name = "colVatRate";
            this.colVatRate.Visible = true;
            this.colVatRate.VisibleIndex = 9;
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(24, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1058, 270);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colInvoiceHeaderID,
            this.colDocumentNumber,
            this.colDocumentDate,
            this.colDocumentTime,
            this.colCurrAccCode,
            this.colIsSuspended,
            this.colIsSalesViaInternet,
            this.colIsPrinted,
            this.colStoreCode,
            this.colCreatedUserName});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // colInvoiceHeaderID
            // 
            this.colInvoiceHeaderID.Caption = "gridColumn1";
            this.colInvoiceHeaderID.FieldName = "InvoiceHeaderID";
            this.colInvoiceHeaderID.Name = "colInvoiceHeaderID";
            // 
            // colDocumentNumber
            // 
            this.colDocumentNumber.Caption = "Faktura Nömrəsi";
            this.colDocumentNumber.FieldName = "DocumentNumber";
            this.colDocumentNumber.Name = "colDocumentNumber";
            this.colDocumentNumber.Visible = true;
            this.colDocumentNumber.VisibleIndex = 0;
            this.colDocumentNumber.Width = 88;
            // 
            // colDocumentDate
            // 
            this.colDocumentDate.Caption = "Faktura Tarixi";
            this.colDocumentDate.FieldName = "DocumentDate";
            this.colDocumentDate.Name = "colDocumentDate";
            this.colDocumentDate.Visible = true;
            this.colDocumentDate.VisibleIndex = 1;
            this.colDocumentDate.Width = 76;
            // 
            // colDocumentTime
            // 
            this.colDocumentTime.Caption = "Faktura Saatı";
            this.colDocumentTime.FieldName = "DocumentTime";
            this.colDocumentTime.Name = "colDocumentTime";
            this.colDocumentTime.Visible = true;
            this.colDocumentTime.VisibleIndex = 2;
            // 
            // colCurrAccCode
            // 
            this.colCurrAccCode.Caption = "Müştəri Kodu";
            this.colCurrAccCode.FieldName = "CurrAccCode";
            this.colCurrAccCode.Name = "colCurrAccCode";
            this.colCurrAccCode.Visible = true;
            this.colCurrAccCode.VisibleIndex = 3;
            // 
            // colIsSuspended
            // 
            this.colIsSuspended.Caption = "Səbətdədir";
            this.colIsSuspended.FieldName = "IsSuspended";
            this.colIsSuspended.Name = "colIsSuspended";
            this.colIsSuspended.Visible = true;
            this.colIsSuspended.VisibleIndex = 4;
            // 
            // colIsSalesViaInternet
            // 
            this.colIsSalesViaInternet.Caption = "İnternet Üzərindən Satış";
            this.colIsSalesViaInternet.FieldName = "IsSalesViaInternet";
            this.colIsSalesViaInternet.Name = "colIsSalesViaInternet";
            this.colIsSalesViaInternet.Visible = true;
            this.colIsSalesViaInternet.VisibleIndex = 5;
            this.colIsSalesViaInternet.Width = 127;
            // 
            // colIsPrinted
            // 
            this.colIsPrinted.Caption = "Çap Edilib";
            this.colIsPrinted.FieldName = "IsPrinted";
            this.colIsPrinted.Name = "colIsPrinted";
            this.colIsPrinted.Visible = true;
            this.colIsPrinted.VisibleIndex = 6;
            // 
            // colStoreCode
            // 
            this.colStoreCode.Caption = "Mağaza Kodu";
            this.colStoreCode.FieldName = "StoreCode";
            this.colStoreCode.Name = "colStoreCode";
            this.colStoreCode.Visible = true;
            this.colStoreCode.VisibleIndex = 7;
            // 
            // colCreatedUserName
            // 
            this.colCreatedUserName.Caption = "Fakturanı Yaradan İstifadəçi";
            this.colCreatedUserName.FieldName = "CreatedUserName";
            this.colCreatedUserName.Name = "colCreatedUserName";
            this.colCreatedUserName.Visible = true;
            this.colCreatedUserName.VisibleIndex = 8;
            this.colCreatedUserName.Width = 145;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroupPayment,
            this.layoutControlGroupInvoiceLine,
            this.layoutControlGroupInvoiceHeader});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1106, 659);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroupPayment
            // 
            this.layoutControlGroupPayment.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroupPayment.Location = new System.Drawing.Point(787, 319);
            this.layoutControlGroupPayment.Name = "layoutControlGroupPayment";
            this.layoutControlGroupPayment.Size = new System.Drawing.Size(299, 320);
            this.layoutControlGroupPayment.Text = "Ödəmə";
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl3;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(275, 275);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlGroupInvoiceLine
            // 
            this.layoutControlGroupInvoiceLine.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
            this.layoutControlGroupInvoiceLine.Location = new System.Drawing.Point(0, 319);
            this.layoutControlGroupInvoiceLine.Name = "layoutControlGroupInvoiceLine";
            this.layoutControlGroupInvoiceLine.Size = new System.Drawing.Size(787, 320);
            this.layoutControlGroupInvoiceLine.Text = "Məhsul";
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.gridControl2;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(763, 275);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlGroupInvoiceHeader
            // 
            this.layoutControlGroupInvoiceHeader.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
            this.layoutControlGroupInvoiceHeader.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroupInvoiceHeader.Name = "layoutControlGroupInvoiceHeader";
            this.layoutControlGroupInvoiceHeader.Size = new System.Drawing.Size(1086, 319);
            this.layoutControlGroupInvoiceHeader.Text = "Faktura";
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControl1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1062, 274);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // colReturn
            // 
            this.colReturn.Caption = "Geri Qaytar";
            this.colReturn.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colReturn.Name = "colReturn";
            this.colReturn.Visible = true;
            this.colReturn.VisibleIndex = 10;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // UcReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Name = "UcReturn";
            this.Size = new System.Drawing.Size(1106, 659);
            this.Load += new System.EventHandler(this.UcReturn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInvoiceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroupInvoiceHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceHeaderID;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentTime;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrAccCode;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSuspended;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSalesViaInternet;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPrinted;
        private DevExpress.XtraGrid.Columns.GridColumn colStoreCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedUserName;
        private DevExpress.XtraGrid.GridControl gridControl3;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupPayment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupInvoiceLine;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroupInvoiceHeader;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceLineId;
        private DevExpress.XtraGrid.Columns.GridColumn colProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn colQty;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colPosDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountCampaign;
        private DevExpress.XtraGrid.Columns.GridColumn colNetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colLineDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colSalespersonCode;
        private DevExpress.XtraGrid.Columns.GridColumn colVatRate;
        private DevExpress.XtraGrid.Columns.GridColumn colReturn;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
    }
}
