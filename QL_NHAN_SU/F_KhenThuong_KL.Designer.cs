
namespace QL_NHAN_SU
{
    partial class F_KhenThuong_KL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_KhenThuong_KL));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_them = new DevExpress.XtraBars.BarButtonItem();
            this.btn_sua = new DevExpress.XtraBars.BarButtonItem();
            this.btn_xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_luu = new DevExpress.XtraBars.BarButtonItem();
            this.btn_huy = new DevExpress.XtraBars.BarButtonItem();
            this.btn_in = new DevExpress.XtraBars.BarButtonItem();
            this.btn_dong = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_lido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sl_NhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.date_Ngay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NoiDung = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_SQD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_khenthuong = new DevExpress.XtraGrid.GridControl();
            this.gcv_khenthuong = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.So_QD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayTao = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LyDo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiDung = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl_NhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_khenthuong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_khenthuong)).BeginInit();
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
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_in, true),
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
            // btn_in
            // 
            this.btn_in.Caption = "IN";
            this.btn_in.Id = 6;
            this.btn_in.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_in.ImageOptions.SvgImage")));
            this.btn_in.Name = "btn_in";
            this.btn_in.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btn_in.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_in_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(945, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 457);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(945, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 421);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(945, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 421);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txt_lido);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.sl_NhanVien);
            this.splitContainer1.Panel1.Controls.Add(this.date_Ngay);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NoiDung);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txt_SQD);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gv_khenthuong);
            this.splitContainer1.Size = new System.Drawing.Size(945, 421);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.TabIndex = 8;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // txt_lido
            // 
            this.txt_lido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_lido.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lido.Location = new System.Drawing.Point(201, 179);
            this.txt_lido.Margin = new System.Windows.Forms.Padding(1);
            this.txt_lido.Name = "txt_lido";
            this.txt_lido.Size = new System.Drawing.Size(636, 30);
            this.txt_lido.TabIndex = 84;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(91, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 83;
            this.label2.Text = "Lý do";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(91, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 82;
            this.label7.Text = "Nhân viên";
            // 
            // sl_NhanVien
            // 
            this.sl_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sl_NhanVien.Location = new System.Drawing.Point(201, 132);
            this.sl_NhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.sl_NhanVien.MenuManager = this.barManager1;
            this.sl_NhanVien.Name = "sl_NhanVien";
            this.sl_NhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_NhanVien.Properties.Appearance.Options.UseFont = true;
            this.sl_NhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sl_NhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.sl_NhanVien.Size = new System.Drawing.Size(460, 28);
            this.sl_NhanVien.TabIndex = 81;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cl_NhanVien,
            this.cl_TenNV});
            this.searchLookUpEdit1View.DetailHeight = 50;
            this.searchLookUpEdit1View.FixedLineWidth = 1;
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // cl_NhanVien
            // 
            this.cl_NhanVien.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_NhanVien.AppearanceCell.Options.UseFont = true;
            this.cl_NhanVien.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_NhanVien.AppearanceHeader.Options.UseFont = true;
            this.cl_NhanVien.Caption = "Mã nhân viên";
            this.cl_NhanVien.FieldName = "id_NhanVien";
            this.cl_NhanVien.MaxWidth = 300;
            this.cl_NhanVien.MinWidth = 300;
            this.cl_NhanVien.Name = "cl_NhanVien";
            this.cl_NhanVien.Visible = true;
            this.cl_NhanVien.VisibleIndex = 0;
            this.cl_NhanVien.Width = 300;
            // 
            // cl_TenNV
            // 
            this.cl_TenNV.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_TenNV.AppearanceCell.Options.UseFont = true;
            this.cl_TenNV.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cl_TenNV.AppearanceHeader.Options.UseFont = true;
            this.cl_TenNV.Caption = "Tên nhân viên";
            this.cl_TenNV.FieldName = "HoTen";
            this.cl_TenNV.MaxWidth = 400;
            this.cl_TenNV.MinWidth = 400;
            this.cl_TenNV.Name = "cl_TenNV";
            this.cl_TenNV.Visible = true;
            this.cl_TenNV.VisibleIndex = 1;
            this.cl_TenNV.Width = 400;
            // 
            // date_Ngay
            // 
            this.date_Ngay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.date_Ngay.CustomFormat = "dd/MM/yyyy";
            this.date_Ngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_Ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_Ngay.Location = new System.Drawing.Point(201, 82);
            this.date_Ngay.Margin = new System.Windows.Forms.Padding(1);
            this.date_Ngay.Name = "date_Ngay";
            this.date_Ngay.Size = new System.Drawing.Size(228, 30);
            this.date_Ngay.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Ngày QĐ";
            // 
            // txt_NoiDung
            // 
            this.txt_NoiDung.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_NoiDung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NoiDung.Location = new System.Drawing.Point(201, 226);
            this.txt_NoiDung.Margin = new System.Windows.Forms.Padding(1);
            this.txt_NoiDung.Name = "txt_NoiDung";
            this.txt_NoiDung.Size = new System.Drawing.Size(636, 30);
            this.txt_NoiDung.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 229);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 22);
            this.label3.TabIndex = 69;
            this.label3.Text = "Nội dung";
            // 
            // txt_SQD
            // 
            this.txt_SQD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_SQD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SQD.Location = new System.Drawing.Point(201, 38);
            this.txt_SQD.Margin = new System.Windows.Forms.Padding(1);
            this.txt_SQD.Name = "txt_SQD";
            this.txt_SQD.ReadOnly = true;
            this.txt_SQD.Size = new System.Drawing.Size(228, 30);
            this.txt_SQD.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 48;
            this.label1.Text = "Số QĐ";
            // 
            // gv_khenthuong
            // 
            this.gv_khenthuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_khenthuong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gv_khenthuong.Location = new System.Drawing.Point(0, 0);
            this.gv_khenthuong.MainView = this.gcv_khenthuong;
            this.gv_khenthuong.Margin = new System.Windows.Forms.Padding(1);
            this.gv_khenthuong.Name = "gv_khenthuong";
            this.gv_khenthuong.Size = new System.Drawing.Size(945, 140);
            this.gv_khenthuong.TabIndex = 2;
            this.gv_khenthuong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_khenthuong});
            // 
            // gcv_khenthuong
            // 
            this.gcv_khenthuong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEL,
            this.So_QD,
            this.NgayTao,
            this.LyDo,
            this.NoiDung,
            this.id_NhanVien,
            this.HoTen});
            this.gcv_khenthuong.GridControl = this.gv_khenthuong;
            this.gcv_khenthuong.Name = "gcv_khenthuong";
            this.gcv_khenthuong.OptionsView.ShowGroupPanel = false;
            this.gcv_khenthuong.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gcv_khenthuong_CustomDrawCell);
            this.gcv_khenthuong.Click += new System.EventHandler(this.gcv_khenthuong_Click);
            // 
            // DEL
            // 
            this.DEL.Caption = "DEl";
            this.DEL.FieldName = "DELETEO_BY";
            this.DEL.MaxWidth = 40;
            this.DEL.MinWidth = 40;
            this.DEL.Name = "DEL";
            this.DEL.Visible = true;
            this.DEL.VisibleIndex = 0;
            this.DEL.Width = 40;
            // 
            // So_QD
            // 
            this.So_QD.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So_QD.AppearanceHeader.Options.UseFont = true;
            this.So_QD.Caption = "Số quyết định";
            this.So_QD.FieldName = "SoQuyetDinh";
            this.So_QD.MaxWidth = 150;
            this.So_QD.MinWidth = 150;
            this.So_QD.Name = "So_QD";
            this.So_QD.Visible = true;
            this.So_QD.VisibleIndex = 1;
            this.So_QD.Width = 150;
            // 
            // NgayTao
            // 
            this.NgayTao.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTao.AppearanceCell.Options.UseFont = true;
            this.NgayTao.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayTao.AppearanceHeader.Options.UseFont = true;
            this.NgayTao.Caption = "Ngày quyết định";
            this.NgayTao.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayTao.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NgayTao.FieldName = "NgayTao";
            this.NgayTao.MaxWidth = 170;
            this.NgayTao.MinWidth = 170;
            this.NgayTao.Name = "NgayTao";
            this.NgayTao.Visible = true;
            this.NgayTao.VisibleIndex = 2;
            this.NgayTao.Width = 170;
            // 
            // LyDo
            // 
            this.LyDo.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LyDo.AppearanceHeader.Options.UseFont = true;
            this.LyDo.Caption = "Lý do";
            this.LyDo.FieldName = "LyDo";
            this.LyDo.MaxWidth = 450;
            this.LyDo.MinWidth = 450;
            this.LyDo.Name = "LyDo";
            this.LyDo.Visible = true;
            this.LyDo.VisibleIndex = 3;
            this.LyDo.Width = 450;
            // 
            // NoiDung
            // 
            this.NoiDung.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiDung.AppearanceHeader.Options.UseFont = true;
            this.NoiDung.Caption = "Nội dung";
            this.NoiDung.FieldName = "NoiDung";
            this.NoiDung.MaxWidth = 500;
            this.NoiDung.MinWidth = 500;
            this.NoiDung.Name = "NoiDung";
            this.NoiDung.Visible = true;
            this.NoiDung.VisibleIndex = 4;
            this.NoiDung.Width = 500;
            // 
            // id_NhanVien
            // 
            this.id_NhanVien.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_NhanVien.AppearanceHeader.Options.UseFont = true;
            this.id_NhanVien.Caption = "Mã nhân viên";
            this.id_NhanVien.FieldName = "id_NhanVien";
            this.id_NhanVien.MaxWidth = 200;
            this.id_NhanVien.MinWidth = 200;
            this.id_NhanVien.Name = "id_NhanVien";
            this.id_NhanVien.Visible = true;
            this.id_NhanVien.VisibleIndex = 5;
            this.id_NhanVien.Width = 200;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 400;
            this.HoTen.MinWidth = 400;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 6;
            this.HoTen.Width = 400;
            // 
            // F_KhenThuong_KL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 457);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "F_KhenThuong_KL";
            this.Text = "Khen thưởng";
            this.Load += new System.EventHandler(this.F_KhenThuong_KL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sl_NhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_khenthuong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_khenthuong)).EndInit();
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
        private DevExpress.XtraBars.BarButtonItem btn_in;
        private DevExpress.XtraBars.BarButtonItem btn_dong;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker date_Ngay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_NoiDung;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SQD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit sl_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn cl_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_TenNV;
        private System.Windows.Forms.TextBox txt_lido;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gv_khenthuong;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_khenthuong;
        private DevExpress.XtraGrid.Columns.GridColumn DEL;
        private DevExpress.XtraGrid.Columns.GridColumn So_QD;
        private DevExpress.XtraGrid.Columns.GridColumn NgayTao;
        private DevExpress.XtraGrid.Columns.GridColumn LyDo;
        private DevExpress.XtraGrid.Columns.GridColumn NoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn id_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
    }
}