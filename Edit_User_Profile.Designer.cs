namespace SLPA
{
    partial class Edit_User_Profile
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxComputerNo = new System.Windows.Forms.TextBox();
            this.Division = new System.Windows.Forms.Label();
            this.Position = new System.Windows.Forms.Label();
            this.FullName = new System.Windows.Forms.Label();
            this.ComputerNo = new System.Windows.Forms.Label();
            this.CancelEditProfile = new System.Windows.Forms.Button();
            this.UpdateUser = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.RadioButton();
            this.Administrator = new System.Windows.Forms.RadioButton();
            this.labelStatus = new System.Windows.Forms.Label();
            this.changePwd = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxDivision);
            this.groupBox4.Controls.Add(this.textBoxPosition);
            this.groupBox4.Controls.Add(this.textBoxName);
            this.groupBox4.Controls.Add(this.textBoxComputerNo);
            this.groupBox4.Controls.Add(this.Division);
            this.groupBox4.Controls.Add(this.Position);
            this.groupBox4.Controls.Add(this.FullName);
            this.groupBox4.Controls.Add(this.ComputerNo);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 132);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Personal Info";
            // 
            // textBoxDivision
            // 
            this.textBoxDivision.Location = new System.Drawing.Point(99, 97);
            this.textBoxDivision.Name = "textBoxDivision";
            this.textBoxDivision.Size = new System.Drawing.Size(187, 20);
            this.textBoxDivision.TabIndex = 7;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(99, 71);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(187, 20);
            this.textBoxPosition.TabIndex = 6;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(99, 44);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxComputerNo
            // 
            this.textBoxComputerNo.Location = new System.Drawing.Point(99, 20);
            this.textBoxComputerNo.Name = "textBoxComputerNo";
            this.textBoxComputerNo.Size = new System.Drawing.Size(187, 20);
            this.textBoxComputerNo.TabIndex = 4;
            this.textBoxComputerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(10, 104);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(44, 13);
            this.Division.TabIndex = 3;
            this.Division.Text = "Division";
            // 
            // Position
            // 
            this.Position.AutoSize = true;
            this.Position.Location = new System.Drawing.Point(10, 78);
            this.Position.Name = "Position";
            this.Position.Size = new System.Drawing.Size(44, 13);
            this.Position.TabIndex = 2;
            this.Position.Text = "Position";
            // 
            // FullName
            // 
            this.FullName.AutoSize = true;
            this.FullName.Location = new System.Drawing.Point(10, 52);
            this.FullName.Name = "FullName";
            this.FullName.Size = new System.Drawing.Size(54, 13);
            this.FullName.TabIndex = 1;
            this.FullName.Text = "Full Name";
            // 
            // ComputerNo
            // 
            this.ComputerNo.AutoSize = true;
            this.ComputerNo.Location = new System.Drawing.Point(10, 28);
            this.ComputerNo.Name = "ComputerNo";
            this.ComputerNo.Size = new System.Drawing.Size(30, 13);
            this.ComputerNo.TabIndex = 0;
            this.ComputerNo.Text = "S/N ";
            // 
            // CancelEditProfile
            // 
            this.CancelEditProfile.Location = new System.Drawing.Point(141, 267);
            this.CancelEditProfile.Name = "CancelEditProfile";
            this.CancelEditProfile.Size = new System.Drawing.Size(75, 23);
            this.CancelEditProfile.TabIndex = 8;
            this.CancelEditProfile.Text = "Cancel";
            this.CancelEditProfile.UseVisualStyleBackColor = true;
            this.CancelEditProfile.Click += new System.EventHandler(this.CancelEditProfile_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.Location = new System.Drawing.Point(229, 267);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(75, 23);
            this.UpdateUser.TabIndex = 7;
            this.UpdateUser.Text = "Save";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.User);
            this.groupBox2.Controls.Add(this.Administrator);
            this.groupBox2.Controls.Add(this.labelStatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 81);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Your Role";
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(99, 43);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(47, 17);
            this.User.TabIndex = 2;
            this.User.TabStop = true;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // Administrator
            // 
            this.Administrator.AutoSize = true;
            this.Administrator.Location = new System.Drawing.Point(99, 20);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(85, 17);
            this.Administrator.TabIndex = 1;
            this.Administrator.TabStop = true;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 20);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(37, 13);
            this.labelStatus.TabIndex = 0;
            this.labelStatus.Text = "Status";
            // 
            // changePwd
            // 
            this.changePwd.Location = new System.Drawing.Point(12, 267);
            this.changePwd.Name = "changePwd";
            this.changePwd.Size = new System.Drawing.Size(102, 23);
            this.changePwd.TabIndex = 9;
            this.changePwd.Text = "Change Password";
            this.changePwd.UseVisualStyleBackColor = true;
            this.changePwd.Click += new System.EventHandler(this.changePwd_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(111, 151);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(35, 13);
            this.password.TabIndex = 10;
            this.password.Text = "label1";
            // 
            // Edit_User_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 303);
            this.Controls.Add(this.password);
            this.Controls.Add(this.changePwd);
            this.Controls.Add(this.CancelEditProfile);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Edit_User_Profile";
            this.Text = "Edit User Profile";
            this.Load += new System.EventHandler(this.Edit_User_Profile_Load_1);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxComputerNo;
        private System.Windows.Forms.Label Division;
        private System.Windows.Forms.Label Position;
        private System.Windows.Forms.Label FullName;
        private System.Windows.Forms.Label ComputerNo;
        private System.Windows.Forms.Button CancelEditProfile;
        private System.Windows.Forms.Button UpdateUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.RadioButton Administrator;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button changePwd;
        private System.Windows.Forms.Label password;
    }
}