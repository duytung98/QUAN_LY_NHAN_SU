
namespace QL_NHAN_SU.ChamCong
{
    partial class F_CapNhatNgayCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_CapNhatNgayCong));
            this.btn_capnhat = new DevExpress.XtraEditors.SimpleButton();
            this.cdr_ngaycong = new System.Windows.Forms.MonthCalendar();
            this.radio_chamcong = new DevExpress.XtraEditors.GroupControl();
            this.rdg_ChamCong = new DevExpress.XtraEditors.RadioGroup();
            this.radio_ThoigianNghi = new DevExpress.XtraEditors.GroupControl();
            this.rdg_ngaynghi = new DevExpress.XtraEditors.RadioGroup();
            this.btn_thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bnt_thongtin = new DevExpress.XtraEditors.GroupControl();
            this.lbl_hoten = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.radio_chamcong)).BeginInit();
            this.radio_chamcong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_ChamCong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_ThoigianNghi)).BeginInit();
            this.radio_ThoigianNghi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rdg_ngaynghi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_thongtin)).BeginInit();
            this.bnt_thongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_capnhat
            // 
            this.btn_capnhat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_capnhat.ImageOptions.SvgImage")));
            this.btn_capnhat.Location = new System.Drawing.Point(315, 281);
            this.btn_capnhat.Name = "btn_capnhat";
            this.btn_capnhat.Size = new System.Drawing.Size(111, 34);
            this.btn_capnhat.TabIndex = 0;
            this.btn_capnhat.Text = "Cập nhật";
            this.btn_capnhat.Click += new System.EventHandler(this.btn_capnhat_Click);
            // 
            // cdr_ngaycong
            // 
            this.cdr_ngaycong.Location = new System.Drawing.Point(18, 3);
            this.cdr_ngaycong.Name = "cdr_ngaycong";
            this.cdr_ngaycong.TabIndex = 1;
            this.cdr_ngaycong.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.cdr_ngaycong_DateSelected);
            // 
            // radio_chamcong
            // 
            this.radio_chamcong.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_chamcong.AppearanceCaption.Options.UseFont = true;
            this.radio_chamcong.Controls.Add(this.rdg_ChamCong);
            this.radio_chamcong.Location = new System.Drawing.Point(315, 12);
            this.radio_chamcong.Name = "radio_chamcong";
            this.radio_chamcong.Size = new System.Drawing.Size(231, 117);
            this.radio_chamcong.TabIndex = 2;
            this.radio_chamcong.Text = "Chấm công";
            // 
            // rdg_ChamCong
            // 
            this.rdg_ChamCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdg_ChamCong.EditValue = "P";
            this.rdg_ChamCong.Location = new System.Drawing.Point(2, 28);
            this.rdg_ChamCong.Name = "rdg_ChamCong";
            this.rdg_ChamCong.Properties.Columns = 2;
            this.rdg_ChamCong.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("P", "Nghỉ phép"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("V", "Vắng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NL", "Ngày lễ"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("CT", "Công tác")});
            this.rdg_ChamCong.Size = new System.Drawing.Size(227, 87);
            this.rdg_ChamCong.TabIndex = 0;
            // 
            // radio_ThoigianNghi
            // 
            this.radio_ThoigianNghi.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_ThoigianNghi.AppearanceCaption.Options.UseFont = true;
            this.radio_ThoigianNghi.Controls.Add(this.rdg_ngaynghi);
            this.radio_ThoigianNghi.Location = new System.Drawing.Point(317, 135);
            this.radio_ThoigianNghi.Name = "radio_ThoigianNghi";
            this.radio_ThoigianNghi.Size = new System.Drawing.Size(231, 114);
            this.radio_ThoigianNghi.TabIndex = 3;
            this.radio_ThoigianNghi.Text = "Thời gian nghỉ";
            // 
            // rdg_ngaynghi
            // 
            this.rdg_ngaynghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rdg_ngaynghi.EditValue = "NN";
            this.rdg_ngaynghi.Location = new System.Drawing.Point(2, 28);
            this.rdg_ngaynghi.Name = "rdg_ngaynghi";
            this.rdg_ngaynghi.Properties.Columns = 2;
            this.rdg_ngaynghi.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("S", "Sáng"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("C", "Chiều"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("NN", "Cả ngày")});
            this.rdg_ngaynghi.Size = new System.Drawing.Size(227, 84);
            this.rdg_ngaynghi.TabIndex = 0;
            // 
            // btn_thoat
            // 
            this.btn_thoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_thoat.ImageOptions.SvgImage")));
            this.btn_thoat.Location = new System.Drawing.Point(444, 281);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 34);
            this.btn_thoat.TabIndex = 4;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // bnt_thongtin
            // 
            this.bnt_thongtin.Controls.Add(this.lbl_hoten);
            this.bnt_thongtin.Controls.Add(this.label3);
            this.bnt_thongtin.Controls.Add(this.lbl_nv);
            this.bnt_thongtin.Controls.Add(this.label1);
            this.bnt_thongtin.Location = new System.Drawing.Point(12, 222);
            this.bnt_thongtin.Name = "bnt_thongtin";
            this.bnt_thongtin.Size = new System.Drawing.Size(268, 114);
            this.bnt_thongtin.TabIndex = 5;
            this.bnt_thongtin.Text = "Thông tin";
            // 
            // lbl_hoten
            // 
            this.lbl_hoten.AutoSize = true;
            this.lbl_hoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hoten.ForeColor = System.Drawing.Color.Red;
            this.lbl_hoten.Location = new System.Drawing.Point(91, 66);
            this.lbl_hoten.Name = "lbl_hoten";
            this.lbl_hoten.Size = new System.Drawing.Size(56, 17);
            this.lbl_hoten.TabIndex = 9;
            this.lbl_hoten.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ Tên: ";
            // 
            // lbl_nv
            // 
            this.lbl_nv.AutoSize = true;
            this.lbl_nv.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nv.ForeColor = System.Drawing.Color.Red;
            this.lbl_nv.Location = new System.Drawing.Point(91, 42);
            this.lbl_nv.Name = "lbl_nv";
            this.lbl_nv.Size = new System.Drawing.Size(65, 17);
            this.lbl_nv.TabIndex = 7;
            this.lbl_nv.Text = "Mã NV: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mã NV: ";
            // 
            // F_CapNhatNgayCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 348);
            this.Controls.Add(this.bnt_thongtin);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.radio_ThoigianNghi);
            this.Controls.Add(this.radio_chamcong);
            this.Controls.Add(this.cdr_ngaycong);
            this.Controls.Add(this.btn_capnhat);
            this.Name = "F_CapNhatNgayCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập nhật ngày công";
            this.Load += new System.EventHandler(this.F_CapNhatNgayCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radio_chamcong)).EndInit();
            this.radio_chamcong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdg_ChamCong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radio_ThoigianNghi)).EndInit();
            this.radio_ThoigianNghi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rdg_ngaynghi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnt_thongtin)).EndInit();
            this.bnt_thongtin.ResumeLayout(false);
            this.bnt_thongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_capnhat;
        private System.Windows.Forms.MonthCalendar cdr_ngaycong;
        private DevExpress.XtraEditors.GroupControl radio_chamcong;
        private DevExpress.XtraEditors.RadioGroup rdg_ChamCong;
        private DevExpress.XtraEditors.GroupControl radio_ThoigianNghi;
        private DevExpress.XtraEditors.RadioGroup rdg_ngaynghi;
        private DevExpress.XtraEditors.SimpleButton btn_thoat;
        private DevExpress.XtraEditors.GroupControl bnt_thongtin;
        private System.Windows.Forms.Label lbl_hoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nv;
        private System.Windows.Forms.Label label1;
    }
}