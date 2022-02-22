﻿
using System;

namespace PointOfSale
{
    partial class FormInvoice
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
            this.components = new System.ComponentModel.Container();
            this.RibbonControl_Root = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bBI_Save = new DevExpress.XtraBars.BarButtonItem();
            this.bBI_SaveAndClose = new DevExpress.XtraBars.BarButtonItem();
            this.bBI_SaveAndNew = new DevExpress.XtraBars.BarButtonItem();
            this.bBI_Reset = new DevExpress.XtraBars.BarButtonItem();
            this.bBI_Delete = new DevExpress.XtraBars.BarButtonItem();
            this.bBI_Close = new DevExpress.XtraBars.BarButtonItem();
            this.RibbonPage_Invoice = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.RibbonPageGroup_Invoice = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.trInvoiceLinesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.gC_InvoiceLine = new DevExpress.XtraGrid.GridControl();
            this.gV_InvoiceLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_InvoiceLineId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_InvoiceHeaderId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_ProductCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repoBtnEdit_ProductCode = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.col_Qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_PosDiscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NetAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_LineDesc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IsReturnCheckEdit = new DevExpress.XtraEditors.CheckEdit();
            this.trInvoiceHeadersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DocumentDateDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.DocumentTimeTimeSpanEdit = new DevExpress.XtraEditors.TimeSpanEdit();
            this.CustomsDocumentNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.btnEdit_DocNum = new DevExpress.XtraEditors.ButtonEdit();
            this.memoEdit_Desc = new DevExpress.XtraEditors.MemoEdit();
            this.btnEdit_CurrAccCode = new DevExpress.XtraEditors.ButtonEdit();
            this.lUE_OfficeCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lUE_StoreCode = new DevExpress.XtraEditors.LookUpEdit();
            this.lUE_WarehouseCode = new DevExpress.XtraEditors.LookUpEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIsReturn = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocumentDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocumentTime = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDocumentNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCurrAccCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForOfficeCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomsDocumentNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForStoreCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForWarehouseCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl_Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trInvoiceLinesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_InvoiceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_InvoiceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnEdit_ProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsReturnCheckEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trInvoiceHeadersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentDateDateEdit.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentDateDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTimeTimeSpanEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomsDocumentNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_DocNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Desc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_CurrAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_OfficeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_StoreCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_WarehouseCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrAccCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOfficeCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomsDocumentNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWarehouseCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RibbonControl_Root
            // 
            this.RibbonControl_Root.ExpandCollapseItem.Id = 0;
            this.RibbonControl_Root.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.RibbonControl_Root.ExpandCollapseItem,
            this.RibbonControl_Root.SearchEditItem,
            this.bBI_Save,
            this.bBI_SaveAndClose,
            this.bBI_SaveAndNew,
            this.bBI_Reset,
            this.bBI_Delete,
            this.bBI_Close});
            this.RibbonControl_Root.Location = new System.Drawing.Point(0, 0);
            this.RibbonControl_Root.MaxItemId = 10;
            this.RibbonControl_Root.Name = "RibbonControl_Root";
            this.RibbonControl_Root.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.RibbonPage_Invoice});
            this.RibbonControl_Root.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
            this.RibbonControl_Root.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.RibbonControl_Root.Size = new System.Drawing.Size(1147, 158);
            this.RibbonControl_Root.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // bBI_Save
            // 
            this.bBI_Save.Caption = "Save";
            this.bBI_Save.Id = 2;
            this.bBI_Save.ImageOptions.ImageUri.Uri = "Save";
            this.bBI_Save.Name = "bBI_Save";
            // 
            // bBI_SaveAndClose
            // 
            this.bBI_SaveAndClose.Caption = "Save And Close";
            this.bBI_SaveAndClose.Id = 3;
            this.bBI_SaveAndClose.ImageOptions.ImageUri.Uri = "SaveAndClose";
            this.bBI_SaveAndClose.Name = "bBI_SaveAndClose";
            // 
            // bBI_SaveAndNew
            // 
            this.bBI_SaveAndNew.Caption = "Save And New";
            this.bBI_SaveAndNew.Id = 4;
            this.bBI_SaveAndNew.ImageOptions.ImageUri.Uri = "SaveAndNew";
            this.bBI_SaveAndNew.Name = "bBI_SaveAndNew";
            // 
            // bBI_Reset
            // 
            this.bBI_Reset.Caption = "Reset Changes";
            this.bBI_Reset.Id = 5;
            this.bBI_Reset.ImageOptions.ImageUri.Uri = "Reset";
            this.bBI_Reset.Name = "bBI_Reset";
            // 
            // bBI_Delete
            // 
            this.bBI_Delete.Caption = "Delete";
            this.bBI_Delete.Id = 6;
            this.bBI_Delete.ImageOptions.ImageUri.Uri = "Delete";
            this.bBI_Delete.Name = "bBI_Delete";
            // 
            // bBI_Close
            // 
            this.bBI_Close.Caption = "Close";
            this.bBI_Close.Id = 7;
            this.bBI_Close.ImageOptions.ImageUri.Uri = "Close";
            this.bBI_Close.Name = "bBI_Close";
            // 
            // RibbonPage_Invoice
            // 
            this.RibbonPage_Invoice.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.RibbonPageGroup_Invoice});
            this.RibbonPage_Invoice.MergeOrder = 15;
            this.RibbonPage_Invoice.Name = "RibbonPage_Invoice";
            this.RibbonPage_Invoice.Text = "Faktura";
            // 
            // RibbonPageGroup_Invoice
            // 
            this.RibbonPageGroup_Invoice.AllowTextClipping = false;
            this.RibbonPageGroup_Invoice.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.RibbonPageGroup_Invoice.Name = "RibbonPageGroup_Invoice";
            this.RibbonPageGroup_Invoice.Text = "Tasks";
            // 
            // trInvoiceLinesBindingSource
            // 
            this.trInvoiceLinesBindingSource.DataSource = typeof(PointOfSale.Models.TrInvoiceLine);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.simpleButton1);
            this.dataLayoutControl1.Controls.Add(this.gC_InvoiceLine);
            this.dataLayoutControl1.Controls.Add(this.IsReturnCheckEdit);
            this.dataLayoutControl1.Controls.Add(this.DocumentDateDateEdit);
            this.dataLayoutControl1.Controls.Add(this.DocumentTimeTimeSpanEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomsDocumentNumberTextEdit);
            this.dataLayoutControl1.Controls.Add(this.btnEdit_DocNum);
            this.dataLayoutControl1.Controls.Add(this.memoEdit_Desc);
            this.dataLayoutControl1.Controls.Add(this.btnEdit_CurrAccCode);
            this.dataLayoutControl1.Controls.Add(this.lUE_OfficeCode);
            this.dataLayoutControl1.Controls.Add(this.lUE_StoreCode);
            this.dataLayoutControl1.Controls.Add(this.lUE_WarehouseCode);
            this.dataLayoutControl1.DataSource = this.trInvoiceHeadersBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(0, 158);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1270, 352, 650, 400);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(1147, 486);
            this.dataLayoutControl1.TabIndex = 4;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 452);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(1123, 22);
            this.simpleButton1.StyleController = this.dataLayoutControl1;
            this.simpleButton1.TabIndex = 15;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // gC_InvoiceLine
            // 
            this.gC_InvoiceLine.DataSource = this.trInvoiceLinesBindingSource;
            this.gC_InvoiceLine.Location = new System.Drawing.Point(12, 132);
            this.gC_InvoiceLine.MainView = this.gV_InvoiceLine;
            this.gC_InvoiceLine.MenuManager = this.RibbonControl_Root;
            this.gC_InvoiceLine.Name = "gC_InvoiceLine";
            this.gC_InvoiceLine.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repoBtnEdit_ProductCode});
            this.gC_InvoiceLine.Size = new System.Drawing.Size(1123, 316);
            this.gC_InvoiceLine.TabIndex = 13;
            this.gC_InvoiceLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_InvoiceLine});
            // 
            // gV_InvoiceLine
            // 
            this.gV_InvoiceLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_InvoiceLineId,
            this.col_InvoiceHeaderId,
            this.col_ProductCode,
            this.col_Qty,
            this.col_Price,
            this.col_Amount,
            this.col_PosDiscount,
            this.col_NetAmount,
            this.col_LineDesc});
            this.gV_InvoiceLine.GridControl = this.gC_InvoiceLine;
            this.gV_InvoiceLine.Name = "gV_InvoiceLine";
            this.gV_InvoiceLine.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
            this.gV_InvoiceLine.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gV_InvoiceLine.OptionsView.ShowFooter = true;
            this.gV_InvoiceLine.OptionsView.ShowGroupPanel = false;
            this.gV_InvoiceLine.InitNewRow += new DevExpress.XtraGrid.Views.Grid.InitNewRowEventHandler(this.gV_InvoiceLine_InitNewRow);
            this.gV_InvoiceLine.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gV_InvoiceLine_CellValueChanging);
            this.gV_InvoiceLine.RowDeleted += new DevExpress.Data.RowDeletedEventHandler(this.gV_InvoiceLine_RowDeleted);
            this.gV_InvoiceLine.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gV_InvoiceLine_RowUpdated);
            this.gV_InvoiceLine.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gV_InvoiceLine_KeyDown);
            // 
            // col_InvoiceLineId
            // 
            this.col_InvoiceLineId.Caption = "InvoiceLineId";
            this.col_InvoiceLineId.FieldName = "InvoiceLineId";
            this.col_InvoiceLineId.Name = "col_InvoiceLineId";
            this.col_InvoiceLineId.OptionsEditForm.StartNewRow = true;
            this.col_InvoiceLineId.Visible = true;
            this.col_InvoiceLineId.VisibleIndex = 7;
            // 
            // col_InvoiceHeaderId
            // 
            this.col_InvoiceHeaderId.Caption = "InvoiceHeaderId";
            this.col_InvoiceHeaderId.FieldName = "InvoiceHeaderId";
            this.col_InvoiceHeaderId.Name = "col_InvoiceHeaderId";
            this.col_InvoiceHeaderId.Visible = true;
            this.col_InvoiceHeaderId.VisibleIndex = 8;
            // 
            // col_ProductCode
            // 
            this.col_ProductCode.Caption = "Məhsul";
            this.col_ProductCode.ColumnEdit = this.repoBtnEdit_ProductCode;
            this.col_ProductCode.FieldName = "ProductCode";
            this.col_ProductCode.Name = "col_ProductCode";
            this.col_ProductCode.Visible = true;
            this.col_ProductCode.VisibleIndex = 0;
            // 
            // repoBtnEdit_ProductCode
            // 
            this.repoBtnEdit_ProductCode.AutoHeight = false;
            this.repoBtnEdit_ProductCode.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repoBtnEdit_ProductCode.Name = "repoBtnEdit_ProductCode";
            this.repoBtnEdit_ProductCode.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repoBtnEdit_ProductCode_ButtonPressed);
            // 
            // col_Qty
            // 
            this.col_Qty.Caption = "Say";
            this.col_Qty.FieldName = "Qty";
            this.col_Qty.Name = "col_Qty";
            this.col_Qty.Visible = true;
            this.col_Qty.VisibleIndex = 1;
            // 
            // col_Price
            // 
            this.col_Price.Caption = "Qiymət";
            this.col_Price.FieldName = "Price";
            this.col_Price.Name = "col_Price";
            this.col_Price.Visible = true;
            this.col_Price.VisibleIndex = 2;
            // 
            // col_Amount
            // 
            this.col_Amount.Caption = "Tutar";
            this.col_Amount.FieldName = "Amount";
            this.col_Amount.Name = "col_Amount";
            this.col_Amount.OptionsColumn.AllowEdit = false;
            this.col_Amount.Visible = true;
            this.col_Amount.VisibleIndex = 3;
            // 
            // col_PosDiscount
            // 
            this.col_PosDiscount.Caption = "Endirim";
            this.col_PosDiscount.FieldName = "PosDiscount";
            this.col_PosDiscount.Name = "col_PosDiscount";
            this.col_PosDiscount.Visible = true;
            this.col_PosDiscount.VisibleIndex = 4;
            // 
            // col_NetAmount
            // 
            this.col_NetAmount.Caption = "Net Tutar";
            this.col_NetAmount.FieldName = "NetAmount";
            this.col_NetAmount.Name = "col_NetAmount";
            this.col_NetAmount.Visible = true;
            this.col_NetAmount.VisibleIndex = 5;
            // 
            // col_LineDesc
            // 
            this.col_LineDesc.Caption = "Qeyd";
            this.col_LineDesc.FieldName = "LineDescription";
            this.col_LineDesc.Name = "col_LineDesc";
            this.col_LineDesc.Visible = true;
            this.col_LineDesc.VisibleIndex = 6;
            // 
            // IsReturnCheckEdit
            // 
            this.IsReturnCheckEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "IsReturn", true));
            this.IsReturnCheckEdit.Location = new System.Drawing.Point(12, 36);
            this.IsReturnCheckEdit.MenuManager = this.RibbonControl_Root;
            this.IsReturnCheckEdit.Name = "IsReturnCheckEdit";
            this.IsReturnCheckEdit.Properties.Caption = "Qaytarılmadır";
            this.IsReturnCheckEdit.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.IsReturnCheckEdit.Size = new System.Drawing.Size(559, 20);
            this.IsReturnCheckEdit.StyleController = this.dataLayoutControl1;
            this.IsReturnCheckEdit.TabIndex = 4;
            // 
            // trInvoiceHeadersBindingSource
            // 
            this.trInvoiceHeadersBindingSource.DataSource = typeof(PointOfSale.Models.TrInvoiceHeader);
            // 
            // DocumentDateDateEdit
            // 
            this.DocumentDateDateEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "DocumentDate", true));
            this.DocumentDateDateEdit.EditValue = null;
            this.DocumentDateDateEdit.Location = new System.Drawing.Point(122, 84);
            this.DocumentDateDateEdit.MenuManager = this.RibbonControl_Root;
            this.DocumentDateDateEdit.Name = "DocumentDateDateEdit";
            this.DocumentDateDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocumentDateDateEdit.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocumentDateDateEdit.Size = new System.Drawing.Size(449, 20);
            this.DocumentDateDateEdit.StyleController = this.dataLayoutControl1;
            this.DocumentDateDateEdit.TabIndex = 5;
            // 
            // DocumentTimeTimeSpanEdit
            // 
            this.DocumentTimeTimeSpanEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "DocumentTime", true));
            this.DocumentTimeTimeSpanEdit.EditValue = System.TimeSpan.Parse("00:00:00");
            this.DocumentTimeTimeSpanEdit.Location = new System.Drawing.Point(122, 108);
            this.DocumentTimeTimeSpanEdit.MenuManager = this.RibbonControl_Root;
            this.DocumentTimeTimeSpanEdit.Name = "DocumentTimeTimeSpanEdit";
            this.DocumentTimeTimeSpanEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DocumentTimeTimeSpanEdit.Size = new System.Drawing.Size(449, 20);
            this.DocumentTimeTimeSpanEdit.StyleController = this.dataLayoutControl1;
            this.DocumentTimeTimeSpanEdit.TabIndex = 6;
            // 
            // CustomsDocumentNumberTextEdit
            // 
            this.CustomsDocumentNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "CustomsDocumentNumber", true));
            this.CustomsDocumentNumberTextEdit.Location = new System.Drawing.Point(122, 60);
            this.CustomsDocumentNumberTextEdit.MenuManager = this.RibbonControl_Root;
            this.CustomsDocumentNumberTextEdit.Name = "CustomsDocumentNumberTextEdit";
            this.CustomsDocumentNumberTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.CustomsDocumentNumberTextEdit.Size = new System.Drawing.Size(449, 20);
            this.CustomsDocumentNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomsDocumentNumberTextEdit.TabIndex = 12;
            // 
            // btnEdit_DocNum
            // 
            this.btnEdit_DocNum.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "DocumentNumber", true));
            this.btnEdit_DocNum.Location = new System.Drawing.Point(122, 12);
            this.btnEdit_DocNum.MenuManager = this.RibbonControl_Root;
            this.btnEdit_DocNum.Name = "btnEdit_DocNum";
            this.btnEdit_DocNum.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.btnEdit_DocNum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdit_DocNum.Size = new System.Drawing.Size(449, 20);
            this.btnEdit_DocNum.StyleController = this.dataLayoutControl1;
            this.btnEdit_DocNum.TabIndex = 14;
            this.btnEdit_DocNum.ButtonPressed += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_DocNum_ButtonPressed);
            // 
            // memoEdit_Desc
            // 
            this.memoEdit_Desc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "Description", true));
            this.memoEdit_Desc.Location = new System.Drawing.Point(685, 108);
            this.memoEdit_Desc.MenuManager = this.RibbonControl_Root;
            this.memoEdit_Desc.Name = "memoEdit_Desc";
            this.memoEdit_Desc.Size = new System.Drawing.Size(450, 20);
            this.memoEdit_Desc.StyleController = this.dataLayoutControl1;
            this.memoEdit_Desc.TabIndex = 7;
            // 
            // btnEdit_CurrAccCode
            // 
            this.btnEdit_CurrAccCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "CurrAccCode", true));
            this.btnEdit_CurrAccCode.Location = new System.Drawing.Point(685, 12);
            this.btnEdit_CurrAccCode.MenuManager = this.RibbonControl_Root;
            this.btnEdit_CurrAccCode.Name = "btnEdit_CurrAccCode";
            this.btnEdit_CurrAccCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.btnEdit_CurrAccCode.Size = new System.Drawing.Size(450, 20);
            this.btnEdit_CurrAccCode.StyleController = this.dataLayoutControl1;
            this.btnEdit_CurrAccCode.TabIndex = 8;
            this.btnEdit_CurrAccCode.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnEdit_CurrAccCode_ButtonClick);
            // 
            // lUE_OfficeCode
            // 
            this.lUE_OfficeCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "OfficeCode", true));
            this.lUE_OfficeCode.Location = new System.Drawing.Point(685, 36);
            this.lUE_OfficeCode.MenuManager = this.RibbonControl_Root;
            this.lUE_OfficeCode.Name = "lUE_OfficeCode";
            this.lUE_OfficeCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lUE_OfficeCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUE_OfficeCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeCode", "Ofis kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OfficeDesc", "Ofis Adı")});
            this.lUE_OfficeCode.Properties.DisplayMember = "OfficeDesc";
            this.lUE_OfficeCode.Properties.NullText = "";
            this.lUE_OfficeCode.Properties.ShowHeader = false;
            this.lUE_OfficeCode.Properties.ValueMember = "OfficeCode";
            this.lUE_OfficeCode.Size = new System.Drawing.Size(450, 20);
            this.lUE_OfficeCode.StyleController = this.dataLayoutControl1;
            this.lUE_OfficeCode.TabIndex = 9;
            // 
            // lUE_StoreCode
            // 
            this.lUE_StoreCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "StoreCode", true));
            this.lUE_StoreCode.Location = new System.Drawing.Point(685, 60);
            this.lUE_StoreCode.MenuManager = this.RibbonControl_Root;
            this.lUE_StoreCode.Name = "lUE_StoreCode";
            this.lUE_StoreCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lUE_StoreCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUE_StoreCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StoreCode", "Mağaza Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StoreDesc", "Mağaza Adı")});
            this.lUE_StoreCode.Properties.DisplayMember = "StoreDesc";
            this.lUE_StoreCode.Properties.NullText = "";
            this.lUE_StoreCode.Properties.ShowHeader = false;
            this.lUE_StoreCode.Properties.ValueMember = "StoreCode";
            this.lUE_StoreCode.Size = new System.Drawing.Size(450, 20);
            this.lUE_StoreCode.StyleController = this.dataLayoutControl1;
            this.lUE_StoreCode.TabIndex = 10;
            // 
            // lUE_WarehouseCode
            // 
            this.lUE_WarehouseCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.trInvoiceHeadersBindingSource, "WarehouseCode", true));
            this.lUE_WarehouseCode.Location = new System.Drawing.Point(685, 84);
            this.lUE_WarehouseCode.MenuManager = this.RibbonControl_Root;
            this.lUE_WarehouseCode.Name = "lUE_WarehouseCode";
            this.lUE_WarehouseCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lUE_WarehouseCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lUE_WarehouseCode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseCode", "Depo Kodu"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("WarehouseDesc", "Depo Adı")});
            this.lUE_WarehouseCode.Properties.DisplayMember = "WarehouseDesc";
            this.lUE_WarehouseCode.Properties.NullText = "";
            this.lUE_WarehouseCode.Properties.ShowHeader = false;
            this.lUE_WarehouseCode.Properties.ValueMember = "WarehouseCode";
            this.lUE_WarehouseCode.Size = new System.Drawing.Size(450, 20);
            this.lUE_WarehouseCode.StyleController = this.dataLayoutControl1;
            this.lUE_WarehouseCode.TabIndex = 11;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1147, 486);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIsReturn,
            this.ItemForDocumentDate,
            this.ItemForDocumentTime,
            this.layoutControlItem1,
            this.ItemForDocumentNumber,
            this.ItemForCurrAccCode,
            this.ItemForOfficeCode,
            this.ItemForCustomsDocumentNumber,
            this.ItemForStoreCode,
            this.ItemForWarehouseCode,
            this.ItemForDescription,
            this.layoutControlItem2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(1127, 466);
            // 
            // ItemForIsReturn
            // 
            this.ItemForIsReturn.Control = this.IsReturnCheckEdit;
            this.ItemForIsReturn.Location = new System.Drawing.Point(0, 24);
            this.ItemForIsReturn.Name = "ItemForIsReturn";
            this.ItemForIsReturn.Size = new System.Drawing.Size(563, 24);
            this.ItemForIsReturn.Text = "Qaytarılmadır";
            this.ItemForIsReturn.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIsReturn.TextVisible = false;
            // 
            // ItemForDocumentDate
            // 
            this.ItemForDocumentDate.Control = this.DocumentDateDateEdit;
            this.ItemForDocumentDate.Location = new System.Drawing.Point(0, 72);
            this.ItemForDocumentDate.Name = "ItemForDocumentDate";
            this.ItemForDocumentDate.Size = new System.Drawing.Size(563, 24);
            this.ItemForDocumentDate.Text = "Sənəd Tarixi";
            this.ItemForDocumentDate.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForDocumentTime
            // 
            this.ItemForDocumentTime.Control = this.DocumentTimeTimeSpanEdit;
            this.ItemForDocumentTime.Location = new System.Drawing.Point(0, 96);
            this.ItemForDocumentTime.Name = "ItemForDocumentTime";
            this.ItemForDocumentTime.Size = new System.Drawing.Size(563, 24);
            this.ItemForDocumentTime.Text = "Sənəd Vaxtı";
            this.ItemForDocumentTime.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gC_InvoiceLine;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 120);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1127, 320);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // ItemForDocumentNumber
            // 
            this.ItemForDocumentNumber.Control = this.btnEdit_DocNum;
            this.ItemForDocumentNumber.Location = new System.Drawing.Point(0, 0);
            this.ItemForDocumentNumber.Name = "ItemForDocumentNumber";
            this.ItemForDocumentNumber.Size = new System.Drawing.Size(563, 24);
            this.ItemForDocumentNumber.Text = "Sənəd Nömrəsi";
            this.ItemForDocumentNumber.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForCurrAccCode
            // 
            this.ItemForCurrAccCode.Control = this.btnEdit_CurrAccCode;
            this.ItemForCurrAccCode.Location = new System.Drawing.Point(563, 0);
            this.ItemForCurrAccCode.Name = "ItemForCurrAccCode";
            this.ItemForCurrAccCode.Size = new System.Drawing.Size(564, 24);
            this.ItemForCurrAccCode.Text = "Cari Hesab";
            this.ItemForCurrAccCode.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForOfficeCode
            // 
            this.ItemForOfficeCode.Control = this.lUE_OfficeCode;
            this.ItemForOfficeCode.Location = new System.Drawing.Point(563, 24);
            this.ItemForOfficeCode.Name = "ItemForOfficeCode";
            this.ItemForOfficeCode.Size = new System.Drawing.Size(564, 24);
            this.ItemForOfficeCode.Text = "Ofis";
            this.ItemForOfficeCode.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForCustomsDocumentNumber
            // 
            this.ItemForCustomsDocumentNumber.Control = this.CustomsDocumentNumberTextEdit;
            this.ItemForCustomsDocumentNumber.Location = new System.Drawing.Point(0, 48);
            this.ItemForCustomsDocumentNumber.Name = "ItemForCustomsDocumentNumber";
            this.ItemForCustomsDocumentNumber.Size = new System.Drawing.Size(563, 24);
            this.ItemForCustomsDocumentNumber.Text = "Fərdi Sənəd Nömrəsi";
            this.ItemForCustomsDocumentNumber.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForStoreCode
            // 
            this.ItemForStoreCode.Control = this.lUE_StoreCode;
            this.ItemForStoreCode.Location = new System.Drawing.Point(563, 48);
            this.ItemForStoreCode.Name = "ItemForStoreCode";
            this.ItemForStoreCode.Size = new System.Drawing.Size(564, 24);
            this.ItemForStoreCode.Text = "Mağaza";
            this.ItemForStoreCode.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForWarehouseCode
            // 
            this.ItemForWarehouseCode.Control = this.lUE_WarehouseCode;
            this.ItemForWarehouseCode.Location = new System.Drawing.Point(563, 72);
            this.ItemForWarehouseCode.Name = "ItemForWarehouseCode";
            this.ItemForWarehouseCode.Size = new System.Drawing.Size(564, 24);
            this.ItemForWarehouseCode.Text = "Depo";
            this.ItemForWarehouseCode.TextSize = new System.Drawing.Size(98, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.memoEdit_Desc;
            this.ItemForDescription.Location = new System.Drawing.Point(563, 96);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(564, 24);
            this.ItemForDescription.Text = "Açıqlama";
            this.ItemForDescription.TextSize = new System.Drawing.Size(98, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.simpleButton1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 440);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1127, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            this.dxErrorProvider1.DataSource = this.trInvoiceHeadersBindingSource;
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1147, 644);
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.RibbonControl_Root);
            this.Name = "FormInvoice";
            this.Ribbon = this.RibbonControl_Root;
            this.Text = "Faktura";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormInvoice_FormClosed);
            this.Load += new System.EventHandler(this.FormInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RibbonControl_Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trInvoiceLinesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gC_InvoiceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_InvoiceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repoBtnEdit_ProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IsReturnCheckEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trInvoiceHeadersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentDateDateEdit.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentDateDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DocumentTimeTimeSpanEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomsDocumentNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_DocNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit_Desc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit_CurrAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_OfficeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_StoreCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lUE_WarehouseCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIsReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDocumentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCurrAccCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOfficeCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomsDocumentNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStoreCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForWarehouseCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Ribbon.RibbonControl RibbonControl_Root;
        private DevExpress.XtraBars.Ribbon.RibbonPage RibbonPage_Invoice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup RibbonPageGroup_Invoice;
        private DevExpress.XtraBars.BarButtonItem bBI_Save;
        private DevExpress.XtraBars.BarButtonItem bBI_SaveAndClose;
        private DevExpress.XtraBars.BarButtonItem bBI_SaveAndNew;
        private DevExpress.XtraBars.BarButtonItem bBI_Reset;
        private DevExpress.XtraBars.BarButtonItem bBI_Delete;
        private DevExpress.XtraBars.BarButtonItem bBI_Close;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource trInvoiceLinesBindingSource;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private System.Windows.Forms.BindingSource trInvoiceHeadersBindingSource;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.CheckEdit IsReturnCheckEdit;
        private DevExpress.XtraEditors.DateEdit DocumentDateDateEdit;
        private DevExpress.XtraEditors.TimeSpanEdit DocumentTimeTimeSpanEdit;
        private DevExpress.XtraEditors.TextEdit CustomsDocumentNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIsReturn;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocumentDate;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocumentTime;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCurrAccCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOfficeCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStoreCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForWarehouseCode;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomsDocumentNumber;
        private DevExpress.XtraGrid.GridControl gC_InvoiceLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_InvoiceLine;
        private DevExpress.XtraGrid.Columns.GridColumn col_InvoiceLineId;
        private DevExpress.XtraGrid.Columns.GridColumn col_InvoiceHeaderId;
        private DevExpress.XtraGrid.Columns.GridColumn col_ProductCode;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repoBtnEdit_ProductCode;
        private DevExpress.XtraGrid.Columns.GridColumn col_Qty;
        private DevExpress.XtraGrid.Columns.GridColumn col_Price;
        private DevExpress.XtraGrid.Columns.GridColumn col_Amount;
        private DevExpress.XtraGrid.Columns.GridColumn col_PosDiscount;
        private DevExpress.XtraGrid.Columns.GridColumn col_NetAmount;
        private DevExpress.XtraGrid.Columns.GridColumn col_LineDesc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.ButtonEdit btnEdit_DocNum;
        private DevExpress.XtraEditors.MemoEdit memoEdit_Desc;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDocumentNumber;
        private DevExpress.XtraEditors.ButtonEdit btnEdit_CurrAccCode;
        private DevExpress.XtraEditors.LookUpEdit lUE_OfficeCode;
        private DevExpress.XtraEditors.LookUpEdit lUE_StoreCode;
        private DevExpress.XtraEditors.LookUpEdit lUE_WarehouseCode;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}