
namespace QL_NHAN_SU.LichLamViec
{
    partial class F_LichLamviecChoNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LichLamviecChoNV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnhanvien = new DevExpress.XtraEditors.LabelControl();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgv_lichlamviec = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichlamviec)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 82);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(283, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lịch làm việc";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblnhanvien);
            this.panel2.Controls.Add(this.cb_nam);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cb_thang);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 69);
            this.panel2.TabIndex = 3;
            // 
            // lblnhanvien
            // 
            this.lblnhanvien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblnhanvien.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhanvien.Appearance.ForeColor = System.Drawing.SystemColors.Control;
            this.lblnhanvien.Appearance.Options.UseFont = true;
            this.lblnhanvien.Appearance.Options.UseForeColor = true;
            this.lblnhanvien.Location = new System.Drawing.Point(661, 24);
            this.lblnhanvien.Name = "lblnhanvien";
            this.lblnhanvien.Size = new System.Drawing.Size(127, 26);
            this.lblnhanvien.TabIndex = 4;
            this.lblnhanvien.Text = "Mã nhân viên";
            // 
            // cb_nam
            // 
            this.cb_nam.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Items.AddRange(new object[] {
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
            "2044",
            "2035",
            "2036",
            "2037",
            "2038",
            "2039",
            "2040"});
            this.cb_nam.Location = new System.Drawing.Point(399, 20);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(142, 34);
            this.cb_nam.TabIndex = 3;
            this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(309, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm";
            // 
            // cb_thang
            // 
            this.cb_thang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Items.AddRange(new object[] {
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
            this.cb_thang.Location = new System.Drawing.Point(154, 20);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(121, 34);
            this.cb_thang.TabIndex = 1;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgv_lichlamviec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 151);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 299);
            this.panel3.TabIndex = 4;
            // 
            // dgv_lichlamviec
            // 
            this.dgv_lichlamviec.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgv_lichlamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_lichlamviec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_lichlamviec.Location = new System.Drawing.Point(0, 0);
            this.dgv_lichlamviec.Name = "dgv_lichlamviec";
            this.dgv_lichlamviec.RowHeadersWidth = 51;
            this.dgv_lichlamviec.RowTemplate.Height = 24;
            this.dgv_lichlamviec.Size = new System.Drawing.Size(800, 299);
            this.dgv_lichlamviec.TabIndex = 3;
            // 
            // F_LichLamviecChoNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_LichLamviecChoNV";
            this.Text = "Lịch làm việc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_LichLamviecChoNV_FormClosed);
            this.Load += new System.EventHandler(this.F_LichLamviecChoNV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_lichlamviec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgv_lichlamviec;
        private DevExpress.XtraEditors.LabelControl lblnhanvien;
    }
}