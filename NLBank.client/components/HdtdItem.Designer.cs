namespace NLBank.client.components
{
    partial class HdtdItem
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.id_isOver_lb = new MaterialSkin.Controls.MaterialLabel();
            this.id_tstd_lb = new MaterialSkin.Controls.MaterialLabel();
            this.thuno_btn = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.thuno_btn);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.materialButton1);
            this.materialCard1.Controls.Add(this.id_isOver_lb);
            this.materialCard1.Controls.Add(this.id_tstd_lb);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(0, 8);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(549, 75);
            this.materialCard1.TabIndex = 7;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(162, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mã hợp đồng tín dụng ";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(17, 43);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(78, 19);
            this.materialLabel2.TabIndex = 3;
            this.materialLabel2.Text = "Trạng thái ";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(451, 26);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(80, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Chi tiết";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // id_isOver_lb
            // 
            this.id_isOver_lb.AutoSize = true;
            this.id_isOver_lb.Depth = 0;
            this.id_isOver_lb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.id_isOver_lb.Location = new System.Drawing.Point(188, 43);
            this.id_isOver_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_isOver_lb.Name = "id_isOver_lb";
            this.id_isOver_lb.Size = new System.Drawing.Size(96, 19);
            this.id_isOver_lb.TabIndex = 4;
            this.id_isOver_lb.Text = "Chưa tới hạn ";
            // 
            // id_tstd_lb
            // 
            this.id_tstd_lb.AutoSize = true;
            this.id_tstd_lb.Depth = 0;
            this.id_tstd_lb.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.id_tstd_lb.Location = new System.Drawing.Point(188, 14);
            this.id_tstd_lb.MouseState = MaterialSkin.MouseState.HOVER;
            this.id_tstd_lb.Name = "id_tstd_lb";
            this.id_tstd_lb.Size = new System.Drawing.Size(73, 19);
            this.id_tstd_lb.TabIndex = 1;
            this.id_tstd_lb.Text = "12345678";
            this.id_tstd_lb.Click += new System.EventHandler(this.id_ts_Click);
            // 
            // thuno_btn
            // 
            this.thuno_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.thuno_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.thuno_btn.Depth = 0;
            this.thuno_btn.HighEmphasis = true;
            this.thuno_btn.Icon = null;
            this.thuno_btn.Location = new System.Drawing.Point(350, 26);
            this.thuno_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.thuno_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.thuno_btn.Name = "thuno_btn";
            this.thuno_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.thuno_btn.Size = new System.Drawing.Size(75, 36);
            this.thuno_btn.TabIndex = 23;
            this.thuno_btn.Text = "Thu nợ";
            this.thuno_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.thuno_btn.UseAccentColor = false;
            this.thuno_btn.UseVisualStyleBackColor = true;
            this.thuno_btn.Click += new System.EventHandler(this.thuno_btn_Click);
            // 
            // HdtdItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "HdtdItem";
            this.Size = new System.Drawing.Size(553, 90);
            this.Load += new System.EventHandler(this.tstdItem_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialLabel id_isOver_lb;
        private MaterialSkin.Controls.MaterialLabel id_tstd_lb;
        private MaterialSkin.Controls.MaterialButton thuno_btn;
    }
}
