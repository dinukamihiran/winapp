namespace SLPA
{
    partial class Change_Password
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
            this.labelConPwd = new System.Windows.Forms.Label();
            this.labelNewPwd = new System.Windows.Forms.Label();
            this.labelOldPwd = new System.Windows.Forms.Label();
            this.confirmpwd = new System.Windows.Forms.TextBox();
            this.newpwd = new System.Windows.Forms.TextBox();
            this.oldpwd = new System.Windows.Forms.TextBox();
            this.setpwd = new System.Windows.Forms.Button();
            this.cancelpwd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelConPwd);
            this.groupBox1.Controls.Add(this.labelNewPwd);
            this.groupBox1.Controls.Add(this.labelOldPwd);
            this.groupBox1.Controls.Add(this.confirmpwd);
            this.groupBox1.Controls.Add(this.newpwd);
            this.groupBox1.Controls.Add(this.oldpwd);
            this.groupBox1.Location = new System.Drawing.Point(25, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chang Password";
            // 
            // labelConPwd
            // 
            this.labelConPwd.AutoSize = true;
            this.labelConPwd.Location = new System.Drawing.Point(6, 74);
            this.labelConPwd.Name = "labelConPwd";
            this.labelConPwd.Size = new System.Drawing.Size(91, 13);
            this.labelConPwd.TabIndex = 5;
            this.labelConPwd.Text = "Confirm Password";
            // 
            // labelNewPwd
            // 
            this.labelNewPwd.AutoSize = true;
            this.labelNewPwd.Location = new System.Drawing.Point(6, 50);
            this.labelNewPwd.Name = "labelNewPwd";
            this.labelNewPwd.Size = new System.Drawing.Size(78, 13);
            this.labelNewPwd.TabIndex = 4;
            this.labelNewPwd.Text = "New Password";
            // 
            // labelOldPwd
            // 
            this.labelOldPwd.AutoSize = true;
            this.labelOldPwd.Location = new System.Drawing.Point(7, 26);
            this.labelOldPwd.Name = "labelOldPwd";
            this.labelOldPwd.Size = new System.Drawing.Size(72, 13);
            this.labelOldPwd.TabIndex = 3;
            this.labelOldPwd.Text = "Old Password";
            // 
            // confirmpwd
            // 
            this.confirmpwd.Location = new System.Drawing.Point(111, 73);
            this.confirmpwd.Name = "confirmpwd";
            this.confirmpwd.PasswordChar = '*';
            this.confirmpwd.Size = new System.Drawing.Size(130, 20);
            this.confirmpwd.TabIndex = 2;
            // 
            // newpwd
            // 
            this.newpwd.Location = new System.Drawing.Point(111, 47);
            this.newpwd.Name = "newpwd";
            this.newpwd.PasswordChar = '*';
            this.newpwd.Size = new System.Drawing.Size(130, 20);
            this.newpwd.TabIndex = 1;
            // 
            // oldpwd
            // 
            this.oldpwd.Location = new System.Drawing.Point(111, 19);
            this.oldpwd.Name = "oldpwd";
            this.oldpwd.PasswordChar = '*';
            this.oldpwd.Size = new System.Drawing.Size(130, 20);
            this.oldpwd.TabIndex = 0;
            // 
            // setpwd
            // 
            this.setpwd.Location = new System.Drawing.Point(191, 139);
            this.setpwd.Name = "setpwd";
            this.setpwd.Size = new System.Drawing.Size(75, 23);
            this.setpwd.TabIndex = 3;
            this.setpwd.Text = "set";
            this.setpwd.UseVisualStyleBackColor = true;
            this.setpwd.Click += new System.EventHandler(this.setpwd_Click);
            // 
            // cancelpwd
            // 
            this.cancelpwd.Location = new System.Drawing.Point(98, 139);
            this.cancelpwd.Name = "cancelpwd";
            this.cancelpwd.Size = new System.Drawing.Size(75, 23);
            this.cancelpwd.TabIndex = 4;
            this.cancelpwd.Text = "cancel";
            this.cancelpwd.UseVisualStyleBackColor = true;
            this.cancelpwd.Click += new System.EventHandler(this.cancelpwd_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.cancelpwd);
            this.Controls.Add(this.setpwd);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Change_Password";
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.Change_Password_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox confirmpwd;
        private System.Windows.Forms.TextBox newpwd;
        private System.Windows.Forms.TextBox oldpwd;
        private System.Windows.Forms.Button setpwd;
        private System.Windows.Forms.Button cancelpwd;
        private System.Windows.Forms.Label labelConPwd;
        private System.Windows.Forms.Label labelNewPwd;
        private System.Windows.Forms.Label labelOldPwd;
    }
}