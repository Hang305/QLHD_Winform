namespace QLHD
{
    partial class FormMain
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
            if ( disposing && ( components != null ) )
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLHDDataSet = new QLHD.QLHDDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemCongTy = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.ItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.qLHDDataSet;
            this.bindingSource1.Position = 0;
            // 
            // qLHDDataSet
            // 
            this.qLHDDataSet.DataSetName = "QLHDDataSet";
            this.qLHDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDanhMuc,
            this.MenuItemHoaDon,
            this.ItemExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(949, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemDanhMuc
            // 
            this.MenuItemDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ItemHangHoa,
            this.ItemNhanVien,
            this.ItemKhachHang,
            this.ItemCongTy,
            this.ItemHoaDon});
            this.MenuItemDanhMuc.Name = "MenuItemDanhMuc";
            this.MenuItemDanhMuc.Size = new System.Drawing.Size(74, 20);
            this.MenuItemDanhMuc.Text = "Danh mục";
            // 
            // ItemHangHoa
            // 
            this.ItemHangHoa.Name = "ItemHangHoa";
            this.ItemHangHoa.Size = new System.Drawing.Size(180, 22);
            this.ItemHangHoa.Text = "Hàng hóa";
            this.ItemHangHoa.Click += new System.EventHandler(this.ItemHangHoa_Click);
            // 
            // ItemNhanVien
            // 
            this.ItemNhanVien.Name = "ItemNhanVien";
            this.ItemNhanVien.Size = new System.Drawing.Size(180, 22);
            this.ItemNhanVien.Text = "Nhân viên";
            this.ItemNhanVien.Click += new System.EventHandler(this.ItemNhanVien_Click);
            // 
            // ItemKhachHang
            // 
            this.ItemKhachHang.Name = "ItemKhachHang";
            this.ItemKhachHang.Size = new System.Drawing.Size(180, 22);
            this.ItemKhachHang.Text = "Khách hàng";
            this.ItemKhachHang.Click += new System.EventHandler(this.ItemKhachHang_Click);
            // 
            // ItemCongTy
            // 
            this.ItemCongTy.Name = "ItemCongTy";
            this.ItemCongTy.Size = new System.Drawing.Size(180, 22);
            this.ItemCongTy.Text = "Công ty";
            this.ItemCongTy.Click += new System.EventHandler(this.ItemCongTy_Click);
            // 
            // ItemHoaDon
            // 
            this.ItemHoaDon.Name = "ItemHoaDon";
            this.ItemHoaDon.Size = new System.Drawing.Size(180, 22);
            this.ItemHoaDon.Text = "Hóa đơn";
            this.ItemHoaDon.Click += new System.EventHandler(this.ItemHoaDon_Click);
            // 
            // MenuItemHoaDon
            // 
            this.MenuItemHoaDon.Name = "MenuItemHoaDon";
            this.MenuItemHoaDon.Size = new System.Drawing.Size(65, 20);
            this.MenuItemHoaDon.Text = "Hóa đơn";
            // 
            // ItemExit
            // 
            this.ItemExit.Name = "ItemExit";
            this.ItemExit.Size = new System.Drawing.Size(49, 20);
            this.ItemExit.Text = "Thoát";
            this.ItemExit.Click += new System.EventHandler(this.ItemExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berkshire Swash", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tomato;
            this.label1.Location = new System.Drawing.Point(222, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 80);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý bán hàng";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 459);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLHDDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private QLHDDataSet qLHDDataSet;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem ItemHangHoa;
        private System.Windows.Forms.ToolStripMenuItem ItemNhanVien;
        private System.Windows.Forms.ToolStripMenuItem ItemKhachHang;
        private System.Windows.Forms.ToolStripMenuItem ItemCongTy;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHoaDon;
        private System.Windows.Forms.ToolStripMenuItem ItemExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem ItemHoaDon;
    }
}

