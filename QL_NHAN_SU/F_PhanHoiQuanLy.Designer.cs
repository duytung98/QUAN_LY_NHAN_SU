
namespace QL_NHAN_SU
{
    partial class F_PhanHoiQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_PhanHoiQuanLy));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblnhanvien = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_phanhoi = new System.Windows.Forms.RichTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_ngnhan = new System.Windows.Forms.ComboBox();
            this.tNhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qUAN_LY_NHAN_SUDataSet = new QL_NHAN_SU.QUAN_LY_NHAN_SUDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.t_NhanVienTableAdapter = new QL_NHAN_SU.QUAN_LY_NHAN_SUDataSetTableAdapters.T_NhanVienTableAdapter();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_NHAN_SUDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin phản hồi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 247);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(698, 70);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::QL_NHAN_SU.Properties.Resources.paper_plane1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(547, 9);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gửi";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lblnhanvien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 62);
            this.panel1.TabIndex = 3;
            // 
            // lblnhanvien
            // 
            this.lblnhanvien.AutoSize = true;
            this.lblnhanvien.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblnhanvien.Font = new System.Drawing.Font("Arial Narrow", 1.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnhanvien.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblnhanvien.Location = new System.Drawing.Point(585, 20);
            this.lblnhanvien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnhanvien.Name = "lblnhanvien";
            this.lblnhanvien.Size = new System.Drawing.Size(0, 4);
            this.lblnhanvien.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 62);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(698, 185);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_phanhoi);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 61);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(698, 124);
            this.panel5.TabIndex = 1;
            // 
            // txt_phanhoi
            // 
            this.txt_phanhoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_phanhoi.Location = new System.Drawing.Point(0, 0);
            this.txt_phanhoi.Name = "txt_phanhoi";
            this.txt_phanhoi.Size = new System.Drawing.Size(698, 124);
            this.txt_phanhoi.TabIndex = 0;
            this.txt_phanhoi.Text = "";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cb_ngnhan);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(698, 61);
            this.panel4.TabIndex = 0;
            // 
            // cb_ngnhan
            // 
            this.cb_ngnhan.DataSource = this.tNhanVienBindingSource;
            this.cb_ngnhan.DisplayMember = "id_NhanVien";
            this.cb_ngnhan.FormattingEnabled = true;
            this.cb_ngnhan.Location = new System.Drawing.Point(180, 16);
            this.cb_ngnhan.Name = "cb_ngnhan";
            this.cb_ngnhan.Size = new System.Drawing.Size(366, 32);
            this.cb_ngnhan.TabIndex = 1;
            this.cb_ngnhan.ValueMember = "id_NhanVien";
            // 
            // tNhanVienBindingSource
            // 
            this.tNhanVienBindingSource.DataMember = "T_NhanVien";
            this.tNhanVienBindingSource.DataSource = this.qUAN_LY_NHAN_SUDataSet;
            // 
            // qUAN_LY_NHAN_SUDataSet
            // 
            this.qUAN_LY_NHAN_SUDataSet.DataSetName = "QUAN_LY_NHAN_SUDataSet";
            this.qUAN_LY_NHAN_SUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người nhận";
            // 
            // t_NhanVienTableAdapter
            // 
            this.t_NhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // F_PhanHoiQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 317);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_PhanHoiQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phản hồi";
            this.Load += new System.EventHandler(this.F_PhanHoiQuanLy_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tNhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUAN_LY_NHAN_SUDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblnhanvien;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RichTextBox txt_phanhoi;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_ngnhan;
        private System.Windows.Forms.Label label2;
        private QUAN_LY_NHAN_SUDataSet qUAN_LY_NHAN_SUDataSet;
        private System.Windows.Forms.BindingSource tNhanVienBindingSource;
        private QUAN_LY_NHAN_SUDataSetTableAdapters.T_NhanVienTableAdapter t_NhanVienTableAdapter;
    }
}