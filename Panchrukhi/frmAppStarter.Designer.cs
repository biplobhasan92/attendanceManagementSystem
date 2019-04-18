namespace Panchrukhi
{
    partial class frmAppStarter
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
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.pgrsbrAppStarter = new System.Windows.Forms.ProgressBar();
            this.tmrProgresBar = new System.Windows.Forms.Timer(this.components);
            this.lblPgrsPersent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.AutoSize = true;
            this.lblApplicationName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApplicationName.ForeColor = System.Drawing.Color.White;
            this.lblApplicationName.Location = new System.Drawing.Point(174, 57);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(319, 61);
            this.lblApplicationName.TabIndex = 0;
            this.lblApplicationName.Text = "Panchrukhi";
            // 
            // pgrsbrAppStarter
            // 
            this.pgrsbrAppStarter.BackColor = System.Drawing.Color.White;
            this.pgrsbrAppStarter.Cursor = System.Windows.Forms.Cursors.No;
            this.pgrsbrAppStarter.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.pgrsbrAppStarter.Location = new System.Drawing.Point(68, 188);
            this.pgrsbrAppStarter.Name = "pgrsbrAppStarter";
            this.pgrsbrAppStarter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pgrsbrAppStarter.Size = new System.Drawing.Size(599, 3);
            this.pgrsbrAppStarter.Step = 2;
            this.pgrsbrAppStarter.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgrsbrAppStarter.TabIndex = 1;
            this.pgrsbrAppStarter.Value = 80;
            // 
            // tmrProgresBar
            // 
            this.tmrProgresBar.Tick += new System.EventHandler(this.tmrProgresBar_Tick);
            // 
            // lblPgrsPersent
            // 
            this.lblPgrsPersent.AutoSize = true;
            this.lblPgrsPersent.ForeColor = System.Drawing.Color.White;
            this.lblPgrsPersent.Location = new System.Drawing.Point(651, 206);
            this.lblPgrsPersent.Name = "lblPgrsPersent";
            this.lblPgrsPersent.Size = new System.Drawing.Size(0, 13);
            this.lblPgrsPersent.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(574, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Wait ...";
            // 
            // lblAppVersion
            // 
            this.lblAppVersion.AutoSize = true;
            this.lblAppVersion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppVersion.ForeColor = System.Drawing.Color.White;
            this.lblAppVersion.Location = new System.Drawing.Point(484, 95);
            this.lblAppVersion.Name = "lblAppVersion";
            this.lblAppVersion.Size = new System.Drawing.Size(80, 15);
            this.lblAppVersion.TabIndex = 5;
            this.lblAppVersion.Text = "Version 1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(187, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "School, Collage , Madrasah Attendance Management System";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Panchrukhi.Properties.Resources.FKLIT;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(609, 244);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 38);
            this.panel1.TabIndex = 16;
            // 
            // frmAppStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(739, 294);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAppVersion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPgrsPersent);
            this.Controls.Add(this.pgrsbrAppStarter);
            this.Controls.Add(this.lblApplicationName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAppStarter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App Starter";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAppStarter_FormClosed);
            this.Load += new System.EventHandler(this.frmAppStarter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblApplicationName;
        private System.Windows.Forms.ProgressBar pgrsbrAppStarter;
        private System.Windows.Forms.Timer tmrProgresBar;
        private System.Windows.Forms.Label lblPgrsPersent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppVersion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}

