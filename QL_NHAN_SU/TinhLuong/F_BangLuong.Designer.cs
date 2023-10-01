
namespace QL_NHAN_SU.TinhLuong
{
    partial class F_BangLuong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BangLuong));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bnt_tinhluong = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_in = new DevExpress.XtraBars.BarButtonItem();
            this.bnt_dong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.btn_sua2 = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btb_xembangluong = new DevExpress.XtraEditors.SimpleButton();
            this.cb_Thang = new System.Windows.Forms.ComboBox();
            this.cb_Nam = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_bangluong = new DevExpress.XtraGrid.GridControl();
            this.gcv_bangluong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.kycong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NCTrongThang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.phep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayLe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ngaychunhat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayThuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhuCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UngLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ThucLanh = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bangluong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_bangluong)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControl1);
            this.barManager1.DockWindowTabFont = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bnt_tinhluong,
            this.btn_sua2,
            this.bnt_dong,
            this.bnt_in});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 7;
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
            this.bar2.FloatLocation = new System.Drawing.Point(515, 106);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bnt_tinhluong),
            new DevExpress.XtraBars.LinkPersistInfo(this.bnt_in, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bnt_dong, true)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // bnt_tinhluong
            // 
            this.bnt_tinhluong.Caption = "Tính lương";
            this.bnt_tinhluong.Id = 0;
            this.bnt_tinhluong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bnt_tinhluong.ImageOptions.SvgImage")));
            this.bnt_tinhluong.Name = "bnt_tinhluong";
            this.bnt_tinhluong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bnt_tinhluong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_tinhluong_ItemClick);
            // 
            // bnt_in
            // 
            this.bnt_in.Caption = "IN";
            this.bnt_in.Id = 6;
            this.bnt_in.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bnt_in.ImageOptions.SvgImage")));
            this.bnt_in.Name = "bnt_in";
            this.bnt_in.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bnt_in.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_in_ItemClick);
            // 
            // bnt_dong
            // 
            this.bnt_dong.Caption = "Đóng";
            this.bnt_dong.Id = 5;
            this.bnt_dong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bnt_dong.ImageOptions.SvgImage")));
            this.bnt_dong.Name = "bnt_dong";
            this.bnt_dong.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bnt_dong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bnt_dong_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlTop.Size = new System.Drawing.Size(1221, 35);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 404);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1221, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 35);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 369);
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl1.Location = new System.Drawing.Point(1221, 35);
            this.barDockControl1.Manager = this.barManager1;
            this.barDockControl1.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControl1.Size = new System.Drawing.Size(0, 369);
            // 
            // btn_sua2
            // 
            this.btn_sua2.Caption = "Sửa";
            this.btn_sua2.Id = 1;
            this.btn_sua2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_sua2.ImageOptions.SvgImage")));
            this.btn_sua2.Name = "btn_sua2";
            this.btn_sua2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 35);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.splitContainer1.Panel1.Controls.Add(this.btb_xembangluong);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Thang);
            this.splitContainer1.Panel1.Controls.Add(this.cb_Nam);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_bangluong);
            this.splitContainer1.Size = new System.Drawing.Size(1221, 369);
            this.splitContainer1.SplitterDistance = 93;
            this.splitContainer1.TabIndex = 8;
            // 
            // btb_xembangluong
            // 
            this.btb_xembangluong.Appearance.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btb_xembangluong.Appearance.Options.UseFont = true;
            this.btb_xembangluong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btb_xembangluong.ImageOptions.Image")));
            this.btb_xembangluong.Location = new System.Drawing.Point(715, 28);
            this.btb_xembangluong.Name = "btb_xembangluong";
            this.btb_xembangluong.Size = new System.Drawing.Size(183, 43);
            this.btb_xembangluong.TabIndex = 8;
            this.btb_xembangluong.Text = "Xem bảng lương";
            this.btb_xembangluong.Click += new System.EventHandler(this.btb_xembangluong_Click);
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
            this.cb_Thang.Location = new System.Drawing.Point(493, 34);
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
            "2033",
            "2034",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040",
            "2041",
            "2042",
            "2043",
            "2044",
            "2045",
            "2046",
            "2047",
            "2048",
            "2049",
            "2040",
            "2051",
            "2052",
            "2053",
            "2054",
            "2055",
            "2056",
            "2057",
            "2058",
            "2059",
            "2060",
            "2061",
            "2062",
            "2063",
            "2064",
            "2065",
            "2066",
            "2067",
            "2068",
            "2069",
            "2070"});
            this.cb_Nam.Location = new System.Drawing.Point(224, 36);
            this.cb_Nam.Name = "cb_Nam";
            this.cb_Nam.Size = new System.Drawing.Size(121, 31);
            this.cb_Nam.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 38);
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
            this.label1.Location = new System.Drawing.Point(155, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Năm";
            // 
            // gc_bangluong
            // 
            this.gc_bangluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bangluong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gc_bangluong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_bangluong.Location = new System.Drawing.Point(0, 0);
            this.gc_bangluong.MainView = this.gcv_bangluong;
            this.gc_bangluong.Margin = new System.Windows.Forms.Padding(1);
            this.gc_bangluong.Name = "gc_bangluong";
            this.gc_bangluong.Size = new System.Drawing.Size(1221, 272);
            this.gc_bangluong.TabIndex = 2;
            this.gc_bangluong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_bangluong});
            // 
            // gcv_bangluong
            // 
            this.gcv_bangluong.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_bangluong.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gcv_bangluong.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_bangluong.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gcv_bangluong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.kycong,
            this.MaNV,
            this.HoTen,
            this.NCTrongThang,
            this.phep,
            this.NgayLe,
            this.Ngaychunhat,
            this.NgayThuong,
            this.PhuCap,
            this.UngLuong,
            this.ThucLanh});
            this.gcv_bangluong.CustomizationFormBounds = new System.Drawing.Rectangle(678, 477, 314, 325);
            this.gcv_bangluong.DetailHeight = 414;
            this.gcv_bangluong.GridControl = this.gc_bangluong;
            this.gcv_bangluong.Name = "gcv_bangluong";
            this.gcv_bangluong.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gcv_bangluong.OptionsView.ShowFooter = true;
            this.gcv_bangluong.OptionsView.ShowGroupPanel = false;
            // 
            // kycong
            // 
            this.kycong.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kycong.AppearanceCell.Options.UseFont = true;
            this.kycong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kycong.AppearanceHeader.Options.UseFont = true;
            this.kycong.Caption = "Mã kỳ công";
            this.kycong.FieldName = "MakyCong";
            this.kycong.MaxWidth = 130;
            this.kycong.MinWidth = 130;
            this.kycong.Name = "kycong";
            this.kycong.Visible = true;
            this.kycong.VisibleIndex = 0;
            this.kycong.Width = 130;
            // 
            // MaNV
            // 
            this.MaNV.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.AppearanceCell.Options.UseFont = true;
            this.MaNV.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNV.AppearanceHeader.Options.UseFont = true;
            this.MaNV.Caption = "Mã nhân viên";
            this.MaNV.FieldName = "id_NhanVien";
            this.MaNV.MaxWidth = 150;
            this.MaNV.MinWidth = 150;
            this.MaNV.Name = "MaNV";
            this.MaNV.Visible = true;
            this.MaNV.VisibleIndex = 1;
            this.MaNV.Width = 150;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceCell.Options.UseFont = true;
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 200;
            this.HoTen.MinWidth = 200;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 2;
            this.HoTen.Width = 200;
            // 
            // NCTrongThang
            // 
            this.NCTrongThang.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCTrongThang.AppearanceCell.Options.UseFont = true;
            this.NCTrongThang.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NCTrongThang.AppearanceHeader.Options.UseFont = true;
            this.NCTrongThang.Caption = "Công trong tháng";
            this.NCTrongThang.FieldName = "NgayCongTrongThang";
            this.NCTrongThang.MaxWidth = 150;
            this.NCTrongThang.MinWidth = 150;
            this.NCTrongThang.Name = "NCTrongThang";
            this.NCTrongThang.Visible = true;
            this.NCTrongThang.VisibleIndex = 3;
            this.NCTrongThang.Width = 150;
            // 
            // phep
            // 
            this.phep.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phep.AppearanceCell.Options.UseFont = true;
            this.phep.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phep.AppearanceHeader.Options.UseFont = true;
            this.phep.Caption = "Ngày phép";
            this.phep.DisplayFormat.FormatString = "n0";
            this.phep.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.phep.FieldName = "NgayPhep";
            this.phep.MaxWidth = 150;
            this.phep.MinWidth = 150;
            this.phep.Name = "phep";
            this.phep.Visible = true;
            this.phep.VisibleIndex = 4;
            this.phep.Width = 150;
            // 
            // NgayLe
            // 
            this.NgayLe.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLe.AppearanceCell.Options.UseFont = true;
            this.NgayLe.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayLe.AppearanceHeader.Options.UseFont = true;
            this.NgayLe.Caption = "Ngày lễ";
            this.NgayLe.DisplayFormat.FormatString = "n0";
            this.NgayLe.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayLe.FieldName = "NgayLe";
            this.NgayLe.MaxWidth = 120;
            this.NgayLe.MinWidth = 120;
            this.NgayLe.Name = "NgayLe";
            this.NgayLe.Visible = true;
            this.NgayLe.VisibleIndex = 5;
            this.NgayLe.Width = 120;
            // 
            // Ngaychunhat
            // 
            this.Ngaychunhat.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngaychunhat.AppearanceCell.Options.UseFont = true;
            this.Ngaychunhat.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ngaychunhat.AppearanceHeader.Options.UseFont = true;
            this.Ngaychunhat.Caption = "Ngày chủ nhật";
            this.Ngaychunhat.DisplayFormat.FormatString = "n0";
            this.Ngaychunhat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Ngaychunhat.FieldName = "NgayChuNhat";
            this.Ngaychunhat.MaxWidth = 150;
            this.Ngaychunhat.MinWidth = 150;
            this.Ngaychunhat.Name = "Ngaychunhat";
            this.Ngaychunhat.Visible = true;
            this.Ngaychunhat.VisibleIndex = 6;
            this.Ngaychunhat.Width = 150;
            // 
            // NgayThuong
            // 
            this.NgayThuong.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayThuong.AppearanceCell.Options.UseFont = true;
            this.NgayThuong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayThuong.AppearanceHeader.Options.UseFont = true;
            this.NgayThuong.Caption = "Ngày thường";
            this.NgayThuong.DisplayFormat.FormatString = "n0";
            this.NgayThuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.NgayThuong.FieldName = "NgayThuong";
            this.NgayThuong.MaxWidth = 150;
            this.NgayThuong.MinWidth = 150;
            this.NgayThuong.Name = "NgayThuong";
            this.NgayThuong.Visible = true;
            this.NgayThuong.VisibleIndex = 7;
            this.NgayThuong.Width = 150;
            // 
            // PhuCap
            // 
            this.PhuCap.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhuCap.AppearanceCell.Options.UseFont = true;
            this.PhuCap.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhuCap.AppearanceHeader.Options.UseFont = true;
            this.PhuCap.Caption = "Phụ cấp";
            this.PhuCap.DisplayFormat.FormatString = "n0";
            this.PhuCap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.PhuCap.FieldName = "PhuCap";
            this.PhuCap.MaxWidth = 200;
            this.PhuCap.MinWidth = 200;
            this.PhuCap.Name = "PhuCap";
            this.PhuCap.Visible = true;
            this.PhuCap.VisibleIndex = 8;
            this.PhuCap.Width = 200;
            // 
            // UngLuong
            // 
            this.UngLuong.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UngLuong.AppearanceCell.Options.UseFont = true;
            this.UngLuong.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UngLuong.AppearanceHeader.Options.UseFont = true;
            this.UngLuong.Caption = "Ứng lương";
            this.UngLuong.DisplayFormat.FormatString = "n0";
            this.UngLuong.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.UngLuong.FieldName = "UngLuong";
            this.UngLuong.MaxWidth = 150;
            this.UngLuong.MinWidth = 150;
            this.UngLuong.Name = "UngLuong";
            this.UngLuong.Visible = true;
            this.UngLuong.VisibleIndex = 9;
            this.UngLuong.Width = 150;
            // 
            // ThucLanh
            // 
            this.ThucLanh.AppearanceCell.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThucLanh.AppearanceCell.Options.UseFont = true;
            this.ThucLanh.AppearanceHeader.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThucLanh.AppearanceHeader.Options.UseFont = true;
            this.ThucLanh.Caption = "Thực lãnh";
            this.ThucLanh.DisplayFormat.FormatString = "n0";
            this.ThucLanh.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.ThucLanh.FieldName = "ThucLanh";
            this.ThucLanh.MaxWidth = 200;
            this.ThucLanh.MinWidth = 200;
            this.ThucLanh.Name = "ThucLanh";
            this.ThucLanh.Visible = true;
            this.ThucLanh.VisibleIndex = 10;
            this.ThucLanh.Width = 200;
            // 
            // F_BangLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 404);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControl1);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "F_BangLuong";
            this.Text = "Bảng lương";
            this.Load += new System.EventHandler(this.F_BangLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_bangluong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_bangluong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem bnt_tinhluong;
        private DevExpress.XtraBars.BarButtonItem btn_sua2;
        private DevExpress.XtraBars.BarButtonItem bnt_in;
        private DevExpress.XtraBars.BarButtonItem bnt_dong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox cb_Thang;
        private System.Windows.Forms.ComboBox cb_Nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_bangluong;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_bangluong;
        private DevExpress.XtraGrid.Columns.GridColumn NCTrongThang;
        private DevExpress.XtraGrid.Columns.GridColumn phep;
        private DevExpress.XtraGrid.Columns.GridColumn NgayLe;
        private DevExpress.XtraGrid.Columns.GridColumn Ngaychunhat;
        private DevExpress.XtraGrid.Columns.GridColumn NgayThuong;
        private DevExpress.XtraGrid.Columns.GridColumn PhuCap;
        private DevExpress.XtraEditors.SimpleButton btb_xembangluong;
        private DevExpress.XtraGrid.Columns.GridColumn kycong;
        private DevExpress.XtraGrid.Columns.GridColumn MaNV;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn ThucLanh;
        private DevExpress.XtraGrid.Columns.GridColumn UngLuong;
    }
}