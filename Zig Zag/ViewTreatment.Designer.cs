namespace Zig_Zag
{
    partial class ViewTreatment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTreatment));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelSystem = new System.Windows.Forms.Label();
            this.pictureBoxSystemLine = new System.Windows.Forms.PictureBox();
            this.labelBack = new System.Windows.Forms.Label();
            this.pictureBoxUserProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxBack = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystemLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxSystemLine);
            this.panel1.Location = new System.Drawing.Point(218, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(738, 459);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.labelSystem);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(738, 468);
            this.panel2.TabIndex = 44;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.pictureBox1.Location = new System.Drawing.Point(210, 451);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 1);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // labelSystem
            // 
            this.labelSystem.AutoSize = true;
            this.labelSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(127)))));
            this.labelSystem.Location = new System.Drawing.Point(250, 417);
            this.labelSystem.Name = "labelSystem";
            this.labelSystem.Size = new System.Drawing.Size(282, 31);
            this.labelSystem.TabIndex = 37;
            this.labelSystem.Text = "Treatment variations";
            // 
            // pictureBoxSystemLine
            // 
            this.pictureBoxSystemLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.pictureBoxSystemLine.Location = new System.Drawing.Point(48, 451);
            this.pictureBoxSystemLine.Name = "pictureBoxSystemLine";
            this.pictureBoxSystemLine.Size = new System.Drawing.Size(300, 1);
            this.pictureBoxSystemLine.TabIndex = 38;
            this.pictureBoxSystemLine.TabStop = false;
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(135)))), ((int)(((byte)(25)))));
            this.labelBack.Location = new System.Drawing.Point(11, 103);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(100, 13);
            this.labelBack.TabIndex = 42;
            this.labelBack.Text = "Click to go back";
            this.labelBack.Visible = false;
            // 
            // pictureBoxUserProfile
            // 
            this.pictureBoxUserProfile.BackgroundImage = global::Zig_Zag.Properties.Resources.zakes1;
            this.pictureBoxUserProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxUserProfile.Location = new System.Drawing.Point(1055, 22);
            this.pictureBoxUserProfile.Name = "pictureBoxUserProfile";
            this.pictureBoxUserProfile.Size = new System.Drawing.Size(83, 78);
            this.pictureBoxUserProfile.TabIndex = 43;
            this.pictureBoxUserProfile.TabStop = false;
            // 
            // pictureBoxBack
            // 
            this.pictureBoxBack.BackgroundImage = global::Zig_Zag.Properties.Resources.Typicons_e00c_0__256b1;
            this.pictureBoxBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxBack.Location = new System.Drawing.Point(14, 22);
            this.pictureBoxBack.Name = "pictureBoxBack";
            this.pictureBoxBack.Size = new System.Drawing.Size(83, 78);
            this.pictureBoxBack.TabIndex = 41;
            this.pictureBoxBack.TabStop = false;
            this.pictureBoxBack.Click += new System.EventHandler(this.pictureBoxBack_Click);
            this.pictureBoxBack.MouseLeave += new System.EventHandler(this.pictureBoxBack_MouseLeave);
            this.pictureBoxBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxBack_MouseMove);
            // 
            // ViewTreatment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1148, 662);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.pictureBoxUserProfile);
            this.Controls.Add(this.pictureBoxBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewTreatment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pets4U";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewTreatment_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSystemLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelSystem;
        private System.Windows.Forms.PictureBox pictureBoxSystemLine;
        private System.Windows.Forms.Label labelBack;
        private System.Windows.Forms.PictureBox pictureBoxUserProfile;
        private System.Windows.Forms.PictureBox pictureBoxBack;
    }
}