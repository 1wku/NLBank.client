namespace NLBank.client
{
    partial class LoginForm
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
            this.input_email_login = new MaterialSkin.Controls.MaterialTextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.input_password_login = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.btn_login = new MaterialSkin.Controls.MaterialButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.btn_login);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 79);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(27, 25, 27, 25);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 377);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.materialLabel1);
            this.flowLayoutPanel2.Controls.Add(this.input_email_login);
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
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // input_email_login
            // 
            this.input_email_login.AnimateReadOnly = false;
            this.input_email_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.input_email_login.Depth = 0;
            this.input_email_login.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.input_email_login.LeadingIcon = null;
            this.input_email_login.Location = new System.Drawing.Point(4, 23);
            this.input_email_login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.input_email_login.MaxLength = 50;
            this.input_email_login.MouseState = MaterialSkin.MouseState.OUT;
            this.input_email_login.Multiline = false;
            this.input_email_login.Name = "input_email_login";
            this.input_email_login.Size = new System.Drawing.Size(701, 50);
            this.input_email_login.TabIndex = 0;
            this.input_email_login.Text = "";
            this.input_email_login.TrailingIcon = null;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.input_password_login);
            this.flowLayoutPanel3.Controls.Add(this.materialTextBox2);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(31, 160);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(701, 123);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // input_password_login
            // 
            this.input_password_login.AutoSize = true;
            this.input_password_login.Depth = 0;
            this.input_password_login.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.input_password_login.Location = new System.Drawing.Point(4, 0);
            this.input_password_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.input_password_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.input_password_login.Name = "input_password_login";
            this.input_password_login.Size = new System.Drawing.Size(68, 19);
            this.input_password_login.TabIndex = 1;
            this.input_password_login.Text = "Mật khẩu";
            // 
            // materialTextBox2
            // 
            this.materialTextBox2.AnimateReadOnly = false;
            this.materialTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox2.Depth = 0;
            this.materialTextBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox2.LeadingIcon = null;
            this.materialTextBox2.Location = new System.Drawing.Point(4, 23);
            this.materialTextBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialTextBox2.MaxLength = 50;
            this.materialTextBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox2.Multiline = false;
            this.materialTextBox2.Name = "materialTextBox2";
            this.materialTextBox2.Size = new System.Drawing.Size(701, 50);
            this.materialTextBox2.TabIndex = 0;
            this.materialTextBox2.Text = "";
            this.materialTextBox2.TrailingIcon = null;
            // 
            // btn_login
            // 
            this.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_login.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btn_login.Depth = 0;
            this.btn_login.HighEmphasis = true;
            this.btn_login.Icon = null;
            this.btn_login.Location = new System.Drawing.Point(32, 294);
            this.btn_login.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btn_login.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_login.Name = "btn_login";
            this.btn_login.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btn_login.Size = new System.Drawing.Size(105, 36);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btn_login.UseAccentColor = false;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 460);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Text = " ";
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
        private MaterialSkin.Controls.MaterialTextBox input_email_login;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private MaterialSkin.Controls.MaterialLabel input_password_login;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox2;
        private MaterialSkin.Controls.MaterialButton btn_login;
    }
}

