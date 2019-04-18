namespace Panchrukhi
{
    partial class frmMainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainWindow));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.personalDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripAddEditPerson = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripCategories = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripDesignation = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripSections = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripSlots = new System.Windows.Forms.ToolStripMenuItem();
            this.basicSettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewMachineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.iPConfigureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHolyDayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHolyCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWeekendToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualAttendanceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.promoteAndDemoteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tstripPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flowLayoutMainWindow = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalDataToolStripMenuItem,
            this.basicSettingToolStripMenuItem,
            this.setHolyDayToolStripMenuItem,
            this.attendanceSettingsToolStripMenuItem,
            this.promoteAndDemoteToolStripMenuItem,
            this.reportingToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(1110, 24);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // personalDataToolStripMenuItem
            // 
            this.personalDataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripAddEditPerson,
            this.tstripCategories,
            this.tstripDesignation,
            this.tstripClasses,
            this.tstripSections,
            this.tstripSlots});
            this.personalDataToolStripMenuItem.Name = "personalDataToolStripMenuItem";
            this.personalDataToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.personalDataToolStripMenuItem.Text = "Basic Settings";
            // 
            // tstripAddEditPerson
            // 
            this.tstripAddEditPerson.Name = "tstripAddEditPerson";
            this.tstripAddEditPerson.Size = new System.Drawing.Size(152, 22);
            this.tstripAddEditPerson.Text = "Person Data";
            this.tstripAddEditPerson.Click += new System.EventHandler(this.tstripAddEditPerson_Click);
            // 
            // tstripCategories
            // 
            this.tstripCategories.Name = "tstripCategories";
            this.tstripCategories.Size = new System.Drawing.Size(152, 22);
            this.tstripCategories.Text = "Category";
            this.tstripCategories.Click += new System.EventHandler(this.tstripCategories_Click);
            // 
            // tstripDesignation
            // 
            this.tstripDesignation.Name = "tstripDesignation";
            this.tstripDesignation.Size = new System.Drawing.Size(152, 22);
            this.tstripDesignation.Text = "Designation";
            this.tstripDesignation.Click += new System.EventHandler(this.designationToolStripMenuItem_Click);
            // 
            // tstripClasses
            // 
            this.tstripClasses.Name = "tstripClasses";
            this.tstripClasses.Size = new System.Drawing.Size(152, 22);
            this.tstripClasses.Text = "Class";
            this.tstripClasses.Click += new System.EventHandler(this.tstripClasses_Click);
            // 
            // tstripSections
            // 
            this.tstripSections.Name = "tstripSections";
            this.tstripSections.Size = new System.Drawing.Size(152, 22);
            this.tstripSections.Text = "Section";
            this.tstripSections.Click += new System.EventHandler(this.tstripSections_Click);
            // 
            // tstripSlots
            // 
            this.tstripSlots.Name = "tstripSlots";
            this.tstripSlots.Size = new System.Drawing.Size(152, 22);
            this.tstripSlots.Text = "Shift";
            this.tstripSlots.Click += new System.EventHandler(this.tstripSlots_Click);
            // 
            // basicSettingToolStripMenuItem
            // 
            this.basicSettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewMachineToolStripMenuItem1,
            this.iPConfigureToolStripMenuItem});
            this.basicSettingToolStripMenuItem.Name = "basicSettingToolStripMenuItem";
            this.basicSettingToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.basicSettingToolStripMenuItem.Text = "Machine Info";
            // 
            // addNewMachineToolStripMenuItem1
            // 
            this.addNewMachineToolStripMenuItem1.Name = "addNewMachineToolStripMenuItem1";
            this.addNewMachineToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.addNewMachineToolStripMenuItem1.Text = "Add New Machine";
            this.addNewMachineToolStripMenuItem1.Click += new System.EventHandler(this.addNewMachineToolStripMenuItem1_Click);
            // 
            // iPConfigureToolStripMenuItem
            // 
            this.iPConfigureToolStripMenuItem.Name = "iPConfigureToolStripMenuItem";
            this.iPConfigureToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.iPConfigureToolStripMenuItem.Text = "IP Configure";
            this.iPConfigureToolStripMenuItem.Click += new System.EventHandler(this.iPConfigureToolStripMenuItem_Click);
            // 
            // setHolyDayToolStripMenuItem
            // 
            this.setHolyDayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHolyCategoryToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addWeekendToolStripMenuItem});
            this.setHolyDayToolStripMenuItem.Name = "setHolyDayToolStripMenuItem";
            this.setHolyDayToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.setHolyDayToolStripMenuItem.Text = "Holidays";
            // 
            // addHolyCategoryToolStripMenuItem
            // 
            this.addHolyCategoryToolStripMenuItem.Name = "addHolyCategoryToolStripMenuItem";
            this.addHolyCategoryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addHolyCategoryToolStripMenuItem.Text = "Holiday Category";
            this.addHolyCategoryToolStripMenuItem.Click += new System.EventHandler(this.addHolyCategoryToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addToolStripMenuItem.Text = "Holiday";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // addWeekendToolStripMenuItem
            // 
            this.addWeekendToolStripMenuItem.Name = "addWeekendToolStripMenuItem";
            this.addWeekendToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.addWeekendToolStripMenuItem.Text = "Weekend";
            this.addWeekendToolStripMenuItem.Click += new System.EventHandler(this.addWeekendToolStripMenuItem_Click);
            // 
            // attendanceSettingsToolStripMenuItem
            // 
            this.attendanceSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processAttendanceToolStripMenuItem,
            this.manualAttendanceToolStripMenuItem1});
            this.attendanceSettingsToolStripMenuItem.Name = "attendanceSettingsToolStripMenuItem";
            this.attendanceSettingsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.attendanceSettingsToolStripMenuItem.Text = "Attendance";
            // 
            // processAttendanceToolStripMenuItem
            // 
            this.processAttendanceToolStripMenuItem.Name = "processAttendanceToolStripMenuItem";
            this.processAttendanceToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.processAttendanceToolStripMenuItem.Text = "Process Attendance";
            this.processAttendanceToolStripMenuItem.Click += new System.EventHandler(this.processAttendanceToolStripMenuItem_Click);
            // 
            // manualAttendanceToolStripMenuItem1
            // 
            this.manualAttendanceToolStripMenuItem1.Name = "manualAttendanceToolStripMenuItem1";
            this.manualAttendanceToolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.manualAttendanceToolStripMenuItem1.Text = "Manual Attendance";
            this.manualAttendanceToolStripMenuItem1.Click += new System.EventHandler(this.manualAttendanceToolStripMenuItem1_Click);
            // 
            // promoteAndDemoteToolStripMenuItem
            // 
            this.promoteAndDemoteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.promotionToolStripMenuItem});
            this.promoteAndDemoteToolStripMenuItem.Name = "promoteAndDemoteToolStripMenuItem";
            this.promoteAndDemoteToolStripMenuItem.Size = new System.Drawing.Size(135, 20);
            this.promoteAndDemoteToolStripMenuItem.Text = "Promote And Demote";
            // 
            // promotionToolStripMenuItem
            // 
            this.promotionToolStripMenuItem.Name = "promotionToolStripMenuItem";
            this.promotionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.promotionToolStripMenuItem.Text = "Promotion";
            this.promotionToolStripMenuItem.Click += new System.EventHandler(this.promotionToolStripMenuItem_Click_1);
            // 
            // reportingToolStripMenuItem
            // 
            this.reportingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripPersonalInfo});
            this.reportingToolStripMenuItem.Name = "reportingToolStripMenuItem";
            this.reportingToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.reportingToolStripMenuItem.Text = "Report";
            // 
            // tstripPersonalInfo
            // 
            this.tstripPersonalInfo.Name = "tstripPersonalInfo";
            this.tstripPersonalInfo.Size = new System.Drawing.Size(152, 22);
            this.tstripPersonalInfo.Text = "Person Info";
            this.tstripPersonalInfo.Click += new System.EventHandler(this.tstripPersonalInfo_Click);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // flowLayoutMainWindow
            // 
            this.flowLayoutMainWindow.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flowLayoutMainWindow.BackgroundImage")));
            this.flowLayoutMainWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.flowLayoutMainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutMainWindow.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutMainWindow.Name = "flowLayoutMainWindow";
            this.flowLayoutMainWindow.Size = new System.Drawing.Size(1110, 700);
            this.flowLayoutMainWindow.TabIndex = 2;
            // 
            // frmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 724);
            this.Controls.Add(this.flowLayoutMainWindow);
            this.Controls.Add(this.mnuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panchrukhi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem personalDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tstripAddEditPerson;
        private System.Windows.Forms.ToolStripMenuItem tstripCategories;
        private System.Windows.Forms.ToolStripMenuItem tstripDesignation;
        private System.Windows.Forms.ToolStripMenuItem tstripSlots;
        private System.Windows.Forms.ToolStripMenuItem tstripSections;
        private System.Windows.Forms.ToolStripMenuItem tstripClasses;
        private System.Windows.Forms.ToolStripMenuItem reportingToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem tstripPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem setHolyDayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHolyCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWeekendToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutMainWindow;
        private System.Windows.Forms.ToolStripMenuItem basicSettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewMachineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem iPConfigureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processAttendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualAttendanceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem promoteAndDemoteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promotionToolStripMenuItem;
    }
}