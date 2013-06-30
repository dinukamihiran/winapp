namespace SLPA
{
    partial class Add_New_User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDivision = new System.Windows.Forms.TextBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.textBoxComputerNo = new System.Windows.Forms.TextBox();
            this.division = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.Name = new System.Windows.Forms.Label();
            this.computerNo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.User = new System.Windows.Forms.RadioButton();
            this.Administrator = new System.Windows.Forms.RadioButton();
            this.labelstatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.pasword = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.SaveNewUser = new System.Windows.Forms.Button();
            this.CancelNewUser = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDivision);
            this.groupBox1.Controls.Add(this.textBoxPosition);
            this.groupBox1.Controls.Add(this.textBoxFullName);
            this.groupBox1.Controls.Add(this.textBoxComputerNo);
            this.groupBox1.Controls.Add(this.division);
            this.groupBox1.Controls.Add(this.position);
            this.groupBox1.Controls.Add(this.Name);
            this.groupBox1.Controls.Add(this.computerNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Info";
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
            // textBoxFullName
            // 
            this.textBoxFullName.Location = new System.Drawing.Point(99, 44);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(187, 20);
            this.textBoxFullName.TabIndex = 5;
            // 
            // textBoxComputerNo
            // 
            this.textBoxComputerNo.Location = new System.Drawing.Point(99, 20);
            this.textBoxComputerNo.Name = "textBoxComputerNo";
            this.textBoxComputerNo.Size = new System.Drawing.Size(187, 20);
            this.textBoxComputerNo.TabIndex = 4;
            this.textBoxComputerNo.TextChanged += new System.EventHandler(this.textBoxComputerNo_TextChanged);
            this.textBoxComputerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxComputerNo_KeyPress);
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(10, 104);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(44, 13);
            this.division.TabIndex = 3;
            this.division.Text = "Division";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(10, 78);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(44, 13);
            this.position.TabIndex = 2;
            this.position.Text = "Position";
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(10, 52);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(54, 13);
            this.Name.TabIndex = 1;
            this.Name.Text = "Full Name";
            // 
            // computerNo
            // 
            this.computerNo.AutoSize = true;
            this.computerNo.Location = new System.Drawing.Point(10, 28);
            this.computerNo.Name = "computerNo";
            this.computerNo.Size = new System.Drawing.Size(30, 13);
            this.computerNo.TabIndex = 0;
            this.computerNo.Text = "S/N ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.User);
            this.groupBox2.Controls.Add(this.Administrator);
            this.groupBox2.Controls.Add(this.labelstatus);
            this.groupBox2.Location = new System.Drawing.Point(12, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select your Role";
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
            // labelstatus
            // 
            this.labelstatus.AutoSize = true;
            this.labelstatus.Location = new System.Drawing.Point(12, 20);
            this.labelstatus.Name = "labelstatus";
            this.labelstatus.Size = new System.Drawing.Size(37, 13);
            this.labelstatus.TabIndex = 0;
            this.labelstatus.Text = "Status";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxPassword);
            this.groupBox3.Controls.Add(this.textBoxUsername);
            this.groupBox3.Controls.Add(this.pasword);
            this.groupBox3.Controls.Add(this.username);
            this.groupBox3.Location = new System.Drawing.Point(12, 157);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 81);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login Info";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(99, 44);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(187, 20);
            this.textBoxPassword.TabIndex = 3;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(99, 17);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(187, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // pasword
            // 
            this.pasword.AutoSize = true;
            this.pasword.Location = new System.Drawing.Point(15, 49);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(53, 13);
            this.pasword.TabIndex = 1;
            this.pasword.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(15, 20);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(60, 13);
            this.username.TabIndex = 0;
            this.username.Text = "User Name";
            // 
            // SaveNewUser
            // 
            this.SaveNewUser.Location = new System.Drawing.Point(229, 350);
            this.SaveNewUser.Name = "SaveNewUser";
            this.SaveNewUser.Size = new System.Drawing.Size(75, 23);
            this.SaveNewUser.TabIndex = 3;
            this.SaveNewUser.Text = "Save";
            this.SaveNewUser.UseVisualStyleBackColor = true;
            this.SaveNewUser.Click += new System.EventHandler(this.SaveNewUser_Click);
            // 
            // CancelNewUser
            // 
            this.CancelNewUser.Location = new System.Drawing.Point(132, 350);
            this.CancelNewUser.Name = "CancelNewUser";
            this.CancelNewUser.Size = new System.Drawing.Size(75, 23);
            this.CancelNewUser.TabIndex = 4;
            this.CancelNewUser.Text = "Cancel";
            this.CancelNewUser.UseVisualStyleBackColor = true;
            this.CancelNewUser.Click += new System.EventHandler(this.CancelNewUser_Click);
            // 
            // Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 385);
            this.Controls.Add(this.CancelNewUser);
            this.Controls.Add(this.SaveNewUser);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.Add_New_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label division;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label computerNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton User;
        private System.Windows.Forms.RadioButton Administrator;
        private System.Windows.Forms.Label labelstatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label pasword;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button SaveNewUser;
        private System.Windows.Forms.TextBox textBoxDivision;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.TextBox textBoxComputerNo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button CancelNewUser;
    }
}