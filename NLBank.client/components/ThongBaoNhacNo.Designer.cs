namespace NLBank.client.components
{
    partial class ThongBaoNhacNo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_chitiet = new MaterialSkin.Controls.MaterialButton();
            this.lb_hantrano = new MaterialSkin.Controls.MaterialLabel();
            this.lb_ngayky = new MaterialSkin.Controls.MaterialLabel();
            this.lb_hdtd = new MaterialSkin.Controls.MaterialLabel();
            this.lb_sotienvay = new MaterialSkin.Controls.MaterialLabel();
            this.lb_hanmuctd = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.lb_hanmuctd);
            this.materialCard1.Controls.Add(this.lb_sotienvay);
            this.materialCard1.Controls.Add(this.btn_chitiet);
            this.materialCard1.Controls.Add(this.lb_hantrano);
            this.materialCard1.Controls.Add(this.lb_ngayky);
            this.materialCard1.Controls.Add(this.lb_hdtd);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(28, 27, 28, 27);
            this.materialCard1.Size = new System.Drawing.Size(1048, 163);
            this.materialCard1.TabIndex = 0;
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_chitiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_chitiet.Depth = 0;
            this.btn_chitiet.HighEmphasis = true;
            this.btn_chitiet.Icon = null;
            this.btn_chitiet.Location = new System.Drawing.Point(696, 81);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btn_chitiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_chitiet.Size = new System.Drawing.Size(80, 36);
            this.btn_chitiet.TabIndex = 3;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_chitiet.UseAccentColor = false;
            this.btn_chitiet.UseVisualStyleBackColor = true;
            // 
            // lb_hantrano
            // 
            this.lb_hantrano.AutoSize = true;
            this.lb_hantrano.Depth = 0;
            this.lb_hantrano.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hantrano.Location = new System.Drawing.Point(34, 100);
            this.lb_hantrano.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_hantrano.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hantrano.Name = "lb_hantrano";
            this.lb_hantrano.Size = new System.Drawing.Size(83, 19);
            this.lb_hantrano.TabIndex = 2;
            this.lb_hantrano.Text = "Hạn trả nợ: ";
            // 
            // lb_ngayky
            // 
            this.lb_ngayky.AutoSize = true;
            this.lb_ngayky.Depth = 0;
            this.lb_ngayky.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_ngayky.Location = new System.Drawing.Point(34, 63);
            this.lb_ngayky.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ngayky.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_ngayky.Name = "lb_ngayky";
            this.lb_ngayky.Size = new System.Drawing.Size(66, 19);
            this.lb_ngayky.TabIndex = 1;
            this.lb_ngayky.Text = "Ngày ký: ";
            // 
            // lb_hdtd
            // 
            this.lb_hdtd.AutoSize = true;
            this.lb_hdtd.Depth = 0;
            this.lb_hdtd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hdtd.Location = new System.Drawing.Point(34, 27);
            this.lb_hdtd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_hdtd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hdtd.Name = "lb_hdtd";
            this.lb_hdtd.Size = new System.Drawing.Size(52, 19);
            this.lb_hdtd.TabIndex = 0;
            this.lb_hdtd.Text = "HDTD: ";
            this.lb_hdtd.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lb_sotienvay
            // 
            this.lb_sotienvay.AutoSize = true;
            this.lb_sotienvay.Depth = 0;
            this.lb_sotienvay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sotienvay.Location = new System.Drawing.Point(343, 27);
            this.lb_sotienvay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sotienvay.Name = "lb_sotienvay";
            this.lb_sotienvay.Size = new System.Drawing.Size(87, 19);
            this.lb_sotienvay.TabIndex = 4;
            this.lb_sotienvay.Text = "Số tiền vay: ";
            // 
            // lb_hanmuctd
            // 
            this.lb_hanmuctd.AutoSize = true;
            this.lb_hanmuctd.Depth = 0;
            this.lb_hanmuctd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hanmuctd.Location = new System.Drawing.Point(343, 63);
            this.lb_hanmuctd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hanmuctd.Name = "lb_hanmuctd";
            this.lb_hanmuctd.Size = new System.Drawing.Size(136, 19);
            this.lb_hanmuctd.TabIndex = 5;
            this.lb_hanmuctd.Text = "Hạn mức tín dụng: ";
            // 
            // ThongBaoNhacNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "ThongBaoNhacNo";
            this.Size = new System.Drawing.Size(1048, 163);
            this.Load += new System.EventHandler(this.ThongBaoNhacNo_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel lb_hdtd;
        private MaterialSkin.Controls.MaterialLabel lb_hantrano;
        private MaterialSkin.Controls.MaterialLabel lb_ngayky;
        private MaterialSkin.Controls.MaterialButton btn_chitiet;
        private MaterialSkin.Controls.MaterialLabel lb_sotienvay;
        private MaterialSkin.Controls.MaterialLabel lb_hanmuctd;
    }
}
