
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_NhanVien));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btn_thongtinnv = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DoiMK = new DevExpress.XtraBars.BarButtonItem();
            this.btn_DangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btn_lichlamviec = new DevExpress.XtraBars.BarButtonItem();
            this.HeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btbThongTin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.lbl_nhanvien = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btn_thongtinnv,
            this.btn_DoiMK,
            this.btn_DangXuat,
            this.btn_lichlamviec});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbon.MaxItemId = 9;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.HeThong,
            this.btbThongTin});
            this.ribbon.Size = new System.Drawing.Size(1833, 217);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btn_thongtinnv
            // 
            this.btn_thongtinnv.Caption = "Thông tin cá nhân";
            this.btn_thongtinnv.Id = 1;
            this.btn_thongtinnv.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongtinnv.ImageOptions.Image")));
            this.btn_thongtinnv.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_thongtinnv.ImageOptions.LargeImage")));
            this.btn_thongtinnv.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnv.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_thongtinnv.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thongtinnv.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_thongtinnv.Name = "btn_thongtinnv";
            this.btn_thongtinnv.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_thongtinnv.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_thongtinnv_ItemClick);
            // 
            // btn_DoiMK
            // 
            this.btn_DoiMK.Caption = "Đổi mật khẩu";
            this.btn_DoiMK.Id = 2;
            this.btn_DoiMK.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_DoiMK.ImageOptions.Image")));
            this.btn_DoiMK.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_DoiMK.ImageOptions.LargeImage")));
            this.btn_DoiMK.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_DoiMK.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DoiMK.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_DoiMK.Name = "btn_DoiMK";
            this.btn_DoiMK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_DoiMK.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_DoiMK_ItemClick);
            // 
            // btn_DangXuat
            // 
            this.btn_DangXuat.Caption = "Đăng xuất";
            this.btn_DangXuat.Id = 3;
            this.btn_DangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_DangXuat.ImageOptions.SvgImage")));
            this.btn_DangXuat.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_DangXuat.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_DangXuat.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_lichlamviec.ItemAppearance.Hovered.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichlamviec.ItemAppearance.Hovered.Options.UseFont = true;
            this.btn_lichlamviec.ItemAppearance.Normal.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lichlamviec.ItemAppearance.Normal.Options.UseFont = true;
            this.btn_lichlamviec.Name = "btn_lichlamviec";
            this.btn_lichlamviec.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_lichlamviec.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_lichlamviec_ItemClick);
            // 
            // HeThong
            // 
            this.HeThong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btbThongTin.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbThongTin.Appearance.Options.UseFont = true;
            this.btbThongTin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.btbThongTin.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btbThongTin.ImageOptions.SvgImage")));
            this.btbThongTin.Name = "btbThongTin";
            this.btbThongTin.Text = "Thông tin";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_thongtinnv);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_lichlamviec, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 497);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1833, 30);
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "ribbonPage4";
            // 
            // lbl_nhanvien
            // 
            this.lbl_nhanvien.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_nhanvien.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhanvien.Appearance.ForeColor = System.Drawing.Color.White;
            this.lbl_nhanvien.Appearance.Options.UseBackColor = true;
            this.lbl_nhanvien.Appearance.Options.UseFont = true;
            this.lbl_nhanvien.Appearance.Options.UseForeColor = true;
            this.lbl_nhanvien.Location = new System.Drawing.Point(1699, 57);
            this.lbl_nhanvien.Name = "lbl_nhanvien";
            this.lbl_nhanvien.Size = new System.Drawing.Size(96, 26);
            this.lbl_nhanvien.TabIndex = 8;
            this.lbl_nhanvien.Text = "Nhân viên";
            // 
            // FormMain_NhanVien
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1833, 527);
            this.Controls.Add(this.lbl_nhanvien);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FormMain_NhanVien.IconOptions.LargeImage")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FormMain_NhanVien";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Thông tin nhân viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_NhanVien_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_NhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
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
    }
}