﻿using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using PointOfSale.Models;
using System;
using System.Windows.Forms;

namespace PointOfSale
{
    public partial class FormProductList : XtraForm
    {
        public DcProduct DcProduct { get; set; }
        SqlMethods sqlMethods = new SqlMethods();

        public FormProductList()
        {
            InitializeComponent();
            gridControl1.DataSource = sqlMethods.SelectProducts();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if ((info.InRow || info.InRowCell) && view.FocusedRowHandle >= 0)
            {
                //info.RowHandle
                string colCaption = info.Column == null ? "N/A" : info.Column.GetCaption();
                DcProduct = new DcProduct()
                {
                    ProductCode = view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ProductCode"]).ToString(),
                    Barcode = view.GetRowCellValue(view.FocusedRowHandle, view.Columns["Barcode"]).ToString(),
                    ProductDescription = view.GetRowCellValue(view.FocusedRowHandle, view.Columns["ProductDescription"]).ToString(),
                    RetailPrice = Convert.ToDouble(view.GetRowCellValue(view.FocusedRowHandle, view.Columns["RetailPrice"]))
                };
                DialogResult = DialogResult.OK;
            }
        }
    }
}