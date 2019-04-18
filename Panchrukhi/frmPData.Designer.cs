namespace Panchrukhi
{
    partial class frmPData
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSaveAndUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.colVPERSONID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCATNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDESIGNATION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colADDRESS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMOBILE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFATHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMOTHER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEMERGENCY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCLASS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSECTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDOJ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNCATID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNCLASSID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSECID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNEMPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNDESIGID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVEMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSTATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSALARY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNSLOT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVGENDER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPrsnSalary = new System.Windows.Forms.Label();
            this.txtPSalary = new System.Windows.Forms.TextBox();
            this.txtPEmail = new System.Windows.Forms.TextBox();
            this.txtPAddress = new System.Windows.Forms.TextBox();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPrsnDesig = new System.Windows.Forms.Label();
            this.lblPrsnCatID = new System.Windows.Forms.Label();
            this.lblPrsnDOJ = new System.Windows.Forms.Label();
            this.lblPrsnStatus = new System.Windows.Forms.Label();
            this.lblPrsnEmail = new System.Windows.Forms.Label();
            this.lblPrsnMobile = new System.Windows.Forms.Label();
            this.lblPrsnDOB = new System.Windows.Forms.Label();
            this.lblPrsnAddress = new System.Windows.Forms.Label();
            this.lblPrsnGender = new System.Windows.Forms.Label();
            this.lblPrsnName = new System.Windows.Forms.Label();
            this.lblPrsnId = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.cmbDesig = new System.Windows.Forms.ComboBox();
            this.cmbSection = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.txtPDOB = new System.Windows.Forms.DateTimePicker();
            this.txtPDOJ = new System.Windows.Forms.DateTimePicker();
            this.cmbSlot = new System.Windows.Forms.ComboBox();
            this.lblSlot = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.gbxPersonalData = new System.Windows.Forms.GroupBox();
            this.btnExcelExporter = new System.Windows.Forms.Button();
            this.txtEmergencyContact = new System.Windows.Forms.MaskedTextBox();
            this.txtPMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtPID = new System.Windows.Forms.MaskedTextBox();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.lblEmergencyContact = new System.Windows.Forms.Label();
            this.lblMother = new System.Windows.Forms.Label();
            this.txtMother = new System.Windows.Forms.TextBox();
            this.lblFather = new System.Windows.Forms.Label();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.splitParent = new System.Windows.Forms.SplitContainer();
            this.errorProviderPData = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.gbxPersonalData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitParent)).BeginInit();
            this.splitParent.Panel1.SuspendLayout();
            this.splitParent.Panel2.SuspendLayout();
            this.splitParent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(159, 513);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(73, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(83, 513);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 23);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnSaveAndUpdate
            // 
            this.btnSaveAndUpdate.Location = new System.Drawing.Point(6, 513);
            this.btnSaveAndUpdate.Name = "btnSaveAndUpdate";
            this.btnSaveAndUpdate.Size = new System.Drawing.Size(73, 23);
            this.btnSaveAndUpdate.TabIndex = 18;
            this.btnSaveAndUpdate.Text = "Save";
            this.btnSaveAndUpdate.UseVisualStyleBackColor = true;
            this.btnSaveAndUpdate.Click += new System.EventHandler(this.BtnSaveAndUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(72, 23);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnFrmClose_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colVPERSONID,
            this.colVNAME,
            this.colCATNAME,
            this.colSLOT,
            this.colDESIGNATION,
            this.colSTATUS,
            this.colADDRESS,
            this.colMOBILE,
            this.colFATHER,
            this.colMOTHER,
            this.colEMERGENCY,
            this.colDOB,
            this.colCLASS,
            this.colSECTION,
            this.colDOJ,
            this.colNCATID,
            this.colNCLASSID,
            this.colNSECID,
            this.colNEMPID,
            this.colNDESIGID,
            this.colVEMAIL,
            this.NSTATUS,
            this.NSALARY,
            this.colNSLOT,
            this.colVGENDER});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1058, 684);
            this.dataGridView.TabIndex = 22;
            this.dataGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridData_RowHeaderMouseClick);
            this.dataGridView.SelectionChanged += new System.EventHandler(this.DataGridData_SelectionChanged);
            // 
            // colVPERSONID
            // 
            this.colVPERSONID.DataPropertyName = "PERSONID";
            this.colVPERSONID.FillWeight = 50F;
            this.colVPERSONID.HeaderText = "ID";
            this.colVPERSONID.MinimumWidth = 50;
            this.colVPERSONID.Name = "colVPERSONID";
            // 
            // colVNAME
            // 
            this.colVNAME.DataPropertyName = "VNAME";
            this.colVNAME.HeaderText = "NAME";
            this.colVNAME.MinimumWidth = 100;
            this.colVNAME.Name = "colVNAME";
            // 
            // colCATNAME
            // 
            this.colCATNAME.DataPropertyName = "CATEGORY";
            this.colCATNAME.FillWeight = 80F;
            this.colCATNAME.HeaderText = "CATEGORY";
            this.colCATNAME.MinimumWidth = 80;
            this.colCATNAME.Name = "colCATNAME";
            // 
            // colSLOT
            // 
            this.colSLOT.DataPropertyName = "SLOT";
            this.colSLOT.HeaderText = "SHIFT";
            this.colSLOT.MinimumWidth = 100;
            this.colSLOT.Name = "colSLOT";
            // 
            // colDESIGNATION
            // 
            this.colDESIGNATION.DataPropertyName = "DESIGNATION";
            this.colDESIGNATION.FillWeight = 90F;
            this.colDESIGNATION.HeaderText = "DESIGNATION";
            this.colDESIGNATION.MinimumWidth = 90;
            this.colDESIGNATION.Name = "colDESIGNATION";
            // 
            // colSTATUS
            // 
            this.colSTATUS.DataPropertyName = "STATUS";
            this.colSTATUS.FillWeight = 50F;
            this.colSTATUS.HeaderText = "STATUS";
            this.colSTATUS.MinimumWidth = 50;
            this.colSTATUS.Name = "colSTATUS";
            // 
            // colADDRESS
            // 
            this.colADDRESS.DataPropertyName = "VADDRESS";
            this.colADDRESS.HeaderText = "ADDRESS";
            this.colADDRESS.MinimumWidth = 100;
            this.colADDRESS.Name = "colADDRESS";
            // 
            // colMOBILE
            // 
            this.colMOBILE.DataPropertyName = "VMOBLE";
            this.colMOBILE.FillWeight = 50F;
            this.colMOBILE.HeaderText = "MOBILE";
            this.colMOBILE.MinimumWidth = 50;
            this.colMOBILE.Name = "colMOBILE";
            // 
            // colFATHER
            // 
            this.colFATHER.DataPropertyName = "VFATHER_NAME";
            this.colFATHER.HeaderText = "FATHER";
            this.colFATHER.MinimumWidth = 100;
            this.colFATHER.Name = "colFATHER";
            this.colFATHER.Visible = false;
            // 
            // colMOTHER
            // 
            this.colMOTHER.DataPropertyName = "VMOTHER_NAME";
            this.colMOTHER.HeaderText = "MOTHER";
            this.colMOTHER.MinimumWidth = 100;
            this.colMOTHER.Name = "colMOTHER";
            this.colMOTHER.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMOTHER.Visible = false;
            // 
            // colEMERGENCY
            // 
            this.colEMERGENCY.DataPropertyName = "VEMERGENCY_CONTRACT";
            this.colEMERGENCY.HeaderText = "EMERGENCY";
            this.colEMERGENCY.MinimumWidth = 100;
            this.colEMERGENCY.Name = "colEMERGENCY";
            // 
            // colDOB
            // 
            this.colDOB.DataPropertyName = "DDOB";
            this.colDOB.HeaderText = "DOB";
            this.colDOB.Name = "colDOB";
            this.colDOB.Visible = false;
            // 
            // colCLASS
            // 
            this.colCLASS.DataPropertyName = "CLASS";
            this.colCLASS.FillWeight = 50F;
            this.colCLASS.HeaderText = "CLASS";
            this.colCLASS.MinimumWidth = 50;
            this.colCLASS.Name = "colCLASS";
            // 
            // colSECTION
            // 
            this.colSECTION.DataPropertyName = "SECTION";
            this.colSECTION.FillWeight = 70F;
            this.colSECTION.HeaderText = "SECTION";
            this.colSECTION.MinimumWidth = 70;
            this.colSECTION.Name = "colSECTION";
            // 
            // colDOJ
            // 
            this.colDOJ.DataPropertyName = "DDOJ";
            this.colDOJ.HeaderText = "DOJ";
            this.colDOJ.Name = "colDOJ";
            this.colDOJ.Visible = false;
            // 
            // colNCATID
            // 
            this.colNCATID.DataPropertyName = "NCATID";
            this.colNCATID.HeaderText = "CATID";
            this.colNCATID.Name = "colNCATID";
            this.colNCATID.Visible = false;
            // 
            // colNCLASSID
            // 
            this.colNCLASSID.DataPropertyName = "NCLASSID";
            this.colNCLASSID.HeaderText = "CLASSID";
            this.colNCLASSID.Name = "colNCLASSID";
            this.colNCLASSID.Visible = false;
            // 
            // colNSECID
            // 
            this.colNSECID.DataPropertyName = "NSECID";
            this.colNSECID.HeaderText = "SECID";
            this.colNSECID.Name = "colNSECID";
            this.colNSECID.Visible = false;
            // 
            // colNEMPID
            // 
            this.colNEMPID.DataPropertyName = "NEMPID";
            this.colNEMPID.HeaderText = "EMPID";
            this.colNEMPID.Name = "colNEMPID";
            this.colNEMPID.Visible = false;
            // 
            // colNDESIGID
            // 
            this.colNDESIGID.DataPropertyName = "NDESIGID";
            this.colNDESIGID.HeaderText = "NDESIGID";
            this.colNDESIGID.Name = "colNDESIGID";
            this.colNDESIGID.Visible = false;
            // 
            // colVEMAIL
            // 
            this.colVEMAIL.DataPropertyName = "VEMAIL";
            this.colVEMAIL.HeaderText = "EMAIL";
            this.colVEMAIL.Name = "colVEMAIL";
            this.colVEMAIL.Visible = false;
            // 
            // NSTATUS
            // 
            this.NSTATUS.DataPropertyName = "NSTATUS";
            this.NSTATUS.HeaderText = "NSTATUS";
            this.NSTATUS.Name = "NSTATUS";
            this.NSTATUS.Visible = false;
            // 
            // NSALARY
            // 
            this.NSALARY.DataPropertyName = "NSALARY";
            this.NSALARY.HeaderText = "SALARY";
            this.NSALARY.Name = "NSALARY";
            this.NSALARY.Visible = false;
            // 
            // colNSLOT
            // 
            this.colNSLOT.DataPropertyName = "NSLOTID";
            this.colNSLOT.HeaderText = "NSLOT";
            this.colNSLOT.Name = "colNSLOT";
            this.colNSLOT.Visible = false;
            // 
            // colVGENDER
            // 
            this.colVGENDER.DataPropertyName = "VGENDER";
            this.colVGENDER.HeaderText = "GENDER";
            this.colVGENDER.Name = "colVGENDER";
            this.colVGENDER.Visible = false;
            // 
            // lblPrsnSalary
            // 
            this.lblPrsnSalary.AutoSize = true;
            this.lblPrsnSalary.Location = new System.Drawing.Point(11, 316);
            this.lblPrsnSalary.Name = "lblPrsnSalary";
            this.lblPrsnSalary.Size = new System.Drawing.Size(36, 13);
            this.lblPrsnSalary.TabIndex = 123;
            this.lblPrsnSalary.Text = "Salary";
            // 
            // txtPSalary
            // 
            this.txtPSalary.Location = new System.Drawing.Point(99, 310);
            this.txtPSalary.Name = "txtPSalary";
            this.txtPSalary.Size = new System.Drawing.Size(191, 20);
            this.txtPSalary.TabIndex = 11;
            this.txtPSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPSalary_KeyPress);
            // 
            // txtPEmail
            // 
            this.txtPEmail.Location = new System.Drawing.Point(99, 177);
            this.txtPEmail.Name = "txtPEmail";
            this.txtPEmail.Size = new System.Drawing.Size(191, 20);
            this.txtPEmail.TabIndex = 6;
            // 
            // txtPAddress
            // 
            this.txtPAddress.Location = new System.Drawing.Point(99, 103);
            this.txtPAddress.Name = "txtPAddress";
            this.txtPAddress.Size = new System.Drawing.Size(191, 20);
            this.txtPAddress.TabIndex = 3;
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(99, 52);
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(191, 20);
            this.txtPName.TabIndex = 1;
            // 
            // lblPrsnDesig
            // 
            this.lblPrsnDesig.AutoSize = true;
            this.lblPrsnDesig.Location = new System.Drawing.Point(11, 285);
            this.lblPrsnDesig.Name = "lblPrsnDesig";
            this.lblPrsnDesig.Size = new System.Drawing.Size(63, 13);
            this.lblPrsnDesig.TabIndex = 118;
            this.lblPrsnDesig.Text = "Designation";
            // 
            // lblPrsnCatID
            // 
            this.lblPrsnCatID.AutoSize = true;
            this.lblPrsnCatID.Location = new System.Drawing.Point(11, 257);
            this.lblPrsnCatID.Name = "lblPrsnCatID";
            this.lblPrsnCatID.Size = new System.Drawing.Size(49, 13);
            this.lblPrsnCatID.TabIndex = 117;
            this.lblPrsnCatID.Text = "Category";
            // 
            // lblPrsnDOJ
            // 
            this.lblPrsnDOJ.AutoSize = true;
            this.lblPrsnDOJ.Location = new System.Drawing.Point(10, 231);
            this.lblPrsnDOJ.Name = "lblPrsnDOJ";
            this.lblPrsnDOJ.Size = new System.Drawing.Size(66, 13);
            this.lblPrsnDOJ.TabIndex = 116;
            this.lblPrsnDOJ.Text = "Joining Date";
            // 
            // lblPrsnStatus
            // 
            this.lblPrsnStatus.AutoSize = true;
            this.lblPrsnStatus.Location = new System.Drawing.Point(11, 207);
            this.lblPrsnStatus.Name = "lblPrsnStatus";
            this.lblPrsnStatus.Size = new System.Drawing.Size(37, 13);
            this.lblPrsnStatus.TabIndex = 115;
            this.lblPrsnStatus.Text = "Status";
            // 
            // lblPrsnEmail
            // 
            this.lblPrsnEmail.AutoSize = true;
            this.lblPrsnEmail.Location = new System.Drawing.Point(12, 180);
            this.lblPrsnEmail.Name = "lblPrsnEmail";
            this.lblPrsnEmail.Size = new System.Drawing.Size(32, 13);
            this.lblPrsnEmail.TabIndex = 114;
            this.lblPrsnEmail.Text = "Email";
            // 
            // lblPrsnMobile
            // 
            this.lblPrsnMobile.AutoSize = true;
            this.lblPrsnMobile.Location = new System.Drawing.Point(12, 158);
            this.lblPrsnMobile.Name = "lblPrsnMobile";
            this.lblPrsnMobile.Size = new System.Drawing.Size(38, 13);
            this.lblPrsnMobile.TabIndex = 108;
            this.lblPrsnMobile.Text = "Mobile";
            // 
            // lblPrsnDOB
            // 
            this.lblPrsnDOB.AutoSize = true;
            this.lblPrsnDOB.Location = new System.Drawing.Point(12, 132);
            this.lblPrsnDOB.Name = "lblPrsnDOB";
            this.lblPrsnDOB.Size = new System.Drawing.Size(68, 13);
            this.lblPrsnDOB.TabIndex = 106;
            this.lblPrsnDOB.Text = "Date Of Birth";
            // 
            // lblPrsnAddress
            // 
            this.lblPrsnAddress.AutoSize = true;
            this.lblPrsnAddress.Location = new System.Drawing.Point(12, 108);
            this.lblPrsnAddress.Name = "lblPrsnAddress";
            this.lblPrsnAddress.Size = new System.Drawing.Size(45, 13);
            this.lblPrsnAddress.TabIndex = 105;
            this.lblPrsnAddress.Text = "Address";
            // 
            // lblPrsnGender
            // 
            this.lblPrsnGender.AutoSize = true;
            this.lblPrsnGender.Location = new System.Drawing.Point(11, 82);
            this.lblPrsnGender.Name = "lblPrsnGender";
            this.lblPrsnGender.Size = new System.Drawing.Size(42, 13);
            this.lblPrsnGender.TabIndex = 104;
            this.lblPrsnGender.Text = "Gender";
            // 
            // lblPrsnName
            // 
            this.lblPrsnName.AutoSize = true;
            this.lblPrsnName.Location = new System.Drawing.Point(12, 55);
            this.lblPrsnName.Name = "lblPrsnName";
            this.lblPrsnName.Size = new System.Drawing.Size(71, 13);
            this.lblPrsnName.TabIndex = 103;
            this.lblPrsnName.Text = "Person Name";
            // 
            // lblPrsnId
            // 
            this.lblPrsnId.AutoSize = true;
            this.lblPrsnId.Location = new System.Drawing.Point(12, 31);
            this.lblPrsnId.Name = "lblPrsnId";
            this.lblPrsnId.Size = new System.Drawing.Size(54, 13);
            this.lblPrsnId.TabIndex = 102;
            this.lblPrsnId.Text = "Person ID";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.cmbGender.Location = new System.Drawing.Point(99, 77);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(191, 21);
            this.cmbGender.TabIndex = 2;
            // 
            // cmbCat
            // 
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Location = new System.Drawing.Point(99, 253);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(191, 21);
            this.cmbCat.TabIndex = 9;
            // 
            // cmbDesig
            // 
            this.cmbDesig.FormattingEnabled = true;
            this.cmbDesig.Location = new System.Drawing.Point(99, 282);
            this.cmbDesig.Name = "cmbDesig";
            this.cmbDesig.Size = new System.Drawing.Size(191, 21);
            this.cmbDesig.TabIndex = 10;
            // 
            // cmbSection
            // 
            this.cmbSection.FormattingEnabled = true;
            this.cmbSection.Location = new System.Drawing.Point(99, 362);
            this.cmbSection.Name = "cmbSection";
            this.cmbSection.Size = new System.Drawing.Size(191, 21);
            this.cmbSection.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Section";
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(99, 336);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(191, 21);
            this.cmbClass.TabIndex = 12;
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(11, 344);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 130;
            this.lblClass.Text = "Class";
            // 
            // txtPDOB
            // 
            this.txtPDOB.Location = new System.Drawing.Point(99, 127);
            this.txtPDOB.Name = "txtPDOB";
            this.txtPDOB.Size = new System.Drawing.Size(191, 20);
            this.txtPDOB.TabIndex = 4;
            // 
            // txtPDOJ
            // 
            this.txtPDOJ.Location = new System.Drawing.Point(99, 227);
            this.txtPDOJ.Name = "txtPDOJ";
            this.txtPDOJ.Size = new System.Drawing.Size(191, 20);
            this.txtPDOJ.TabIndex = 8;
            // 
            // cmbSlot
            // 
            this.cmbSlot.FormattingEnabled = true;
            this.cmbSlot.Location = new System.Drawing.Point(99, 388);
            this.cmbSlot.Name = "cmbSlot";
            this.cmbSlot.Size = new System.Drawing.Size(191, 21);
            this.cmbSlot.TabIndex = 14;
            // 
            // lblSlot
            // 
            this.lblSlot.AutoSize = true;
            this.lblSlot.Location = new System.Drawing.Point(10, 396);
            this.lblSlot.Name = "lblSlot";
            this.lblSlot.Size = new System.Drawing.Size(28, 13);
            this.lblSlot.TabIndex = 134;
            this.lblSlot.Text = "Shift";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "INACTIVE",
            "ACTIVE"});
            this.cmbStatus.Location = new System.Drawing.Point(99, 202);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(191, 21);
            this.cmbStatus.TabIndex = 7;
            // 
            // gbxPersonalData
            // 
            this.gbxPersonalData.Controls.Add(this.btnExcelExporter);
            this.gbxPersonalData.Controls.Add(this.txtEmergencyContact);
            this.gbxPersonalData.Controls.Add(this.txtPMobile);
            this.gbxPersonalData.Controls.Add(this.txtPID);
            this.gbxPersonalData.Controls.Add(this.btnPrintReport);
            this.gbxPersonalData.Controls.Add(this.lblEmergencyContact);
            this.gbxPersonalData.Controls.Add(this.lblMother);
            this.gbxPersonalData.Controls.Add(this.txtMother);
            this.gbxPersonalData.Controls.Add(this.lblFather);
            this.gbxPersonalData.Controls.Add(this.txtFather);
            this.gbxPersonalData.Controls.Add(this.txtPAddress);
            this.gbxPersonalData.Controls.Add(this.cmbStatus);
            this.gbxPersonalData.Controls.Add(this.btnClose);
            this.gbxPersonalData.Controls.Add(this.lblPrsnId);
            this.gbxPersonalData.Controls.Add(this.btnDelete);
            this.gbxPersonalData.Controls.Add(this.txtPDOB);
            this.gbxPersonalData.Controls.Add(this.btnReset);
            this.gbxPersonalData.Controls.Add(this.lblPrsnName);
            this.gbxPersonalData.Controls.Add(this.btnSaveAndUpdate);
            this.gbxPersonalData.Controls.Add(this.cmbSlot);
            this.gbxPersonalData.Controls.Add(this.lblPrsnGender);
            this.gbxPersonalData.Controls.Add(this.lblSlot);
            this.gbxPersonalData.Controls.Add(this.lblPrsnAddress);
            this.gbxPersonalData.Controls.Add(this.txtPDOJ);
            this.gbxPersonalData.Controls.Add(this.lblPrsnDOB);
            this.gbxPersonalData.Controls.Add(this.cmbClass);
            this.gbxPersonalData.Controls.Add(this.lblPrsnMobile);
            this.gbxPersonalData.Controls.Add(this.lblClass);
            this.gbxPersonalData.Controls.Add(this.lblPrsnEmail);
            this.gbxPersonalData.Controls.Add(this.cmbSection);
            this.gbxPersonalData.Controls.Add(this.lblPrsnStatus);
            this.gbxPersonalData.Controls.Add(this.label1);
            this.gbxPersonalData.Controls.Add(this.lblPrsnDOJ);
            this.gbxPersonalData.Controls.Add(this.cmbDesig);
            this.gbxPersonalData.Controls.Add(this.lblPrsnCatID);
            this.gbxPersonalData.Controls.Add(this.cmbCat);
            this.gbxPersonalData.Controls.Add(this.lblPrsnDesig);
            this.gbxPersonalData.Controls.Add(this.cmbGender);
            this.gbxPersonalData.Controls.Add(this.lblPrsnSalary);
            this.gbxPersonalData.Controls.Add(this.txtPName);
            this.gbxPersonalData.Controls.Add(this.txtPSalary);
            this.gbxPersonalData.Controls.Add(this.txtPEmail);
            this.gbxPersonalData.Location = new System.Drawing.Point(13, 12);
            this.gbxPersonalData.Name = "gbxPersonalData";
            this.gbxPersonalData.Size = new System.Drawing.Size(311, 659);
            this.gbxPersonalData.TabIndex = 137;
            this.gbxPersonalData.TabStop = false;
            this.gbxPersonalData.Text = "Insert Personal Data";
            // 
            // btnExcelExporter
            // 
            this.btnExcelExporter.Enabled = false;
            this.btnExcelExporter.Location = new System.Drawing.Point(40, 552);
            this.btnExcelExporter.Name = "btnExcelExporter";
            this.btnExcelExporter.Size = new System.Drawing.Size(105, 40);
            this.btnExcelExporter.TabIndex = 157;
            this.btnExcelExporter.Text = "Export";
            this.btnExcelExporter.UseVisualStyleBackColor = true;
            this.btnExcelExporter.Click += new System.EventHandler(this.btnExcelExporter_Click);
            // 
            // txtEmergencyContact
            // 
            this.txtEmergencyContact.Location = new System.Drawing.Point(98, 464);
            this.txtEmergencyContact.Mask = "00000000000";
            this.txtEmergencyContact.Name = "txtEmergencyContact";
            this.txtEmergencyContact.Size = new System.Drawing.Size(191, 20);
            this.txtEmergencyContact.TabIndex = 17;
            // 
            // txtPMobile
            // 
            this.txtPMobile.Location = new System.Drawing.Point(98, 153);
            this.txtPMobile.Mask = "00000000000";
            this.txtPMobile.Name = "txtPMobile";
            this.txtPMobile.Size = new System.Drawing.Size(191, 20);
            this.txtPMobile.TabIndex = 5;
            // 
            // txtPID
            // 
            this.txtPID.Location = new System.Drawing.Point(99, 27);
            this.txtPID.Mask = "000000";
            this.txtPID.Name = "txtPID";
            this.txtPID.Size = new System.Drawing.Size(191, 20);
            this.txtPID.TabIndex = 0;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Location = new System.Drawing.Point(163, 552);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(106, 40);
            this.btnPrintReport.TabIndex = 143;
            this.btnPrintReport.Text = "Print";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // lblEmergencyContact
            // 
            this.lblEmergencyContact.AutoSize = true;
            this.lblEmergencyContact.Location = new System.Drawing.Point(7, 467);
            this.lblEmergencyContact.Name = "lblEmergencyContact";
            this.lblEmergencyContact.Size = new System.Drawing.Size(85, 13);
            this.lblEmergencyContact.TabIndex = 142;
            this.lblEmergencyContact.Text = "Emergency Num";
            // 
            // lblMother
            // 
            this.lblMother.AutoSize = true;
            this.lblMother.Location = new System.Drawing.Point(9, 445);
            this.lblMother.Name = "lblMother";
            this.lblMother.Size = new System.Drawing.Size(40, 13);
            this.lblMother.TabIndex = 140;
            this.lblMother.Text = "Mother";
            // 
            // txtMother
            // 
            this.txtMother.Location = new System.Drawing.Point(98, 438);
            this.txtMother.Name = "txtMother";
            this.txtMother.Size = new System.Drawing.Size(191, 20);
            this.txtMother.TabIndex = 16;
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Location = new System.Drawing.Point(10, 421);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(37, 13);
            this.lblFather.TabIndex = 138;
            this.lblFather.Text = "Father";
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(98, 414);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(191, 20);
            this.txtFather.TabIndex = 15;
            // 
            // splitParent
            // 
            this.splitParent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitParent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitParent.Location = new System.Drawing.Point(0, 0);
            this.splitParent.Name = "splitParent";
            // 
            // splitParent.Panel1
            // 
            this.splitParent.Panel1.Controls.Add(this.gbxPersonalData);
            // 
            // splitParent.Panel2
            // 
            this.splitParent.Panel2.Controls.Add(this.dataGridView);
            this.splitParent.Size = new System.Drawing.Size(1401, 684);
            this.splitParent.SplitterDistance = 339;
            this.splitParent.TabIndex = 138;
            // 
            // errorProviderPData
            // 
            this.errorProviderPData.ContainerControl = this;
            // 
            // frmPData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 684);
            this.Controls.Add(this.splitParent);
            this.Name = "frmPData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Person Data";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPData_FormClosed);
            this.Load += new System.EventHandler(this.FrmData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.gbxPersonalData.ResumeLayout(false);
            this.gbxPersonalData.PerformLayout();
            this.splitParent.Panel1.ResumeLayout(false);
            this.splitParent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitParent)).EndInit();
            this.splitParent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSaveAndUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblPrsnSalary;
        private System.Windows.Forms.TextBox txtPSalary;
        private System.Windows.Forms.TextBox txtPEmail;
        private System.Windows.Forms.TextBox txtPAddress;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPrsnDesig;
        private System.Windows.Forms.Label lblPrsnCatID;
        private System.Windows.Forms.Label lblPrsnDOJ;
        private System.Windows.Forms.Label lblPrsnStatus;
        private System.Windows.Forms.Label lblPrsnEmail;
        private System.Windows.Forms.Label lblPrsnMobile;
        private System.Windows.Forms.Label lblPrsnDOB;
        private System.Windows.Forms.Label lblPrsnAddress;
        private System.Windows.Forms.Label lblPrsnGender;
        private System.Windows.Forms.Label lblPrsnName;
        private System.Windows.Forms.Label lblPrsnId;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.ComboBox cmbDesig;
        private System.Windows.Forms.ComboBox cmbSection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.DateTimePicker txtPDOB;
        private System.Windows.Forms.DateTimePicker txtPDOJ;
        private System.Windows.Forms.ComboBox cmbSlot;
        private System.Windows.Forms.Label lblSlot;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.GroupBox gbxPersonalData;
        private System.Windows.Forms.SplitContainer splitParent;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.Label lblMother;
        private System.Windows.Forms.TextBox txtMother;
        private System.Windows.Forms.Label lblEmergencyContact;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.MaskedTextBox txtPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVPERSONID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCATNAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDESIGNATION;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colADDRESS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMOBILE;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFATHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMOTHER;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEMERGENCY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCLASS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSECTION;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDOJ;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCATID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNCLASSID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSECID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNEMPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNDESIGID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVEMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSTATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSALARY;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNSLOT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVGENDER;
        private System.Windows.Forms.MaskedTextBox txtPMobile;
        private System.Windows.Forms.MaskedTextBox txtEmergencyContact;
        private System.Windows.Forms.ErrorProvider errorProviderPData;
        private System.Windows.Forms.Button btnExcelExporter;
    }
}