namespace AdministratorClient
{
    partial class Administrator
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
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.txtDoctorName = new System.Windows.Forms.TextBox();
            this.txtSpecialization = new System.Windows.Forms.TextBox();
            this.gridDoctors = new System.Windows.Forms.DataGridView();
            this.btnDeleteDoctor = new System.Windows.Forms.Button();
            this.btnUpdateDoctor = new System.Windows.Forms.Button();
            this.btnViewDoctors = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.lblSecretaryName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSecretaryName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.gridSecretaries = new System.Windows.Forms.DataGridView();
            this.btnDeleteSecretary = new System.Windows.Forms.Button();
            this.btnUpdateSecretary = new System.Windows.Forms.Button();
            this.btnViewSecretary = new System.Windows.Forms.Button();
            this.btnAddSecretary = new System.Windows.Forms.Button();
            this.lblDeleteDoctor = new System.Windows.Forms.Label();
            this.txtDeleteDoctor = new System.Windows.Forms.TextBox();
            this.lblDeleteSecretary = new System.Windows.Forms.Label();
            this.txtDeleteSecretary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecretaries)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Location = new System.Drawing.Point(21, 47);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(35, 13);
            this.lblDoctorName.TabIndex = 0;
            this.lblDoctorName.Text = "Name";
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.Location = new System.Drawing.Point(21, 76);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(72, 13);
            this.lblSpecialization.TabIndex = 1;
            this.lblSpecialization.Text = "Specialization";
            // 
            // txtDoctorName
            // 
            this.txtDoctorName.Location = new System.Drawing.Point(111, 44);
            this.txtDoctorName.Name = "txtDoctorName";
            this.txtDoctorName.Size = new System.Drawing.Size(122, 20);
            this.txtDoctorName.TabIndex = 2;
            // 
            // txtSpecialization
            // 
            this.txtSpecialization.Location = new System.Drawing.Point(111, 76);
            this.txtSpecialization.Name = "txtSpecialization";
            this.txtSpecialization.Size = new System.Drawing.Size(122, 20);
            this.txtSpecialization.TabIndex = 3;
            // 
            // gridDoctors
            // 
            this.gridDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDoctors.Location = new System.Drawing.Point(254, 12);
            this.gridDoctors.Name = "gridDoctors";
            this.gridDoctors.Size = new System.Drawing.Size(332, 123);
            this.gridDoctors.TabIndex = 4;
            // 
            // btnDeleteDoctor
            // 
            this.btnDeleteDoctor.Location = new System.Drawing.Point(300, 154);
            this.btnDeleteDoctor.Name = "btnDeleteDoctor";
            this.btnDeleteDoctor.Size = new System.Drawing.Size(91, 23);
            this.btnDeleteDoctor.TabIndex = 79;
            this.btnDeleteDoctor.Text = "Delete Doctor";
            this.btnDeleteDoctor.UseVisualStyleBackColor = true;
            this.btnDeleteDoctor.Click += new System.EventHandler(this.btnDeleteDoctor_Click);
            // 
            // btnUpdateDoctor
            // 
            this.btnUpdateDoctor.Location = new System.Drawing.Point(200, 154);
            this.btnUpdateDoctor.Name = "btnUpdateDoctor";
            this.btnUpdateDoctor.Size = new System.Drawing.Size(94, 23);
            this.btnUpdateDoctor.TabIndex = 78;
            this.btnUpdateDoctor.Text = "Update Doctor";
            this.btnUpdateDoctor.UseVisualStyleBackColor = true;
            this.btnUpdateDoctor.Click += new System.EventHandler(this.btnUpdateDoctor_Click);
            // 
            // btnViewDoctors
            // 
            this.btnViewDoctors.Location = new System.Drawing.Point(107, 154);
            this.btnViewDoctors.Name = "btnViewDoctors";
            this.btnViewDoctors.Size = new System.Drawing.Size(87, 23);
            this.btnViewDoctors.TabIndex = 77;
            this.btnViewDoctors.Text = "View Doctors";
            this.btnViewDoctors.UseVisualStyleBackColor = true;
            this.btnViewDoctors.Click += new System.EventHandler(this.btnViewDoctors_Click);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.Location = new System.Drawing.Point(24, 155);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(77, 22);
            this.btnAddDoctor.TabIndex = 76;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.UseVisualStyleBackColor = true;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            // 
            // lblSecretaryName
            // 
            this.lblSecretaryName.AutoSize = true;
            this.lblSecretaryName.Location = new System.Drawing.Point(21, 227);
            this.lblSecretaryName.Name = "lblSecretaryName";
            this.lblSecretaryName.Size = new System.Drawing.Size(35, 13);
            this.lblSecretaryName.TabIndex = 80;
            this.lblSecretaryName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(21, 254);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 81;
            this.lblAddress.Text = "Address";
            // 
            // txtSecretaryName
            // 
            this.txtSecretaryName.Location = new System.Drawing.Point(111, 224);
            this.txtSecretaryName.Name = "txtSecretaryName";
            this.txtSecretaryName.Size = new System.Drawing.Size(122, 20);
            this.txtSecretaryName.TabIndex = 82;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(111, 250);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(122, 51);
            this.txtAddress.TabIndex = 83;
            // 
            // gridSecretaries
            // 
            this.gridSecretaries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSecretaries.Location = new System.Drawing.Point(254, 212);
            this.gridSecretaries.Name = "gridSecretaries";
            this.gridSecretaries.Size = new System.Drawing.Size(332, 124);
            this.gridSecretaries.TabIndex = 84;
            // 
            // btnDeleteSecretary
            // 
            this.btnDeleteSecretary.Location = new System.Drawing.Point(324, 364);
            this.btnDeleteSecretary.Name = "btnDeleteSecretary";
            this.btnDeleteSecretary.Size = new System.Drawing.Size(103, 23);
            this.btnDeleteSecretary.TabIndex = 88;
            this.btnDeleteSecretary.Text = "Delete Secretary";
            this.btnDeleteSecretary.UseVisualStyleBackColor = true;
            this.btnDeleteSecretary.Click += new System.EventHandler(this.btnDeleteSecretary_Click);
            // 
            // btnUpdateSecretary
            // 
            this.btnUpdateSecretary.Location = new System.Drawing.Point(213, 364);
            this.btnUpdateSecretary.Name = "btnUpdateSecretary";
            this.btnUpdateSecretary.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateSecretary.TabIndex = 87;
            this.btnUpdateSecretary.Text = "Update Secretary";
            this.btnUpdateSecretary.UseVisualStyleBackColor = true;
            this.btnUpdateSecretary.Click += new System.EventHandler(this.btnUpdateSecretary_Click);
            // 
            // btnViewSecretary
            // 
            this.btnViewSecretary.Location = new System.Drawing.Point(120, 364);
            this.btnViewSecretary.Name = "btnViewSecretary";
            this.btnViewSecretary.Size = new System.Drawing.Size(87, 23);
            this.btnViewSecretary.TabIndex = 86;
            this.btnViewSecretary.Text = "View Secretary";
            this.btnViewSecretary.UseVisualStyleBackColor = true;
            this.btnViewSecretary.Click += new System.EventHandler(this.btnViewSecretary_Click);
            // 
            // btnAddSecretary
            // 
            this.btnAddSecretary.Location = new System.Drawing.Point(24, 364);
            this.btnAddSecretary.Name = "btnAddSecretary";
            this.btnAddSecretary.Size = new System.Drawing.Size(90, 22);
            this.btnAddSecretary.TabIndex = 85;
            this.btnAddSecretary.Text = "Add Secretary";
            this.btnAddSecretary.UseVisualStyleBackColor = true;
            this.btnAddSecretary.Click += new System.EventHandler(this.btnAddSecretary_Click);
            // 
            // lblDeleteDoctor
            // 
            this.lblDeleteDoctor.AutoSize = true;
            this.lblDeleteDoctor.Location = new System.Drawing.Point(21, 109);
            this.lblDeleteDoctor.Name = "lblDeleteDoctor";
            this.lblDeleteDoctor.Size = new System.Drawing.Size(52, 13);
            this.lblDeleteDoctor.TabIndex = 89;
            this.lblDeleteDoctor.Text = "Delete ID";
            // 
            // txtDeleteDoctor
            // 
            this.txtDeleteDoctor.Location = new System.Drawing.Point(111, 109);
            this.txtDeleteDoctor.Name = "txtDeleteDoctor";
            this.txtDeleteDoctor.Size = new System.Drawing.Size(51, 20);
            this.txtDeleteDoctor.TabIndex = 90;
            // 
            // lblDeleteSecretary
            // 
            this.lblDeleteSecretary.AutoSize = true;
            this.lblDeleteSecretary.Location = new System.Drawing.Point(21, 323);
            this.lblDeleteSecretary.Name = "lblDeleteSecretary";
            this.lblDeleteSecretary.Size = new System.Drawing.Size(86, 13);
            this.lblDeleteSecretary.TabIndex = 91;
            this.lblDeleteSecretary.Text = "Delete Secretary";
            // 
            // txtDeleteSecretary
            // 
            this.txtDeleteSecretary.Location = new System.Drawing.Point(111, 316);
            this.txtDeleteSecretary.Name = "txtDeleteSecretary";
            this.txtDeleteSecretary.Size = new System.Drawing.Size(51, 20);
            this.txtDeleteSecretary.TabIndex = 92;
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 409);
            this.Controls.Add(this.txtDeleteSecretary);
            this.Controls.Add(this.lblDeleteSecretary);
            this.Controls.Add(this.txtDeleteDoctor);
            this.Controls.Add(this.lblDeleteDoctor);
            this.Controls.Add(this.btnDeleteSecretary);
            this.Controls.Add(this.btnUpdateSecretary);
            this.Controls.Add(this.btnViewSecretary);
            this.Controls.Add(this.btnAddSecretary);
            this.Controls.Add(this.gridSecretaries);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtSecretaryName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSecretaryName);
            this.Controls.Add(this.btnDeleteDoctor);
            this.Controls.Add(this.btnUpdateDoctor);
            this.Controls.Add(this.btnViewDoctors);
            this.Controls.Add(this.btnAddDoctor);
            this.Controls.Add(this.gridDoctors);
            this.Controls.Add(this.txtSpecialization);
            this.Controls.Add(this.txtDoctorName);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.lblDoctorName);
            this.Name = "Administrator";
            this.Text = "Administrator";
            ((System.ComponentModel.ISupportInitialize)(this.gridDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSecretaries)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.TextBox txtDoctorName;
        private System.Windows.Forms.TextBox txtSpecialization;
        private System.Windows.Forms.DataGridView gridDoctors;
        private System.Windows.Forms.Button btnDeleteDoctor;
        private System.Windows.Forms.Button btnUpdateDoctor;
        private System.Windows.Forms.Button btnViewDoctors;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Label lblSecretaryName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSecretaryName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DataGridView gridSecretaries;
        private System.Windows.Forms.Button btnDeleteSecretary;
        private System.Windows.Forms.Button btnUpdateSecretary;
        private System.Windows.Forms.Button btnViewSecretary;
        private System.Windows.Forms.Button btnAddSecretary;
        private System.Windows.Forms.Label lblDeleteDoctor;
        private System.Windows.Forms.TextBox txtDeleteDoctor;
        private System.Windows.Forms.Label lblDeleteSecretary;
        private System.Windows.Forms.TextBox txtDeleteSecretary;
    }
}