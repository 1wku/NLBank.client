namespace NLBank.client
{
    partial class Login
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_email = new MaterialSkin.Controls.MaterialTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txt_password = new MaterialSkin.Controls.MaterialTextBox();
            this.login_btn = new MaterialSkin.Controls.MaterialButton();
            this.ckb_viewPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.login_btn);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 79);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(748, 449);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.materialLabel1);
            this.flowLayoutPanel2.Controls.Add(this.txt_email);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(31, 29);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(701, 123);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(4, 0);
            this.materialLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(41, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Email";
            // 
            // txt_email
            // 
            this.txt_email.AnimateReadOnly = false;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.Depth = 0;
            this.txt_email.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_email.LeadingIcon = null;
            this.txt_email.Location = new System.Drawing.Point(4, 23);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.MaxLength = 50;
            this.txt_email.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(701, 50);
            this.txt_email.TabIndex = 0;
            this.txt_email.Text = "";
            this.txt_email.TrailingIcon = null;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.materialLabel2);
            this.flowLayoutPanel3.Controls.Add(this.txt_password);
            this.flowLayoutPanel3.Controls.Add(this.ckb_viewPass);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(31, 160);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(701, 146);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(4, 0);
            this.materialLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(68, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Mật khẩu";
            // 
            // txt_password
            // 
            this.txt_password.AnimateReadOnly = false;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Depth = 0;
            this.txt_password.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txt_password.LeadingIcon = null;
            this.txt_password.Location = new System.Drawing.Point(4, 23);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.MaxLength = 50;
            this.txt_password.MouseState = MaterialSkin.MouseState.OUT;
            this.txt_password.Multiline = false;
            this.txt_password.Name = "txt_password";
            this.txt_password.Password = true;
            this.txt_password.Size = new System.Drawing.Size(701, 50);
            this.txt_password.TabIndex = 0;
            this.txt_password.Text = "";
            this.txt_password.TrailingIcon = null;
            // 
            // login_btn
            // 
            this.login_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.login_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.login_btn.Depth = 0;
            this.login_btn.HighEmphasis = true;
            this.login_btn.Icon = null;
            this.login_btn.Location = new System.Drawing.Point(32, 317);
            this.login_btn.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.login_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.login_btn.Name = "login_btn";
            this.login_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.login_btn.Size = new System.Drawing.Size(105, 36);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Đăng nhập ";
            this.login_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.login_btn.UseAccentColor = false;
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // ckb_viewPass
            // 
            this.ckb_viewPass.AutoSize = true;
            this.ckb_viewPass.Depth = 0;
            this.ckb_viewPass.Location = new System.Drawing.Point(0, 77);
            this.ckb_viewPass.Margin = new System.Windows.Forms.Padding(0);
            this.ckb_viewPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ckb_viewPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.ckb_viewPass.Name = "ckb_viewPass";
            this.ckb_viewPass.ReadOnly = false;
            this.ckb_viewPass.Ripple = true;
            this.ckb_viewPass.Size = new System.Drawing.Size(138, 37);
            this.ckb_viewPass.TabIndex = 2;
            this.ckb_viewPass.Text = "Hiện mật khẩu";
            this.ckb_viewPass.UseVisualStyleBackColor = true;
            this.ckb_viewPass.CheckedChanged += new System.EventHandler(this.ckb_viewPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 532);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txt_email;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox txt_password;
        private MaterialSkin.Controls.MaterialButton login_btn;
        private MaterialSkin.Controls.MaterialCheckbox ckb_viewPass;
    }
}

