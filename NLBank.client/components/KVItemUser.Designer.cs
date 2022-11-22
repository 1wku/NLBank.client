
namespace NLBank.client.components
{
    partial class KVItemUser
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_mucdich = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lb_sotienvay = new MaterialSkin.Controls.MaterialLabel();
            this.btn_chitiet = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.btn_del = new MaterialSkin.Controls.MaterialButton();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(34, 29);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(96, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mục đích vay";
            // 
            // lb_mucdich
            // 
            this.lb_mucdich.AutoSize = true;
            this.lb_mucdich.Depth = 0;
            this.lb_mucdich.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_mucdich.Location = new System.Drawing.Point(197, 29);
            this.lb_mucdich.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_mucdich.Name = "lb_mucdich";
            this.lb_mucdich.Size = new System.Drawing.Size(107, 19);
            this.lb_mucdich.TabIndex = 1;
            this.lb_mucdich.Text = "materialLabel2";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(452, 29);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 0;
            this.materialLabel4.Text = "Số tiền vay";
            // 
            // lb_sotienvay
            // 
            this.lb_sotienvay.AutoSize = true;
            this.lb_sotienvay.Depth = 0;
            this.lb_sotienvay.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lb_sotienvay.Location = new System.Drawing.Point(609, 29);
            this.lb_sotienvay.MouseState = MaterialSkin.MouseState.HOVER;
            this.lb_sotienvay.Name = "lb_sotienvay";
            this.lb_sotienvay.Size = new System.Drawing.Size(107, 19);
            this.lb_sotienvay.TabIndex = 1;
            this.lb_sotienvay.Text = "materialLabel2";
            // 
            // btn_chitiet
            // 
            this.btn_chitiet.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_chitiet.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_chitiet.Depth = 0;
            this.btn_chitiet.HighEmphasis = true;
            this.btn_chitiet.Icon = null;
            this.btn_chitiet.Location = new System.Drawing.Point(789, 20);
            this.btn_chitiet.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_chitiet.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_chitiet.Name = "btn_chitiet";
            this.btn_chitiet.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_chitiet.Size = new System.Drawing.Size(80, 36);
            this.btn_chitiet.TabIndex = 6;
            this.btn_chitiet.Text = "Chi tiết";
            this.btn_chitiet.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_chitiet.UseAccentColor = false;
            this.btn_chitiet.UseVisualStyleBackColor = true;
            this.btn_chitiet.Click += new System.EventHandler(this.btn_chitiet_Click);
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.btn_del);
            this.materialCard1.Controls.Add(this.btn_chitiet);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.lb_sotienvay);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.lb_mucdich);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(1026, 87);
            this.materialCard1.TabIndex = 7;
            // 
            // btn_del
            // 
            this.btn_del.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_del.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_del.Depth = 0;
            this.btn_del.HighEmphasis = true;
            this.btn_del.Icon = null;
            this.btn_del.Location = new System.Drawing.Point(912, 20);
            this.btn_del.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_del.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_del.Name = "btn_del";
            this.btn_del.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_del.Size = new System.Drawing.Size(64, 36);
            this.btn_del.TabIndex = 6;
            this.btn_del.Text = "Xóa";
            this.btn_del.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_del.UseAccentColor = false;
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // KVItemUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.materialCard1);
            this.Name = "KVItemUser";
            this.Size = new System.Drawing.Size(1056, 117);
            this.Load += new System.EventHandler(this.HDTDItemUser_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lb_mucdich;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel lb_sotienvay;
        private MaterialSkin.Controls.MaterialButton btn_chitiet;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialButton btn_del;
    }
}
