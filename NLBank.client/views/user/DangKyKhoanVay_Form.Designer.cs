namespace NLBank.client.views.user
{
    partial class DangKyKhoanVay_Form
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
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_mucdich = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_sotienvay = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.cbx_loaitien = new MaterialSkin.Controls.MaterialComboBox();
            this.cbx_loaikv = new MaterialSkin.Controls.MaterialComboBox();
            this.dg_tsdb = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tsdb)).BeginInit();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(42, 181);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Mục đích vay ";
            // 
            // txt_mucdich
            // 
            this.txt_mucdich.AnimateReadOnly = false;
            this.txt_mucdich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mucdich.Depth = 0;
            this.txt_mucdich.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mucdich.LeadingIcon = null;
            this.txt_mucdich.Location = new System.Drawing.Point(36, 203);
            this.txt_mucdich.MaxLength = 50;
            this.txt_mucdich.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_mucdich.Multiline = false;
            this.txt_mucdich.Name = "txt_mucdich";
            this.txt_mucdich.Size = new System.Drawing.Size(663, 50);
            this.txt_mucdich.TabIndex = 21;
            this.txt_mucdich.Text = "";
            this.txt_mucdich.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(396, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Loại tiền ";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(42, 82);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Số tiền vay";
            // 
            // txt_sotienvay
            // 
            this.txt_sotienvay.AnimateReadOnly = false;
            this.txt_sotienvay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sotienvay.Depth = 0;
            this.txt_sotienvay.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sotienvay.LeadingIcon = null;
            this.txt_sotienvay.Location = new System.Drawing.Point(36, 104);
            this.txt_sotienvay.MaxLength = 50;
            this.txt_sotienvay.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_sotienvay.Multiline = false;
            this.txt_sotienvay.Name = "txt_sotienvay";
            this.txt_sotienvay.Size = new System.Drawing.Size(309, 50);
            this.txt_sotienvay.TabIndex = 18;
            this.txt_sotienvay.Text = "";
            this.txt_sotienvay.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(42, 273);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Loại khoản vay";
            // 
            // cbx_loaitien
            // 
            this.cbx_loaitien.AutoResize = false;
            this.cbx_loaitien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_loaitien.Depth = 0;
            this.cbx_loaitien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_loaitien.DropDownHeight = 174;
            this.cbx_loaitien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_loaitien.DropDownWidth = 121;
            this.cbx_loaitien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_loaitien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_loaitien.FormattingEnabled = true;
            this.cbx_loaitien.IntegralHeight = false;
            this.cbx_loaitien.ItemHeight = 43;
            this.cbx_loaitien.Location = new System.Drawing.Point(390, 105);
            this.cbx_loaitien.MaxDropDownItems = 4;
            this.cbx_loaitien.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_loaitien.Name = "cbx_loaitien";
            this.cbx_loaitien.Size = new System.Drawing.Size(309, 49);
            this.cbx_loaitien.StartIndex = 0;
            this.cbx_loaitien.TabIndex = 27;
            // 
            // cbx_loaikv
            // 
            this.cbx_loaikv.AutoResize = false;
            this.cbx_loaikv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbx_loaikv.Depth = 0;
            this.cbx_loaikv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbx_loaikv.DropDownHeight = 174;
            this.cbx_loaikv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_loaikv.DropDownWidth = 121;
            this.cbx_loaikv.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbx_loaikv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbx_loaikv.FormattingEnabled = true;
            this.cbx_loaikv.IntegralHeight = false;
            this.cbx_loaikv.ItemHeight = 43;
            this.cbx_loaikv.Location = new System.Drawing.Point(36, 295);
            this.cbx_loaikv.MaxDropDownItems = 4;
            this.cbx_loaikv.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_loaikv.Name = "cbx_loaikv";
            this.cbx_loaikv.Size = new System.Drawing.Size(663, 49);
            this.cbx_loaikv.StartIndex = 0;
            this.cbx_loaikv.TabIndex = 28;
            // 
            // dg_tsdb
            // 
            this.dg_tsdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tsdb.Location = new System.Drawing.Point(36, 384);
            this.dg_tsdb.Name = "dg_tsdb";
            this.dg_tsdb.RowHeadersWidth = 82;
            this.dg_tsdb.Size = new System.Drawing.Size(663, 150);
            this.dg_tsdb.TabIndex = 29;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(604, 575);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(95, 36);
            this.materialButton1.TabIndex = 30;
            this.materialButton1.Text = "Xác Nhận";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(518, 575);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(64, 36);
            this.materialButton2.TabIndex = 31;
            this.materialButton2.Text = "Hủy";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // DangKyKhoanVay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 636);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.materialButton1);
            this.Controls.Add(this.dg_tsdb);
            this.Controls.Add(this.cbx_loaikv);
            this.Controls.Add(this.cbx_loaitien);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.txt_mucdich);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txt_sotienvay);
            this.Name = "DangKyKhoanVay_Form";
            this.Text = "Đăng ký khoản vay";
            this.Load += new System.EventHandler(this.DangKyKhoanVay_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tsdb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txt_mucdich;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_sotienvay;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialComboBox cbx_loaitien;
        private MaterialSkin.Controls.MaterialComboBox cbx_loaikv;
        private System.Windows.Forms.DataGridView dg_tsdb;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}