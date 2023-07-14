
namespace QL_NHAN_SU.ChamCong
{
    partial class F_LoaiCong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_LoaiCong));
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
            this.btn_in = new DevExpress.XtraBars.BarButtonItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.sp_hesocong = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_loaicong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gc_conglam = new DevExpress.XtraGrid.GridControl();
            this.gcv_conglam = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id_LC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Ten_Loaica = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HeSoCa = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_hesocong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_conglam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_conglam)).BeginInit();
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
            this.barDockControlTop.Size = new System.Drawing.Size(823, 36);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 398);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlBottom.Size = new System.Drawing.Size(823, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 36);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 362);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(823, 36);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 362);
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
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sp_hesocong);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_loaicong);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gc_conglam);
            this.splitContainer1.Size = new System.Drawing.Size(823, 362);
            this.splitContainer1.SplitterDistance = 67;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // sp_hesocong
            // 
            this.sp_hesocong.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.sp_hesocong.Location = new System.Drawing.Point(537, 22);
            this.sp_hesocong.MenuManager = this.barManager1;
            this.sp_hesocong.Name = "sp_hesocong";
            this.sp_hesocong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sp_hesocong.Properties.Appearance.Options.UseFont = true;
            this.sp_hesocong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sp_hesocong.Size = new System.Drawing.Size(153, 32);
            this.sp_hesocong.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(379, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hệ số công";
            // 
            // txt_loaicong
            // 
            this.txt_loaicong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_loaicong.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loaicong.Location = new System.Drawing.Point(174, 22);
            this.txt_loaicong.Margin = new System.Windows.Forms.Padding(1);
            this.txt_loaicong.Name = "txt_loaicong";
            this.txt_loaicong.Size = new System.Drawing.Size(172, 34);
            this.txt_loaicong.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "Loại công";
            // 
            // gc_conglam
            // 
            this.gc_conglam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_conglam.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gc_conglam.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gc_conglam.Location = new System.Drawing.Point(0, 0);
            this.gc_conglam.MainView = this.gcv_conglam;
            this.gc_conglam.Margin = new System.Windows.Forms.Padding(1);
            this.gc_conglam.Name = "gc_conglam";
            this.gc_conglam.Size = new System.Drawing.Size(823, 291);
            this.gc_conglam.TabIndex = 2;
            this.gc_conglam.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gcv_conglam});
            this.gc_conglam.Click += new System.EventHandler(this.gc_conglam_Click);
            // 
            // gcv_conglam
            // 
            this.gcv_conglam.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_conglam.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gcv_conglam.AppearancePrint.EvenRow.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcv_conglam.AppearancePrint.EvenRow.Options.UseFont = true;
            this.gcv_conglam.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id_LC,
            this.Ten_Loaica,
            this.HeSoCa});
            this.gcv_conglam.CustomizationFormBounds = new System.Drawing.Rectangle(678, 477, 314, 325);
            this.gcv_conglam.DetailHeight = 414;
            this.gcv_conglam.GridControl = this.gc_conglam;
            this.gcv_conglam.Name = "gcv_conglam";
            this.gcv_conglam.OptionsPrint.EnableAppearanceEvenRow = true;
            this.gcv_conglam.OptionsView.ShowFooter = true;
            this.gcv_conglam.OptionsView.ShowGroupPanel = false;
            this.gcv_conglam.Click += new System.EventHandler(this.gcv_conglam_Click);
            // 
            // id_LC
            // 
            this.id_LC.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_LC.AppearanceCell.Options.UseFont = true;
            this.id_LC.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_LC.AppearanceHeader.Options.UseFont = true;
            this.id_LC.Caption = "ID loại công";
            this.id_LC.FieldName = "id_LoaiCong";
            this.id_LC.MaxWidth = 200;
            this.id_LC.MinWidth = 200;
            this.id_LC.Name = "id_LC";
            this.id_LC.Visible = true;
            this.id_LC.VisibleIndex = 0;
            this.id_LC.Width = 200;
            // 
            // Ten_Loaica
            // 
            this.Ten_Loaica.AppearanceCell.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_Loaica.AppearanceCell.Options.UseFont = true;
            this.Ten_Loaica.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ten_Loaica.AppearanceHeader.Options.UseFont = true;
            this.Ten_Loaica.Caption = "Tên loại công";
            this.Ten_Loaica.FieldName = "Ten_LoaiCong";
            this.Ten_Loaica.MaxWidth = 300;
            this.Ten_Loaica.MinWidth = 300;
            this.Ten_Loaica.Name = "Ten_Loaica";
            this.Ten_Loaica.Visible = true;
            this.Ten_Loaica.VisibleIndex = 1;
            this.Ten_Loaica.Width = 300;
            // 
            // HeSoCa
            // 
            this.HeSoCa.AppearanceHeader.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeSoCa.AppearanceHeader.Options.UseFont = true;
            this.HeSoCa.Caption = "Hệ số";
            this.HeSoCa.FieldName = "HeSo";
            this.HeSoCa.MaxWidth = 200;
            this.HeSoCa.MinWidth = 200;
            this.HeSoCa.Name = "HeSoCa";
            this.HeSoCa.Visible = true;
            this.HeSoCa.VisibleIndex = 2;
            this.HeSoCa.Width = 200;
            // 
            // F_LoaiCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 398);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "F_LoaiCong";
            this.Text = "Loại công";
            this.Load += new System.EventHandler(this.F_LoaiCong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_hesocong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_conglam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcv_conglam)).EndInit();
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
        private DevExpress.XtraEditors.SpinEdit sp_hesocong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_loaicong;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gc_conglam;
        private DevExpress.XtraGrid.Views.Grid.GridView gcv_conglam;
        private DevExpress.XtraGrid.Columns.GridColumn id_LC;
        private DevExpress.XtraGrid.Columns.GridColumn Ten_Loaica;
        private DevExpress.XtraGrid.Columns.GridColumn HeSoCa;
    }
}