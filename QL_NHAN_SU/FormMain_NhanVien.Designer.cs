
namespace QL_NHAN_SU
{
    partial class FormMain_NhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_NhanVien));
            DevExpress.XtraEditors.TableLayout.ItemTemplateBase itemTemplateBase1 = new DevExpress.XtraEditors.TableLayout.ItemTemplateBase();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement1 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement2 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement3 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TemplatedItemElement templatedItemElement4 = new DevExpress.XtraEditors.TableLayout.TemplatedItemElement();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_thongtinnv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_lichlamviec = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_phanhoi = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btbThongTin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lbl_nhanvien = new DevExpress.XtraEditors.LabelControl();
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.list_phanhoi = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.list_phanhoi)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_thongtinnv,
            this.btn_DoiMK,
            this.btn_DangXuat,
            this.btn_lichlamviec,
            this.barButtonItem1,
            this.btn_phanhoi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(4);
            this.ribbon.MaxItemId = 11;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.btbThongTin});
            this.ribbon.Size = new System.Drawing.Size(1629, 209);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // btn_thongtinnv
            // 
            this.btn_thongtinnv.Caption = "Thông tin cá nhân";
            this.btn_thongtinnv.Id = 1;
            this.btn_thongtinnv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongtinnv.ImageOptions.Image")));
            this.btn_thongtinnv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_thongtinnv.ImageOptions.LargeImage")));
            this.btn_thongtinnv.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnv.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_thongtinnv.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnv.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_thongtinnv.Name = "btn_thongtinnv";
            this.btn_thongtinnv.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_thongtinnv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thongtinnv_ItemClick);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Caption = "Đổi mật khẩu                  ";
            this.btn_DoiMK.Id = 2;
            this.btn_DoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMK.ImageOptions.Image")));
            this.btn_DoiMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMK.ImageOptions.LargeImage")));
            this.btn_DoiMK.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_DoiMK.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiMK_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất ";
            this.btn_DangXuat.Id = 3;
            this.btn_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DangXuat.ImageOptions.SvgImage")));
            this.btn_DangXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_DangXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_DangXuat.Name = "btn_DangXuat";
            this.btn_DangXuat.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DangXuat_ItemClick);
            // 
            // btn_lichlamviec
            // 
            this.btn_lichlamviec.Caption = "Lịch làm việc";
            this.btn_lichlamviec.Id = 4;
            this.btn_lichlamviec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_lichlamviec.ImageOptions.Image")));
            this.btn_lichlamviec.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_lichlamviec.ImageOptions.LargeImage")));
            this.btn_lichlamviec.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichlamviec.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_lichlamviec.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichlamviec.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_lichlamviec.Name = "btn_lichlamviec";
            this.btn_lichlamviec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_lichlamviec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_lichlamviec_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Ngày công";
            this.barButtonItem1.Id = 9;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.ItemAppearance.Hovered.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem1.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem1.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btn_phanhoi
            // 
            this.btn_phanhoi.Caption = "Phản hồi";
            this.btn_phanhoi.Id = 10;
            this.btn_phanhoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_phanhoi.ImageOptions.Image")));
            this.btn_phanhoi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_phanhoi.ImageOptions.LargeImage")));
            this.btn_phanhoi.ItemAppearance.Normal.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phanhoi.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_phanhoi.Name = "btn_phanhoi";
            this.btn_phanhoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_phanhoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_phanhoi_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeThong.Appearance.Options.UseFont = true;
            this.HeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.HeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HeThong.ImageOptions.Image")));
            this.HeThong.Name = "HeThong";
            this.HeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DoiMK, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_DangXuat, true);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // btbThongTin
            // 
            this.btbThongTin.Appearance.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbThongTin.Appearance.Options.UseFont = true;
            this.btbThongTin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.btbThongTin.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btbThongTin.ImageOptions.Image")));
            this.btbThongTin.Name = "btbThongTin";
            this.btbThongTin.Text = "Thông tin";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_thongtinnv);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_lichlamviec, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem1, true);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_phanhoi, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 525);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1629, 30);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.lbl_nhanvien.Appearance.Font = new System.Drawing.Font("Times New Roman", 1.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(109)))), ((int)(((byte)(156)))));
            this.lbl_nhanvien.Appearance.Options.UseBackColor = true;
            this.lbl_nhanvien.Appearance.Options.UseFont = true;
            this.lbl_nhanvien.Appearance.Options.UseForeColor = true;
            this.lbl_nhanvien.Location = new System.Drawing.Point(1258, 30);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(0, 2);
            this.lbl_nhanvien.TabIndex = 8;
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.StatusBar",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.dockPanel1.ID = new System.Guid("d7726626-6273-49a9-8227-11f94b2b5467");
            this.dockPanel1.Location = new System.Drawing.Point(1397, 209);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.OriginalSize = new System.Drawing.Size(232, 200);
            this.dockPanel1.Size = new System.Drawing.Size(232, 316);
            this.dockPanel1.Text = "Thông báo";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.groupControl1);
            this.dockPanel1_Container.Location = new System.Drawing.Point(6, 32);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(222, 280);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.list_phanhoi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(222, 280);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Phản hồi từ quản lý";
            // 
            // list_phanhoi
            // 
            this.list_phanhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list_phanhoi.ItemHeight = 112;
            this.list_phanhoi.Location = new System.Drawing.Point(2, 28);
            this.list_phanhoi.Name = "list_phanhoi";
            this.list_phanhoi.Size = new System.Drawing.Size(218, 250);
            this.list_phanhoi.TabIndex = 0;
            templatedItemElement1.FieldName = "id_NhanVien";
            templatedItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement1.Text = "id_NhanVien";
            templatedItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            templatedItemElement2.FieldName = "HoTen";
            templatedItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement2.Text = "HoTen";
            templatedItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            templatedItemElement3.AnchorElementIndex = 0;
            templatedItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            templatedItemElement3.Appearance.Normal.Options.UseFont = true;
            templatedItemElement3.FieldName = "NoiDung";
            templatedItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement3.Text = "NoiDung";
            templatedItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            templatedItemElement4.AnchorElementIndex = 2;
            templatedItemElement4.FieldName = "ThoiGianGui";
            templatedItemElement4.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            templatedItemElement4.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            templatedItemElement4.Text = "ThoiGianGui";
            templatedItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            itemTemplateBase1.Elements.Add(templatedItemElement1);
            itemTemplateBase1.Elements.Add(templatedItemElement2);
            itemTemplateBase1.Elements.Add(templatedItemElement3);
            itemTemplateBase1.Elements.Add(templatedItemElement4);
            itemTemplateBase1.Name = "thongbao";
            itemTemplateBase1.Rows.Add(tableRowDefinition1);
            this.list_phanhoi.Templates.Add(itemTemplateBase1);
            this.list_phanhoi.CustomizeItem += new DevExpress.XtraEditors.CustomizeTemplatedItemEventHandler(this.list_phanhoi_CustomizeItem);
            // 
            // FormMain_NhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1629, 555);
            this.Controls.Add(this.lbl_nhanvien);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormMain_NhanVien.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain_NhanVien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Thông tin nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.list_phanhoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage HeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage btbThongTin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarButtonItem btn_thongtinnv;
        private DevExpress.XtraBars.BarButtonItem btn_DoiMK;
        private DevExpress.XtraBars.BarButtonItem btn_DangXuat;
        private DevExpress.XtraBars.BarButtonItem btn_lichlamviec;
        private DevExpress.XtraEditors.LabelControl lbl_nhanvien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btn_phanhoi;
        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ListBoxControl list_phanhoi;
    }
}