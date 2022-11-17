namespace NLBank.client.views
{
    partial class ChangePasswordForm
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.oldpassword_input = new MaterialSkin.Controls.MaterialTextBox();
            this.newpassword_input = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.newpassword_re_input = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.exit_btn = new MaterialSkin.Controls.MaterialButton();
            this.save_btn = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(31, 78);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(89, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Mật khẩu cũ";
            // 
            // oldpassword_input
            // 
            this.oldpassword_input.AnimateReadOnly = false;
            this.oldpassword_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.oldpassword_input.Depth = 0;
            this.oldpassword_input.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.oldpassword_input.LeadingIcon = null;
            this.oldpassword_input.Location = new System.Drawing.Point(34, 110);
            this.oldpassword_input.MaxLength = 50;
            this.oldpassword_input.MouseState = MaterialSkin.MouseState.OUT;
            this.oldpassword_input.Multiline = false;
            this.oldpassword_input.Name = "oldpassword_input";
            this.oldpassword_input.Size = new System.Drawing.Size(667, 50);
            this.oldpassword_input.TabIndex = 1;
            this.oldpassword_input.Text = "";
            this.oldpassword_input.TrailingIcon = null;
            // 
            // newpassword_input
            // 
            this.newpassword_input.AnimateReadOnly = false;
            this.newpassword_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpassword_input.Depth = 0;
            this.newpassword_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newpassword_input.LeadingIcon = null;
            this.newpassword_input.Location = new System.Drawing.Point(34, 208);
            this.newpassword_input.MaxLength = 50;
            this.newpassword_input.MouseState = MaterialSkin.MouseState.OUT;
            this.newpassword_input.Multiline = false;
            this.newpassword_input.Name = "newpassword_input";
            this.newpassword_input.Size = new System.Drawing.Size(667, 50);
            this.newpassword_input.TabIndex = 3;
            this.newpassword_input.Text = "";
            this.newpassword_input.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(31, 176);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(99, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Mật khẩu mới";
            // 
            // newpassword_re_input
            // 
            this.newpassword_re_input.AnimateReadOnly = false;
            this.newpassword_re_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.newpassword_re_input.Depth = 0;
            this.newpassword_re_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.newpassword_re_input.LeadingIcon = null;
            this.newpassword_re_input.Location = new System.Drawing.Point(34, 309);
            this.newpassword_re_input.MaxLength = 50;
            this.newpassword_re_input.MouseState = MaterialSkin.MouseState.OUT;
            this.newpassword_re_input.Multiline = false;
            this.newpassword_re_input.Name = "newpassword_re_input";
            this.newpassword_re_input.Size = new System.Drawing.Size(667, 50);
            this.newpassword_re_input.TabIndex = 5;
            this.newpassword_re_input.Text = "";
            this.newpassword_re_input.TrailingIcon = null;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(31, 277);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(171, 19);
            this.materialLabel3.TabIndex = 4;
            this.materialLabel3.Text = "Mật khẩu mới (nhập lại)";
            // 
            // exit_btn
            // 
            this.exit_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.exit_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.exit_btn.Depth = 0;
            this.exit_btn.HighEmphasis = true;
            this.exit_btn.Icon = null;
            this.exit_btn.Location = new System.Drawing.Point(494, 390);
            this.exit_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.exit_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.exit_btn.Size = new System.Drawing.Size(69, 36);
            this.exit_btn.TabIndex = 6;
            this.exit_btn.Text = "Thoát ";
            this.exit_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.exit_btn.UseAccentColor = false;
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.save_btn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.save_btn.Depth = 0;
            this.save_btn.HighEmphasis = true;
            this.save_btn.Icon = null;
            this.save_btn.Location = new System.Drawing.Point(624, 390);
            this.save_btn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.save_btn.MouseState = MaterialSkin.MouseState.HOVER;
            this.save_btn.Name = "save_btn";
            this.save_btn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.save_btn.Size = new System.Drawing.Size(64, 36);
            this.save_btn.TabIndex = 7;
            this.save_btn.Text = "Lưu ";
            this.save_btn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.save_btn.UseAccentColor = false;
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.newpassword_re_input);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.newpassword_input);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.oldpassword_input);
            this.Controls.Add(this.materialLabel1);
            this.Name = "ChangePasswordForm";
            this.Text = "Đổi mật khẩu ";
            this.Load += new System.EventHandler(this.ChangePasswordForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox oldpassword_input;
        private MaterialSkin.Controls.MaterialTextBox newpassword_input;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox newpassword_re_input;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialButton exit_btn;
        private MaterialSkin.Controls.MaterialButton save_btn;
    }
}