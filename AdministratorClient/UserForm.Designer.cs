namespace AdministratorClient
{
    partial class UserForm
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblAdministrator = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblSecretary = new System.Windows.Forms.Label();
            this.chkAdministrator = new System.Windows.Forms.CheckBox();
            this.chkDoctor = new System.Windows.Forms.CheckBox();
            this.chkSecretary = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(12, 31);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 59);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(97, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(97, 52);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 3;
            // 
            // lblAdministrator
            // 
            this.lblAdministrator.AutoSize = true;
            this.lblAdministrator.Location = new System.Drawing.Point(12, 86);
            this.lblAdministrator.Name = "lblAdministrator";
            this.lblAdministrator.Size = new System.Drawing.Size(67, 13);
            this.lblAdministrator.TabIndex = 4;
            this.lblAdministrator.Text = "Administrator";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(12, 111);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(39, 13);
            this.lblDoctor.TabIndex = 5;
            this.lblDoctor.Text = "Doctor";
            // 
            // lblSecretary
            // 
            this.lblSecretary.AutoSize = true;
            this.lblSecretary.Location = new System.Drawing.Point(12, 137);
            this.lblSecretary.Name = "lblSecretary";
            this.lblSecretary.Size = new System.Drawing.Size(52, 13);
            this.lblSecretary.TabIndex = 6;
            this.lblSecretary.Text = "Secretary";
            // 
            // chkAdministrator
            // 
            this.chkAdministrator.AutoSize = true;
            this.chkAdministrator.Location = new System.Drawing.Point(97, 86);
            this.chkAdministrator.Name = "chkAdministrator";
            this.chkAdministrator.Size = new System.Drawing.Size(15, 14);
            this.chkAdministrator.TabIndex = 7;
            this.chkAdministrator.UseVisualStyleBackColor = true;
            // 
            // chkDoctor
            // 
            this.chkDoctor.AutoSize = true;
            this.chkDoctor.Location = new System.Drawing.Point(97, 110);
            this.chkDoctor.Name = "chkDoctor";
            this.chkDoctor.Size = new System.Drawing.Size(15, 14);
            this.chkDoctor.TabIndex = 8;
            this.chkDoctor.UseVisualStyleBackColor = true;
            // 
            // chkSecretary
            // 
            this.chkSecretary.AutoSize = true;
            this.chkSecretary.Location = new System.Drawing.Point(97, 133);
            this.chkSecretary.Name = "chkSecretary";
            this.chkSecretary.Size = new System.Drawing.Size(15, 14);
            this.chkSecretary.TabIndex = 9;
            this.chkSecretary.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Location = new System.Drawing.Point(76, 178);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(75, 23);
            this.btnAddUser.TabIndex = 10;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.chkSecretary);
            this.Controls.Add(this.chkDoctor);
            this.Controls.Add(this.chkAdministrator);
            this.Controls.Add(this.lblSecretary);
            this.Controls.Add(this.lblDoctor);
            this.Controls.Add(this.lblAdministrator);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblAdministrator;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblSecretary;
        private System.Windows.Forms.CheckBox chkAdministrator;
        private System.Windows.Forms.CheckBox chkDoctor;
        private System.Windows.Forms.CheckBox chkSecretary;
        private System.Windows.Forms.Button btnAddUser;
    }
}