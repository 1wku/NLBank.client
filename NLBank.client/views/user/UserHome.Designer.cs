namespace NLBank.client.views.user
{
    partial class UserHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHome));
            this.user_home_tabcontrol = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.user_home_navbar = new System.Windows.Forms.ImageList(this.components);
            this.user_home_tabcontrol.SuspendLayout();
            this.SuspendLayout();
            // 
            // user_home_tabcontrol
            // 
            this.user_home_tabcontrol.Controls.Add(this.tabPage1);
            this.user_home_tabcontrol.Controls.Add(this.tabPage2);
            this.user_home_tabcontrol.Depth = 0;
            this.user_home_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.user_home_tabcontrol.ImageList = this.user_home_navbar;
            this.user_home_tabcontrol.Location = new System.Drawing.Point(3, 64);
            this.user_home_tabcontrol.MouseState = MaterialSkin.MouseState.HOVER;
            this.user_home_tabcontrol.Multiline = true;
            this.user_home_tabcontrol.Name = "user_home_tabcontrol";
            this.user_home_tabcontrol.SelectedIndex = 0;
            this.user_home_tabcontrol.Size = new System.Drawing.Size(794, 533);
            this.user_home_tabcontrol.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.ImageKey = "home.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 490);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Trang chủ";
            // 
            // tabPage2
            // 
            this.tabPage2.ImageKey = "setting.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 490);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Chỉnh sửa thông tin cá nhân";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // user_home_navbar
            // 
            this.user_home_navbar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("user_home_navbar.ImageStream")));
            this.user_home_navbar.TransparentColor = System.Drawing.Color.Transparent;
            this.user_home_navbar.Images.SetKeyName(0, "home.png");
            this.user_home_navbar.Images.SetKeyName(1, "setting.png");
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.user_home_tabcontrol);
            this.DrawerTabControl = this.user_home_tabcontrol;
            this.DrawerUseColors = true;
            this.Name = "UserHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Phạm Nhật Tiến";
            this.user_home_tabcontrol.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabControl user_home_tabcontrol;
        private System.Windows.Forms.ImageList user_home_navbar;
    }
}