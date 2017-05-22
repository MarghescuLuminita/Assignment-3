namespace ClinicSecretaryClient
{
    partial class ClinicSecretary
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
            this.btnDeleteConsultation = new System.Windows.Forms.Button();
            this.btnUpdateConsultation = new System.Windows.Forms.Button();
            this.btnViewConsultations = new System.Windows.Forms.Button();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.gridConsultations = new System.Windows.Forms.DataGridView();
            this.txtDoctor = new System.Windows.Forms.TextBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblDateConsultation = new System.Windows.Forms.Label();
            this.dtDateConsultation = new System.Windows.Forms.DateTimePicker();
            this.txtNameConsultation = new System.Windows.Forms.TextBox();
            this.lblNameConsultation = new System.Windows.Forms.Label();
            this.btnViewPatients = new System.Windows.Forms.Button();
            this.dtBirthdate = new System.Windows.Forms.DateTimePicker();
            this.gridPatients = new System.Windows.Forms.DataGridView();
            this.btnUpdatePatient = new System.Windows.Forms.Button();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.txtIdentityCardNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblBirthdate = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteConsultation
            // 
            this.btnDeleteConsultation.Location = new System.Drawing.Point(361, 352);
            this.btnDeleteConsultation.Name = "btnDeleteConsultation";
            this.btnDeleteConsultation.Size = new System.Drawing.Size(112, 23);
            this.btnDeleteConsultation.TabIndex = 75;
            this.btnDeleteConsultation.Text = "Delete Consultation";
            this.btnDeleteConsultation.UseVisualStyleBackColor = true;
            this.btnDeleteConsultation.Click += new System.EventHandler(this.btnDeleteConsultation_Click);
            // 
            // btnUpdateConsultation
            // 
            this.btnUpdateConsultation.Location = new System.Drawing.Point(237, 352);
            this.btnUpdateConsultation.Name = "btnUpdateConsultation";
            this.btnUpdateConsultation.Size = new System.Drawing.Size(118, 23);
            this.btnUpdateConsultation.TabIndex = 74;
            this.btnUpdateConsultation.Text = "Update Consultation";
            this.btnUpdateConsultation.UseVisualStyleBackColor = true;
            this.btnUpdateConsultation.Click += new System.EventHandler(this.btnUpdateConsultation_Click);
            // 
            // btnViewConsultations
            // 
            this.btnViewConsultations.Location = new System.Drawing.Point(126, 352);
            this.btnViewConsultations.Name = "btnViewConsultations";
            this.btnViewConsultations.Size = new System.Drawing.Size(105, 23);
            this.btnViewConsultations.TabIndex = 73;
            this.btnViewConsultations.Text = "View Consultations";
            this.btnViewConsultations.UseVisualStyleBackColor = true;
            this.btnViewConsultations.Click += new System.EventHandler(this.btnViewConsultations_Click);
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.Location = new System.Drawing.Point(17, 353);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(103, 22);
            this.btnAddConsultation.TabIndex = 72;
            this.btnAddConsultation.Text = "Add Consultation";
            this.btnAddConsultation.UseVisualStyleBackColor = true;
            this.btnAddConsultation.Click += new System.EventHandler(this.btnAddConsultation_Click);
            // 
            // gridConsultations
            // 
            this.gridConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultations.Location = new System.Drawing.Point(295, 219);
            this.gridConsultations.Name = "gridConsultations";
            this.gridConsultations.Size = new System.Drawing.Size(287, 127);
            this.gridConsultations.TabIndex = 71;
            this.gridConsultations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridConsultations_CellClick);
            // 
            // txtDoctor
            // 
            this.txtDoctor.Location = new System.Drawing.Point(119, 307);
            this.txtDoctor.Name = "txtDoctor";
            this.txtDoctor.Size = new System.Drawing.Size(100, 20);
            this.txtDoctor.TabIndex = 70;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(14, 310);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 69;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblDateConsultation
            // 
            this.lblDateConsultation.AutoSize = true;
            this.lblDateConsultation.Location = new System.Drawing.Point(14, 252);
            this.lblDateConsultation.Name = "lblDateConsultation";
            this.lblDateConsultation.Size = new System.Drawing.Size(30, 13);
            this.lblDateConsultation.TabIndex = 68;
            this.lblDateConsultation.Text = "Date";
            // 
            // dtDateConsultation
            // 
            this.dtDateConsultation.Location = new System.Drawing.Point(119, 245);
            this.dtDateConsultation.Name = "dtDateConsultation";
            this.dtDateConsultation.Size = new System.Drawing.Size(167, 20);
            this.dtDateConsultation.TabIndex = 67;
            // 
            // txtNameConsultation
            // 
            this.txtNameConsultation.Location = new System.Drawing.Point(119, 219);
            this.txtNameConsultation.Name = "txtNameConsultation";
            this.txtNameConsultation.Size = new System.Drawing.Size(100, 20);
            this.txtNameConsultation.TabIndex = 66;
            // 
            // lblNameConsultation
            // 
            this.lblNameConsultation.AutoSize = true;
            this.lblNameConsultation.Location = new System.Drawing.Point(14, 226);
            this.lblNameConsultation.Name = "lblNameConsultation";
            this.lblNameConsultation.Size = new System.Drawing.Size(35, 13);
            this.lblNameConsultation.TabIndex = 65;
            this.lblNameConsultation.Text = "Name";
            // 
            // btnViewPatients
            // 
            this.btnViewPatients.Location = new System.Drawing.Point(210, 161);
            this.btnViewPatients.Name = "btnViewPatients";
            this.btnViewPatients.Size = new System.Drawing.Size(86, 23);
            this.btnViewPatients.TabIndex = 64;
            this.btnViewPatients.Text = "View Patients";
            this.btnViewPatients.UseVisualStyleBackColor = true;
            this.btnViewPatients.Click += new System.EventHandler(this.btnViewPatients_Click);
            // 
            // dtBirthdate
            // 
            this.dtBirthdate.Location = new System.Drawing.Point(119, 97);
            this.dtBirthdate.Name = "dtBirthdate";
            this.dtBirthdate.Size = new System.Drawing.Size(167, 20);
            this.dtBirthdate.TabIndex = 63;
            // 
            // gridPatients
            // 
            this.gridPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPatients.Location = new System.Drawing.Point(295, 12);
            this.gridPatients.Name = "gridPatients";
            this.gridPatients.Size = new System.Drawing.Size(287, 126);
            this.gridPatients.TabIndex = 62;
            // 
            // btnUpdatePatient
            // 
            this.btnUpdatePatient.Location = new System.Drawing.Point(108, 161);
            this.btnUpdatePatient.Name = "btnUpdatePatient";
            this.btnUpdatePatient.Size = new System.Drawing.Size(86, 23);
            this.btnUpdatePatient.TabIndex = 61;
            this.btnUpdatePatient.Text = "Update Patient";
            this.btnUpdatePatient.UseVisualStyleBackColor = true;
            this.btnUpdatePatient.Click += new System.EventHandler(this.btnUpdatePatient_Click);
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(14, 161);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(75, 23);
            this.btnAddPatient.TabIndex = 60;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(119, 122);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 59;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(119, 69);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(100, 20);
            this.txtCNP.TabIndex = 58;
            // 
            // txtIdentityCardNumber
            // 
            this.txtIdentityCardNumber.Location = new System.Drawing.Point(119, 43);
            this.txtIdentityCardNumber.Name = "txtIdentityCardNumber";
            this.txtIdentityCardNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIdentityCardNumber.TabIndex = 57;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(119, 16);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 56;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(14, 125);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 55;
            this.lblAddress.Text = "Address";
            // 
            // lblBirthdate
            // 
            this.lblBirthdate.AutoSize = true;
            this.lblBirthdate.Location = new System.Drawing.Point(14, 99);
            this.lblBirthdate.Name = "lblBirthdate";
            this.lblBirthdate.Size = new System.Drawing.Size(49, 13);
            this.lblBirthdate.TabIndex = 54;
            this.lblBirthdate.Text = "Birthdate";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(14, 72);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(29, 13);
            this.lblCNP.TabIndex = 53;
            this.lblCNP.Text = "CNP";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 52;
            this.lblName.Text = "Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(14, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(106, 13);
            this.lblID.TabIndex = 51;
            this.lblID.Text = "Identity Card Number";
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(14, 279);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(55, 13);
            this.lblTreatment.TabIndex = 76;
            this.lblTreatment.Text = "Treatment";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(119, 276);
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(100, 20);
            this.txtTreatment.TabIndex = 77;
            // 
            // ClinicSecretary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 408);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.btnDeleteConsultation);
            this.Controls.Add(this.btnUpdateConsultation);
            this.Controls.Add(this.btnViewConsultations);
            this.Controls.Add(this.btnAddConsultation);
            this.Controls.Add(this.gridConsultations);
            this.Controls.Add(this.txtDoctor);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblDateConsultation);
            this.Controls.Add(this.dtDateConsultation);
            this.Controls.Add(this.txtNameConsultation);
            this.Controls.Add(this.lblNameConsultation);
            this.Controls.Add(this.btnViewPatients);
            this.Controls.Add(this.dtBirthdate);
            this.Controls.Add(this.gridPatients);
            this.Controls.Add(this.btnUpdatePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.txtIdentityCardNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblBirthdate);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Name = "ClinicSecretary";
            this.Text = "ClinicSecretary";
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteConsultation;
        private System.Windows.Forms.Button btnUpdateConsultation;
        private System.Windows.Forms.Button btnViewConsultations;
        private System.Windows.Forms.Button btnAddConsultation;
        private System.Windows.Forms.DataGridView gridConsultations;
        private System.Windows.Forms.TextBox txtDoctor;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblDateConsultation;
        private System.Windows.Forms.DateTimePicker dtDateConsultation;
        private System.Windows.Forms.TextBox txtNameConsultation;
        private System.Windows.Forms.Label lblNameConsultation;
        private System.Windows.Forms.Button btnViewPatients;
        private System.Windows.Forms.DateTimePicker dtBirthdate;
        private System.Windows.Forms.DataGridView gridPatients;
        private System.Windows.Forms.Button btnUpdatePatient;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCNP;
        private System.Windows.Forms.TextBox txtIdentityCardNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblBirthdate;
        private System.Windows.Forms.Label lblCNP;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
    }
}