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
            this.materialLabel6.Location = new System.Drawing.Point(84, 348);
            this.materialLabel6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(100, 19);
            this.materialLabel6.TabIndex = 22;
            this.materialLabel6.Text = "Mục đích vay ";
            this.materialLabel6.Click += new System.EventHandler(this.materialLabel6_Click);
            // 
            // txt_mucdich
            // 
            this.txt_mucdich.AnimateReadOnly = false;
            this.txt_mucdich.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_mucdich.Depth = 0;
            this.txt_mucdich.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_mucdich.LeadingIcon = null;
            this.txt_mucdich.Location = new System.Drawing.Point(72, 390);
            this.txt_mucdich.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_mucdich.MaxLength = 50;
            this.txt_mucdich.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_mucdich.Multiline = false;
            this.txt_mucdich.Name = "txt_mucdich";
            this.txt_mucdich.Size = new System.Drawing.Size(1326, 50);
            this.txt_mucdich.TabIndex = 21;
            this.txt_mucdich.Text = "";
            this.txt_mucdich.TrailingIcon = null;
            this.txt_mucdich.TextChanged += new System.EventHandler(this.materialTextBox6_TextChanged);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(792, 158);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 19;
            this.materialLabel3.Text = "Loại tiền ";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(84, 158);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 19);
            this.materialLabel1.TabIndex = 20;
            this.materialLabel1.Text = "Số tiền vay";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // txt_sotienvay
            // 
            this.txt_sotienvay.AnimateReadOnly = false;
            this.txt_sotienvay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_sotienvay.Depth = 0;
            this.txt_sotienvay.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_sotienvay.LeadingIcon = null;
            this.txt_sotienvay.Location = new System.Drawing.Point(72, 200);
            this.txt_sotienvay.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_sotienvay.MaxLength = 50;
            this.txt_sotienvay.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_sotienvay.Multiline = false;
            this.txt_sotienvay.Name = "txt_sotienvay";
            this.txt_sotienvay.Size = new System.Drawing.Size(618, 50);
            this.txt_sotienvay.TabIndex = 18;
            this.txt_sotienvay.Text = "";
            this.txt_sotienvay.TrailingIcon = null;
            this.txt_sotienvay.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(84, 525);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Loại khoản vay";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
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
            this.cbx_loaitien.Location = new System.Drawing.Point(780, 202);
            this.cbx_loaitien.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbx_loaitien.MaxDropDownItems = 4;
            this.cbx_loaitien.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_loaitien.Name = "cbx_loaitien";
            this.cbx_loaitien.Size = new System.Drawing.Size(614, 49);
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
            this.cbx_loaikv.Location = new System.Drawing.Point(72, 567);
            this.cbx_loaikv.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbx_loaikv.MaxDropDownItems = 4;
            this.cbx_loaikv.MouseState = MaterialSkin.MouseState.OUT;
            this.cbx_loaikv.Name = "cbx_loaikv";
            this.cbx_loaikv.Size = new System.Drawing.Size(1322, 49);
            this.cbx_loaikv.StartIndex = 0;
            this.cbx_loaikv.TabIndex = 28;
            // 
            // dg_tsdb
            // 
            this.dg_tsdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_tsdb.Location = new System.Drawing.Point(72, 738);
            this.dg_tsdb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dg_tsdb.Name = "dg_tsdb";
            this.dg_tsdb.RowHeadersWidth = 82;
            this.dg_tsdb.Size = new System.Drawing.Size(1326, 288);
            this.dg_tsdb.TabIndex = 29;
            this.dg_tsdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(1208, 1106);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
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
            this.materialButton2.Location = new System.Drawing.Point(1036, 1106);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(64, 36);
            this.materialButton2.TabIndex = 31;
            this.materialButton2.Text = "Hủy";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // DangKyKhoanVay_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 1225);
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
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DangKyKhoanVay_Form";
            this.Padding = new System.Windows.Forms.Padding(6, 123, 6, 6);
            this.Text = "gt";
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