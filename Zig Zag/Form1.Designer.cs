namespace Zig_Zag
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelLogin = new System.Windows.Forms.Panel();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelInform = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxLoginButton = new System.Windows.Forms.PictureBox();
            this.labelSlogan = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.White;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogin.Controls.Add(this.comboBoxUser);
            this.panelLogin.Controls.Add(this.textBoxPass);
            this.panelLogin.Controls.Add(this.labelInform);
            this.panelLogin.Controls.Add(this.pictureBoxUserProfile);
            this.panelLogin.Controls.Add(this.pictureBoxLoginButton);
            this.panelLogin.Location = new System.Drawing.Point(388, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(394, 348);
            this.panelLogin.TabIndex = 1;
            this.panelLogin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogin_Paint);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(146, 205);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(196, 21);
            this.comboBoxUser.TabIndex = 11;
            this.comboBoxUser.Text = "                     Select a user";
            this.comboBoxUser.SelectedIndexChanged += new System.EventHandler(this.comboBoxUser_SelectedIndexChanged);
            this.comboBoxUser.Click += new System.EventHandler(this.comboBoxUser_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPass.Location = new System.Drawing.Point(146, 232);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '⬤';
            this.textBoxPass.Size = new System.Drawing.Size(196, 21);
            this.textBoxPass.TabIndex = 10;
            this.textBoxPass.Text = "Password";
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass.Click += new System.EventHandler(this.textBoxPass_Click);
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // labelInform
            // 
            this.labelInform.AutoSize = true;
            this.labelInform.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.labelInform.Location = new System.Drawing.Point(187, 322);
            this.labelInform.Name = "labelInform";
            this.labelInform.Size = new System.Drawing.Size(110, 13);
            this.labelInform.TabIndex = 4;
            this.labelInform.Text = "Click here to login";
            this.labelInform.Visible = false;
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImage = global::Zig_Zag.Properties.Resources.zakes1;
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(26, 8);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(350, 253);
            this.pictureBoxUserProfile.TabIndex = 3;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // pictureBoxLoginButton
            // 
            this.pictureBoxLoginButton.BackgroundImage = global::Zig_Zag.Properties.Resources.Typicons_e096_1__256;
            this.pictureBoxLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxLoginButton.Location = new System.Drawing.Point(164, 232);
            this.pictureBoxLoginButton.Name = "pictureBoxLoginButton";
            this.pictureBoxLoginButton.Size = new System.Drawing.Size(150, 113);
            this.pictureBoxLoginButton.TabIndex = 2;
            this.pictureBoxLoginButton.TabStop = false;
            this.pictureBoxLoginButton.Click += new System.EventHandler(this.pictureBoxLoginButton_Click);
            this.pictureBoxLoginButton.MouseLeave += new System.EventHandler(this.pictureBoxLoginButton_MouseLeave);
            this.pictureBoxLoginButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxLoginButton_MouseMove);
            // 
            // labelSlogan
            // 
            this.labelSlogan.AutoSize = true;
            this.labelSlogan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.labelSlogan.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSlogan.ForeColor = System.Drawing.Color.White;
            this.labelSlogan.Location = new System.Drawing.Point(362, 640);
            this.labelSlogan.Name = "labelSlogan";
            this.labelSlogan.Size = new System.Drawing.Size(398, 18);
            this.labelSlogan.TabIndex = 3;
            this.labelSlogan.Text = "Where pets make timeless friendships...";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 637);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1148, 24);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Zig_Zag.Properties.Resources.bigstock_Group_of_cats_and_dogs_in_fron_47035597;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(14, 366);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1119, 304);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 661);
            this.Controls.Add(this.labelSlogan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets4U ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Home_FormClosed);
            this.Load += new System.EventHandler(this.Home_Load);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoginButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBoxLoginButton;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.Label labelSlogan;
        private System.Windows.Forms.Label labelInform;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
    }
}

