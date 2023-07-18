
namespace QL_NHAN_SU
{
    partial class F_BaoHiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_BaoHiem));
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_noikham = new System.Windows.Forms.TextBox();
            this.txt_noicap = new System.Windows.Forms.TextBox();
            this.txt_baohiem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.date_cap = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sl_NhanVien = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cl_NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_TenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_baohiem = new DevExpress.XtraGrid.GridControl();
            this.gcv_baohiem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DEL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id_NhanVien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.so_BH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NoiCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NgayCap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Noi_DK_KamBenh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GhiChu = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sl_NhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_baohiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_baohiem)).BeginInit();
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
            this.btn_dong});
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
            this.barDockControlTop.Size = new System.Drawing.Size(1026, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 388);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1026, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 352);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1026, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 352);
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
            this.splitContainer1.Panel1.Controls.Add(this.txt_ghichu);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.txt_noikham);
            this.splitContainer1.Panel1.Controls.Add(this.txt_noicap);
            this.splitContainer1.Panel1.Controls.Add(this.txt_baohiem);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.date_cap);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.sl_NhanVien);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gv_baohiem);
            this.splitContainer1.Size = new System.Drawing.Size(1026, 352);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 8;
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_ghichu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ghichu.Location = new System.Drawing.Point(729, 142);
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(228, 30);
            this.txt_ghichu.TabIndex = 80;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(615, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 22);
            this.label5.TabIndex = 79;
            this.label5.Text = "Ghi chú";
            // 
            // txt_noikham
            // 
            this.txt_noikham.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_noikham.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noikham.Location = new System.Drawing.Point(270, 142);
            this.txt_noikham.Name = "txt_noikham";
            this.txt_noikham.Size = new System.Drawing.Size(228, 30);
            this.txt_noikham.TabIndex = 78;
            // 
            // txt_noicap
            // 
            this.txt_noicap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_noicap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_noicap.Location = new System.Drawing.Point(729, 44);
            this.txt_noicap.Name = "txt_noicap";
            this.txt_noicap.Size = new System.Drawing.Size(228, 30);
            this.txt_noicap.TabIndex = 77;
            // 
            // txt_baohiem
            // 
            this.txt_baohiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_baohiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_baohiem.Location = new System.Drawing.Point(270, 93);
            this.txt_baohiem.Name = "txt_baohiem";
            this.txt_baohiem.Size = new System.Drawing.Size(228, 30);
            this.txt_baohiem.TabIndex = 76;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 22);
            this.label3.TabIndex = 75;
            this.label3.Text = "Nơi khám bệnh";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(613, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nơi cấp";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 73;
            this.label1.Text = "Số bảo hiểm";
            // 
            // date_cap
            // 
            this.date_cap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_cap.CustomFormat = "dd/MM/yyyy";
            this.date_cap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_cap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_cap.Location = new System.Drawing.Point(729, 90);
            this.date_cap.Margin = new System.Windows.Forms.Padding(1);
            this.date_cap.Name = "date_cap";
            this.date_cap.Size = new System.Drawing.Size(228, 30);
            this.date_cap.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(613, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Ngày cấp";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 47);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 22);
            this.label7.TabIndex = 66;
            this.label7.Text = "Nhân viên";
            // 
            // sl_NhanVien
            // 
            this.sl_NhanVien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sl_NhanVien.Location = new System.Drawing.Point(270, 44);
            this.sl_NhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.sl_NhanVien.MenuManager = this.barManager1;
            this.sl_NhanVien.Name = "sl_NhanVien";
            this.sl_NhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sl_NhanVien.Properties.Appearance.Options.UseFont = true;
            this.sl_NhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sl_NhanVien.Properties.PopupView = this.searchLookUpEdit1View;
            this.sl_NhanVien.Size = new System.Drawing.Size(228, 28);
            this.sl_NhanVien.TabIndex = 56;
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
            // gv_baohiem
            // 
            this.gv_baohiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_baohiem.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gv_baohiem.Location = new System.Drawing.Point(0, 0);
            this.gv_baohiem.MainView = this.gcv_baohiem;
            this.gv_baohiem.Margin = new System.Windows.Forms.Padding(1);
            this.gv_baohiem.Name = "gv_baohiem";
            this.gv_baohiem.Size = new System.Drawing.Size(1026, 133);
            this.gv_baohiem.TabIndex = 1;
            this.gv_baohiem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_baohiem});
            // 
            // gcv_baohiem
            // 
            this.gcv_baohiem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DEL,
            this.ID,
            this.id_NhanVien,
            this.HoTen,
            this.so_BH,
            this.NoiCap,
            this.NgayCap,
            this.Noi_DK_KamBenh,
            this.GhiChu});
            this.gcv_baohiem.GridControl = this.gv_baohiem;
            this.gcv_baohiem.Name = "gcv_baohiem";
            this.gcv_baohiem.OptionsView.ShowGroupPanel = false;
            this.gcv_baohiem.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.gcv_baohiem_CustomDrawCell);
            this.gcv_baohiem.Click += new System.EventHandler(this.gcv_baohiem_Click);
            // 
            // DEL
            // 
            this.DEL.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DEL.AppearanceHeader.Options.UseFont = true;
            this.DEL.Caption = "DEL";
            this.DEL.FieldName = "DELETE_BY";
            this.DEL.MaxWidth = 50;
            this.DEL.MinWidth = 50;
            this.DEL.Name = "DEL";
            this.DEL.Visible = true;
            this.DEL.VisibleIndex = 0;
            this.DEL.Width = 50;
            // 
            // ID
            // 
            this.ID.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.AppearanceHeader.Options.UseFont = true;
            this.ID.Caption = "STT";
            this.ID.FieldName = "id_BaoHiem";
            this.ID.MaxWidth = 70;
            this.ID.MinWidth = 70;
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 1;
            this.ID.Width = 70;
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
            this.id_NhanVien.VisibleIndex = 2;
            this.id_NhanVien.Width = 200;
            // 
            // HoTen
            // 
            this.HoTen.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoTen.AppearanceHeader.Options.UseFont = true;
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HoTen";
            this.HoTen.MaxWidth = 250;
            this.HoTen.MinWidth = 250;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 3;
            this.HoTen.Width = 250;
            // 
            // so_BH
            // 
            this.so_BH.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.so_BH.AppearanceHeader.Options.UseFont = true;
            this.so_BH.Caption = "Số bảo hiểm";
            this.so_BH.FieldName = "So_BaoHiem";
            this.so_BH.MaxWidth = 250;
            this.so_BH.MinWidth = 250;
            this.so_BH.Name = "so_BH";
            this.so_BH.Visible = true;
            this.so_BH.VisibleIndex = 4;
            this.so_BH.Width = 250;
            // 
            // NoiCap
            // 
            this.NoiCap.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoiCap.AppearanceHeader.Options.UseFont = true;
            this.NoiCap.Caption = "Nơi cấp";
            this.NoiCap.FieldName = "NoiCap";
            this.NoiCap.MaxWidth = 300;
            this.NoiCap.MinWidth = 300;
            this.NoiCap.Name = "NoiCap";
            this.NoiCap.Visible = true;
            this.NoiCap.VisibleIndex = 5;
            this.NoiCap.Width = 300;
            // 
            // NgayCap
            // 
            this.NgayCap.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgayCap.AppearanceHeader.Options.UseFont = true;
            this.NgayCap.Caption = "Ngày cấp";
            this.NgayCap.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.NgayCap.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.NgayCap.FieldName = "NgayCap";
            this.NgayCap.MaxWidth = 100;
            this.NgayCap.MinWidth = 100;
            this.NgayCap.Name = "NgayCap";
            this.NgayCap.Visible = true;
            this.NgayCap.VisibleIndex = 6;
            this.NgayCap.Width = 100;
            // 
            // Noi_DK_KamBenh
            // 
            this.Noi_DK_KamBenh.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Noi_DK_KamBenh.AppearanceHeader.Options.UseFont = true;
            this.Noi_DK_KamBenh.Caption = "Nơi đăng ký phám bệnh";
            this.Noi_DK_KamBenh.FieldName = "Noi_DK_Kham_Benh";
            this.Noi_DK_KamBenh.MaxWidth = 400;
            this.Noi_DK_KamBenh.MinWidth = 400;
            this.Noi_DK_KamBenh.Name = "Noi_DK_KamBenh";
            this.Noi_DK_KamBenh.Visible = true;
            this.Noi_DK_KamBenh.VisibleIndex = 7;
            this.Noi_DK_KamBenh.Width = 400;
            // 
            // GhiChu
            // 
            this.GhiChu.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GhiChu.AppearanceHeader.Options.UseFont = true;
            this.GhiChu.Caption = "Ghi chú";
            this.GhiChu.FieldName = "GhiChu";
            this.GhiChu.MinWidth = 25;
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.Visible = true;
            this.GhiChu.VisibleIndex = 8;
            this.GhiChu.Width = 25;
            // 
            // F_BaoHiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 388);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "F_BaoHiem";
            this.Text = "Bảo hiểm";
            this.Load += new System.EventHandler(this.F_BaoHiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sl_NhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_baohiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_baohiem)).EndInit();
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
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_noikham;
        private System.Windows.Forms.TextBox txt_noicap;
        private System.Windows.Forms.TextBox txt_baohiem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_cap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit sl_NhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn cl_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn cl_TenNV;
        private DevExpress.XtraGrid.GridControl gv_baohiem;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_baohiem;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn id_NhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private DevExpress.XtraGrid.Columns.GridColumn so_BH;
        private DevExpress.XtraGrid.Columns.GridColumn NoiCap;
        private DevExpress.XtraGrid.Columns.GridColumn Noi_DK_KamBenh;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraGrid.Columns.GridColumn GhiChu;
        private DevExpress.XtraGrid.Columns.GridColumn DEL;
        private DevExpress.XtraGrid.Columns.GridColumn NgayCap;
    }
}