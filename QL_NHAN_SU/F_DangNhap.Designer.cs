
namespace QL_NHAN_SU
{
    partial class F_DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DangNhap));
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_hienthimk = new System.Windows.Forms.CheckBox();
            this.cb_phanquyen = new System.Windows.Forms.ComboBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_dangnhap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.btn_dangnhap);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.cb_hienthimk);
            this.panel4.Controls.Add(this.cb_phanquyen);
            this.panel4.Controls.Add(this.txt_matkhau);
            this.panel4.Controls.Add(this.txt_taikhoan);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(845, 297);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(633, 344);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(186, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 37);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đăng nhập hệ thống";
            // 
            // cb_hienthimk
            // 
            this.cb_hienthimk.AutoSize = true;
            this.cb_hienthimk.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hienthimk.Location = new System.Drawing.Point(214, 217);
            this.cb_hienthimk.Name = "cb_hienthimk";
            this.cb_hienthimk.Size = new System.Drawing.Size(157, 23);
            this.cb_hienthimk.TabIndex = 6;
            this.cb_hienthimk.Text = "Hiển thị mật khẩu";
            this.cb_hienthimk.UseVisualStyleBackColor = true;
            this.cb_hienthimk.CheckedChanged += new System.EventHandler(this.cb_hienthimk_CheckedChanged);
            // 
            // cb_phanquyen
            // 
            this.cb_phanquyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_phanquyen.FormattingEnabled = true;
            this.cb_phanquyen.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cb_phanquyen.Location = new System.Drawing.Point(214, 90);
            this.cb_phanquyen.Name = "cb_phanquyen";
            this.cb_phanquyen.Size = new System.Drawing.Size(288, 30);
            this.cb_phanquyen.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_matkhau.Location = new System.Drawing.Point(214, 169);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(288, 30);
            this.txt_matkhau.TabIndex = 4;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_taikhoan.Location = new System.Drawing.Point(214, 131);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(288, 30);
            this.txt_taikhoan.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1515, 802);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = global::QL_NHAN_SU.Properties.Resources._2;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 717);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1515, 85);
            this.panel6.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::QL_NHAN_SU.Properties.Resources.header_hpc_20;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1515, 201);
            this.panel5.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackgroundImage = global::QL_NHAN_SU.Properties.Resources.san_truong;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(41, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(771, 495);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Image = global::QL_NHAN_SU.Properties.Resources.cancel;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(415, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_dangnhap.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_dangnhap.Image = global::QL_NHAN_SU.Properties.Resources.enter;
            this.btn_dangnhap.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dangnhap.Location = new System.Drawing.Point(213, 266);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Size = new System.Drawing.Size(142, 45);
            this.btn_dangnhap.TabIndex = 5;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dangnhap.UseVisualStyleBackColor = false;
            this.btn_dangnhap.Click += new System.EventHandler(this.btn_dangnhap_Click);
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Image = global::QL_NHAN_SU.Properties.Resources.home1;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(58, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phân quyền";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Image = global::QL_NHAN_SU.Properties.Resources.padlock;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(62, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Image = global::QL_NHAN_SU.Properties.Resources.user;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(62, 134);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(127, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::QL_NHAN_SU.Properties.Resources.header_logo_hpc_9_3;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1404, 68);
            this.panel1.TabIndex = 0;
            // 
            // F_DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1515, 802);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập tài khoản";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_dangnhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_hienthimk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox cb_phanquyen;
        public System.Windows.Forms.TextBox txt_matkhau;
        public System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Button button1;
    }
}