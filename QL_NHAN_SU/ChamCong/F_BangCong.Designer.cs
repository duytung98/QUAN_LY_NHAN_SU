
namespace QL_NHAN_SU.ChamCong
{
    partial class F_BangCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BangCong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btn_in = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cb_trangthai = new System.Windows.Forms.CheckBox();
            this.cb_Khoa = new System.Windows.Forms.CheckBox();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_chamcong = new DevExpress.XtraGrid.GridControl();
            this.gcv_chamcong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaKyCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Thang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Khoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTinhCong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCongTrongThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_chamcong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_chamcong)).BeginInit();
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
            this.btn_in,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 8;
            // 
            // bar2
            // 
            this.bar2.BarAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bar2.BarAppearance.Hovered.Options.UseFont = true;
            this.bar2.BarAppearance.Normal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true),
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
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Xem bảng công";
            this.barButtonItem1.Id = 7;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
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
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1102, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 414);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1102, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 378);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1102, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 378);
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
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cb_trangthai);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Khoa);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Thang);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Nam);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_chamcong);
            this.splitContainer1.Size = new System.Drawing.Size(1102, 378);
            this.splitContainer1.SplitterDistance = 91;
            this.splitContainer1.TabIndex = 7;
            // 
            // cb_trangthai
            // 
            this.cb_trangthai.AutoSize = true;
            this.cb_trangthai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_trangthai.Location = new System.Drawing.Point(685, 36);
            this.cb_trangthai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_trangthai.Name = "cb_trangthai";
            this.cb_trangthai.Size = new System.Drawing.Size(119, 27);
            this.cb_trangthai.TabIndex = 9;
            this.cb_trangthai.Text = "Trạng thái";
            this.cb_trangthai.UseVisualStyleBackColor = true;
            // 
            // cb_Khoa
            // 
            this.cb_Khoa.AutoSize = true;
            this.cb_Khoa.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Khoa.Location = new System.Drawing.Point(854, 36);
            this.cb_Khoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Khoa.Name = "cb_Khoa";
            this.cb_Khoa.Size = new System.Drawing.Size(77, 27);
            this.cb_Khoa.TabIndex = 8;
            this.cb_Khoa.Text = "Khóa";
            this.cb_Khoa.UseVisualStyleBackColor = true;
            this.cb_Khoa.CheckedChanged += new System.EventHandler(this.cb_Khoa_CheckedChanged);
            // 
            // cb_Thang
            // 
            this.cb_Thang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Thang.FormattingEnabled = true;
            this.cb_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cb_Thang.Location = new System.Drawing.Point(493, 33);
            this.cb_Thang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Thang.Name = "cb_Thang";
            this.cb_Thang.Size = new System.Drawing.Size(121, 31);
            this.cb_Thang.TabIndex = 7;
            // 
            // cb_Nam
            // 
            this.cb_Nam.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Nam.FormattingEnabled = true;
            this.cb_Nam.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.cb_Nam.Location = new System.Drawing.Point(224, 33);
            this.cb_Nam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(121, 31);
            this.cb_Nam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tháng";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm";
            // 
            // gc_chamcong
            // 
            this.gc_chamcong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_chamcong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gc_chamcong.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_chamcong.Location = new System.Drawing.Point(0, 0);
            this.gc_chamcong.MainView = this.gcv_chamcong;
            this.gc_chamcong.Margin = new System.Windows.Forms.Padding(1);
            this.gc_chamcong.Name = "gc_chamcong";
            this.gc_chamcong.Size = new System.Drawing.Size(1102, 283);
            this.gc_chamcong.TabIndex = 2;
            this.gc_chamcong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_chamcong});
            // 
            // gcv_chamcong
            // 
            this.gcv_chamcong.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_chamcong.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gcv_chamcong.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_chamcong.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gcv_chamcong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEL,
            this.MaKyCong,
            this.Thang,
            this.Nam,
            this.Khoa,
            this.NgayTinhCong,
            this.NgayCongTrongThang,
            this.TrangThai});
            this.gcv_chamcong.CustomizationFormBounds = new System.Drawing.Rectangle(678, 477, 314, 325);
            this.gcv_chamcong.DetailHeight = 414;
            this.gcv_chamcong.GridControl = this.gc_chamcong;
            this.gcv_chamcong.Name = "gcv_chamcong";
            this.gcv_chamcong.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gcv_chamcong.OptionsView.ShowFooter = true;
            this.gcv_chamcong.OptionsView.ShowGroupPanel = false;
            this.gcv_chamcong.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gcv_chamcong_CustomDrawCell);
            this.gcv_chamcong.Click += new System.EventHandler(this.gcv_chamcong_Click);
            // 
            // DEL
            // 
            this.DEL.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL.AppearanceCell.Options.UseFont = true;
            this.DEL.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL.AppearanceHeader.Options.UseFont = true;
            this.DEL.Caption = "DEL";
            this.DEL.FieldName = "DELETEO_BY";
            this.DEL.MaxWidth = 40;
            this.DEL.MinWidth = 40;
            this.DEL.Name = "DEL";
            this.DEL.Visible = true;
            this.DEL.VisibleIndex = 0;
            this.DEL.Width = 40;
            // 
            // MaKyCong
            // 
            this.MaKyCong.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKyCong.AppearanceCell.Options.UseFont = true;
            this.MaKyCong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKyCong.AppearanceHeader.Options.UseFont = true;
            this.MaKyCong.Caption = "Mã kỳ công";
            this.MaKyCong.FieldName = "MaKyCong";
            this.MaKyCong.MaxWidth = 199;
            this.MaKyCong.MinWidth = 199;
            this.MaKyCong.Name = "MaKyCong";
            this.MaKyCong.Visible = true;
            this.MaKyCong.VisibleIndex = 1;
            this.MaKyCong.Width = 199;
            // 
            // Thang
            // 
            this.Thang.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thang.AppearanceCell.Options.UseFont = true;
            this.Thang.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thang.AppearanceHeader.Options.UseFont = true;
            this.Thang.Caption = "Tháng";
            this.Thang.FieldName = "Thang";
            this.Thang.MaxWidth = 100;
            this.Thang.MinWidth = 100;
            this.Thang.Name = "Thang";
            this.Thang.Visible = true;
            this.Thang.VisibleIndex = 2;
            this.Thang.Width = 100;
            // 
            // Nam
            // 
            this.Nam.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.AppearanceCell.Options.UseFont = true;
            this.Nam.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nam.AppearanceHeader.Options.UseFont = true;
            this.Nam.Caption = "Năm";
            this.Nam.FieldName = "Nam";
            this.Nam.MaxWidth = 100;
            this.Nam.MinWidth = 100;
            this.Nam.Name = "Nam";
            this.Nam.Visible = true;
            this.Nam.VisibleIndex = 3;
            this.Nam.Width = 100;
            // 
            // Khoa
            // 
            this.Khoa.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khoa.AppearanceCell.Options.UseFont = true;
            this.Khoa.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Khoa.AppearanceHeader.Options.UseFont = true;
            this.Khoa.Caption = "Khóa";
            this.Khoa.FieldName = "Khoa";
            this.Khoa.MaxWidth = 100;
            this.Khoa.MinWidth = 100;
            this.Khoa.Name = "Khoa";
            this.Khoa.Visible = true;
            this.Khoa.VisibleIndex = 4;
            this.Khoa.Width = 100;
            // 
            // NgayTinhCong
            // 
            this.NgayTinhCong.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTinhCong.AppearanceCell.Options.UseFont = true;
            this.NgayTinhCong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTinhCong.AppearanceHeader.Options.UseFont = true;
            this.NgayTinhCong.Caption = "Ngày tính công";
            this.NgayTinhCong.FieldName = "NgayTinhCong";
            this.NgayTinhCong.MaxWidth = 199;
            this.NgayTinhCong.MinWidth = 199;
            this.NgayTinhCong.Name = "NgayTinhCong";
            this.NgayTinhCong.Visible = true;
            this.NgayTinhCong.VisibleIndex = 5;
            this.NgayTinhCong.Width = 199;
            // 
            // NgayCongTrongThang
            // 
            this.NgayCongTrongThang.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCongTrongThang.AppearanceCell.Options.UseFont = true;
            this.NgayCongTrongThang.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCongTrongThang.AppearanceHeader.Options.UseFont = true;
            this.NgayCongTrongThang.Caption = "Ngày công trong tháng";
            this.NgayCongTrongThang.FieldName = "NgayCongTrongThang";
            this.NgayCongTrongThang.MaxWidth = 199;
            this.NgayCongTrongThang.MinWidth = 199;
            this.NgayCongTrongThang.Name = "NgayCongTrongThang";
            this.NgayCongTrongThang.Visible = true;
            this.NgayCongTrongThang.VisibleIndex = 6;
            this.NgayCongTrongThang.Width = 199;
            // 
            // TrangThai
            // 
            this.TrangThai.AppearanceCell.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.AppearanceCell.Options.UseFont = true;
            this.TrangThai.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrangThai.AppearanceHeader.Options.UseFont = true;
            this.TrangThai.Caption = "Trạng thái";
            this.TrangThai.FieldName = "TrangThai";
            this.TrangThai.MaxWidth = 100;
            this.TrangThai.MinWidth = 100;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Visible = true;
            this.TrangThai.VisibleIndex = 7;
            this.TrangThai.Width = 100;
            // 
            // F_BangCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 414);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_BangCong";
            this.Text = "Bảng công";
            this.Load += new System.EventHandler(this.F_BangCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_chamcong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_chamcong)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_chamcong;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_chamcong;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private System.Windows.Forms.ComboBox cb_Nam;
        private System.Windows.Forms.CheckBox cb_trangthai;
        private System.Windows.Forms.ComboBox cb_Thang;
        private DevExpress.XtraGrid.Columns.GridColumn MaKyCong;
        private DevExpress.XtraGrid.Columns.GridColumn Thang;
        private DevExpress.XtraGrid.Columns.GridColumn Nam;
        private DevExpress.XtraGrid.Columns.GridColumn Khoa;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTinhCong;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCongTrongThang;
        private DevExpress.XtraGrid.Columns.GridColumn TrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn DEL;
        private System.Windows.Forms.CheckBox cb_Khoa;
    }
}