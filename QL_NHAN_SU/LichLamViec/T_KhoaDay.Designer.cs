﻿
namespace QL_NHAN_SU.LichLamViec
{
    partial class T_KhoaDay
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(T_KhoaDay));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_in = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_khoahoc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_khoaDay = new DevExpress.XtraGrid.GridControl();
            this.gcv_khoaday = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_Khoaday = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten_KhoaDay = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_khoaDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_khoaday)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_them,
            this.btn_sua,
            this.btn_xoa,
            this.btn_luu,
            this.btn_huy,
            this.btn_dong,
            this.btn_in});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Normal.Options.UseFont = true;
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_them),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_sua, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_xoa, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_luu, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_huy, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_dong, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_them
            // 
            this.btn_them.Caption = "Thêm";
            this.btn_them.Id = 0;
            this.btn_them.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_them.ImageOptions.SvgImage")));
            this.btn_them.Name = "btn_them";
            this.btn_them.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_them.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_them_ItemClick);
            // 
            // btn_sua
            // 
            this.btn_sua.Caption = "Sửa";
            this.btn_sua.Id = 1;
            this.btn_sua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sua.ImageOptions.SvgImage")));
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_sua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_sua_ItemClick);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Caption = "Xóa";
            this.btn_xoa.Id = 2;
            this.btn_xoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_xoa.ImageOptions.SvgImage")));
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_xoa_ItemClick);
            // 
            // btn_luu
            // 
            this.btn_luu.Caption = "Lưu";
            this.btn_luu.Id = 3;
            this.btn_luu.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_luu.ImageOptions.SvgImage")));
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_luu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_luu_ItemClick);
            // 
            // btn_huy
            // 
            this.btn_huy.Caption = "Hủy";
            this.btn_huy.Id = 4;
            this.btn_huy.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_huy.ImageOptions.SvgImage")));
            this.btn_huy.Name = "btn_huy";
            this.btn_huy.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_huy.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_huy_ItemClick);
            // 
            // btn_dong
            // 
            this.btn_dong.Caption = "Đóng";
            this.btn_dong.Id = 5;
            this.btn_dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_dong.ImageOptions.SvgImage")));
            this.btn_dong.Name = "btn_dong";
            this.btn_dong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_dong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(770, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 378);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(770, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 342);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(770, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 342);
            // 
            // btn_in
            // 
            this.btn_in.Caption = "IN";
            this.btn_in.Id = 6;
            this.btn_in.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_in.ImageOptions.SvgImage")));
            this.btn_in.Name = "btn_in";
            this.btn_in.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_khoahoc);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_khoaDay);
            this.splitContainer1.Size = new System.Drawing.Size(770, 342);
            this.splitContainer1.SplitterDistance = 65;
            this.splitContainer1.TabIndex = 6;
            // 
            // txt_khoahoc
            // 
            this.txt_khoahoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_khoahoc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_khoahoc.Location = new System.Drawing.Point(206, 21);
            this.txt_khoahoc.Margin = new System.Windows.Forms.Padding(1);
            this.txt_khoahoc.Name = "txt_khoahoc";
            this.txt_khoahoc.Size = new System.Drawing.Size(310, 34);
            this.txt_khoahoc.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Khoa học";
            // 
            // gc_khoaDay
            // 
            this.gc_khoaDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_khoaDay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gc_khoaDay.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_khoaDay.Location = new System.Drawing.Point(0, 0);
            this.gc_khoaDay.MainView = this.gcv_khoaday;
            this.gc_khoaDay.Margin = new System.Windows.Forms.Padding(1);
            this.gc_khoaDay.Name = "gc_khoaDay";
            this.gc_khoaDay.Size = new System.Drawing.Size(770, 273);
            this.gc_khoaDay.TabIndex = 2;
            this.gc_khoaDay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_khoaday});
            // 
            // gcv_khoaday
            // 
            this.gcv_khoaday.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_khoaday.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gcv_khoaday.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_khoaday.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gcv_khoaday.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_Khoaday,
            this.Ten_KhoaDay});
            this.gcv_khoaday.CustomizationFormBounds = new System.Drawing.Rectangle(678, 477, 314, 325);
            this.gcv_khoaday.DetailHeight = 414;
            this.gcv_khoaday.GridControl = this.gc_khoaDay;
            this.gcv_khoaday.Name = "gcv_khoaday";
            this.gcv_khoaday.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gcv_khoaday.OptionsView.ShowFooter = true;
            this.gcv_khoaday.OptionsView.ShowGroupPanel = false;
            this.gcv_khoaday.Click += new System.EventHandler(this.gcv_khoaday_Click);
            // 
            // id_Khoaday
            // 
            this.id_Khoaday.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Khoaday.AppearanceCell.Options.UseFont = true;
            this.id_Khoaday.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_Khoaday.AppearanceHeader.Options.UseFont = true;
            this.id_Khoaday.Caption = "ID Khóa dạy";
            this.id_Khoaday.FieldName = "id_KhoaDay";
            this.id_Khoaday.MaxWidth = 200;
            this.id_Khoaday.MinWidth = 200;
            this.id_Khoaday.Name = "id_Khoaday";
            this.id_Khoaday.Visible = true;
            this.id_Khoaday.VisibleIndex = 0;
            this.id_Khoaday.Width = 200;
            // 
            // Ten_KhoaDay
            // 
            this.Ten_KhoaDay.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_KhoaDay.AppearanceCell.Options.UseFont = true;
            this.Ten_KhoaDay.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_KhoaDay.AppearanceHeader.Options.UseFont = true;
            this.Ten_KhoaDay.Caption = "Tên khoa dạy";
            this.Ten_KhoaDay.FieldName = "Ten_KhoaDay";
            this.Ten_KhoaDay.MaxWidth = 500;
            this.Ten_KhoaDay.MinWidth = 500;
            this.Ten_KhoaDay.Name = "Ten_KhoaDay";
            this.Ten_KhoaDay.Visible = true;
            this.Ten_KhoaDay.VisibleIndex = 1;
            this.Ten_KhoaDay.Width = 500;
            // 
            // T_KhoaDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 378);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "T_KhoaDay";
            this.Text = "Khóa học";
            this.Load += new System.EventHandler(this.T_KhoaDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_khoaDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_khoaday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_them;
        private DevExpress.XtraBars.BarButtonItem btn_sua;
        private DevExpress.XtraBars.BarButtonItem btn_xoa;
        private DevExpress.XtraBars.BarButtonItem btn_luu;
        private DevExpress.XtraBars.BarButtonItem btn_huy;
        private DevExpress.XtraBars.BarButtonItem btn_dong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btn_in;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_khoahoc;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_khoaDay;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_khoaday;
        private DevExpress.XtraGrid.Columns.GridColumn id_Khoaday;
        private DevExpress.XtraGrid.Columns.GridColumn Ten_KhoaDay;
    }
}