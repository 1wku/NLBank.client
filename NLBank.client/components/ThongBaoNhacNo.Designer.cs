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
            this.lb_hdtd = new MaterialSkin.Controls.MaterialLabel();
            this.lb_ngayky = new MaterialSkin.Controls.MaterialLabel();
            this.lb_hantrano = new MaterialSkin.Controls.MaterialLabel();
            this.btn_chitiet = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_chitiet);
            this.materialCard1.Controls.Add(this.lb_hantrano);
            this.materialCard1.Controls.Add(this.lb_ngayky);
            this.materialCard1.Controls.Add(this.lb_hdtd);
            this.materialCard1.Depth = 0;
            this.materialCard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 0);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(524, 85);
            this.materialCard1.TabIndex = 0;
            // 
            // lb_hdtd
            // 
            this.lb_hdtd.AutoSize = true;
            this.lb_hdtd.Depth = 0;
            this.lb_hdtd.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hdtd.Location = new System.Drawing.Point(17, 14);
            this.lb_hdtd.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hdtd.Name = "lb_hdtd";
            this.lb_hdtd.Size = new System.Drawing.Size(137, 19);
            this.lb_hdtd.TabIndex = 0;
            this.lb_hdtd.Text = "HDTD: 123456789 ";
            this.lb_hdtd.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // lb_ngayky
            // 
            this.lb_ngayky.AutoSize = true;
            this.lb_ngayky.Depth = 0;
            this.lb_ngayky.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_ngayky.Location = new System.Drawing.Point(17, 33);
            this.lb_ngayky.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_ngayky.Name = "lb_ngayky";
            this.lb_ngayky.Size = new System.Drawing.Size(152, 19);
            this.lb_ngayky.TabIndex = 1;
            this.lb_ngayky.Text = "Ngày ký: 20/12/2002";
            // 
            // lb_hantrano
            // 
            this.lb_hantrano.AutoSize = true;
            this.lb_hantrano.Depth = 0;
            this.lb_hantrano.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_hantrano.Location = new System.Drawing.Point(17, 52);
            this.lb_hantrano.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_hantrano.Name = "lb_hantrano";
            this.lb_hantrano.Size = new System.Drawing.Size(169, 19);
            this.lb_hantrano.TabIndex = 2;
            this.lb_hantrano.Text = "Hạn trả nợ: 20/12/2023";
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_chitiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_chitiet.Depth = 0;
            this.btn_chitiet.HighEmphasis = true;
            this.btn_chitiet.Icon = null;
            this.btn_chitiet.Location = new System.Drawing.Point(348, 42);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_chitiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_chitiet.Size = new System.Drawing.Size(158, 36);
            this.btn_chitiet.TabIndex = 3;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_chitiet.UseAccentColor = false;
            this.btn_chitiet.UseVisualStyleBackColor = true;
            // 
            // ThongBaoNhacNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "ThongBaoNhacNo";
            this.Size = new System.Drawing.Size(524, 85);
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
    }
}
