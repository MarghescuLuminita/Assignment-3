namespace DoctorClient
{
    partial class Doctor
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.dtDate = new System.Windows.Forms.DateTimePicker();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.txtTreatment = new System.Windows.Forms.TextBox();
            this.gridConsultations = new System.Windows.Forms.DataGridView();
            this.btnAddConsultation = new System.Windows.Forms.Button();
            this.btnViewConsultations = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultations)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(22, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(99, 17);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(22, 51);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // dtDate
            // 
            this.dtDate.Location = new System.Drawing.Point(99, 45);
            this.dtDate.Name = "dtDate";
            this.dtDate.Size = new System.Drawing.Size(163, 20);
            this.dtDate.TabIndex = 3;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(22, 84);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(55, 13);
            this.lblTreatment.TabIndex = 4;
            this.lblTreatment.Text = "Treatment";
            // 
            // txtTreatment
            // 
            this.txtTreatment.Location = new System.Drawing.Point(99, 84);
            this.txtTreatment.Multiline = true;
            this.txtTreatment.Name = "txtTreatment";
            this.txtTreatment.Size = new System.Drawing.Size(163, 48);
            this.txtTreatment.TabIndex = 13;
            // 
            // gridConsultations
            // 
            this.gridConsultations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridConsultations.Location = new System.Drawing.Point(298, 12);
            this.gridConsultations.Name = "gridConsultations";
            this.gridConsultations.Size = new System.Drawing.Size(281, 120);
            this.gridConsultations.TabIndex = 14;
            // 
            // btnAddConsultation
            // 
            this.btnAddConsultation.Location = new System.Drawing.Point(25, 155);
            this.btnAddConsultation.Name = "btnAddConsultation";
            this.btnAddConsultation.Size = new System.Drawing.Size(106, 23);
            this.btnAddConsultation.TabIndex = 15;
            this.btnAddConsultation.Text = "Add Consultation";
            this.btnAddConsultation.UseVisualStyleBackColor = true;
            this.btnAddConsultation.Click += new System.EventHandler(this.btnAddConsultation_Click);
            // 
            // btnViewConsultations
            // 
            this.btnViewConsultations.Location = new System.Drawing.Point(148, 155);
            this.btnViewConsultations.Name = "btnViewConsultations";
            this.btnViewConsultations.Size = new System.Drawing.Size(114, 23);
            this.btnViewConsultations.TabIndex = 16;
            this.btnViewConsultations.Text = "View Consultations";
            this.btnViewConsultations.UseVisualStyleBackColor = true;
            this.btnViewConsultations.Click += new System.EventHandler(this.btnViewConsultations_Click);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 204);
            this.Controls.Add(this.btnViewConsultations);
            this.Controls.Add(this.btnAddConsultation);
            this.Controls.Add(this.gridConsultations);
            this.Controls.Add(this.txtTreatment);
            this.Controls.Add(this.lblTreatment);
            this.Controls.Add(this.dtDate);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "Doctor";
            this.Text = "Doctor";
            ((System.ComponentModel.ISupportInitialize)(this.gridConsultations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtDate;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.TextBox txtTreatment;
        private System.Windows.Forms.DataGridView gridConsultations;
        private System.Windows.Forms.Button btnAddConsultation;
        private System.Windows.Forms.Button btnViewConsultations;
    }
}