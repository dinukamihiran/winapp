namespace SLPA
{
    partial class Remove_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Users));
            this.Readpanel = new System.Windows.Forms.Panel();
            this.UserdataGridView = new System.Windows.Forms.DataGridView();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.searchuser = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Searchpanel = new System.Windows.Forms.Panel();
            this.division = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUserDivision = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.head = new System.Windows.Forms.Label();
            this.labelUserPsition = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.label1UserID = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Readpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).BeginInit();
            this.Searchpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Readpanel
            // 
            this.Readpanel.Controls.Add(this.UserdataGridView);
            this.Readpanel.Location = new System.Drawing.Point(12, 12);
            this.Readpanel.Name = "Readpanel";
            this.Readpanel.Size = new System.Drawing.Size(455, 259);
            this.Readpanel.TabIndex = 0;
            // 
            // UserdataGridView
            // 
            this.UserdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserdataGridView.Location = new System.Drawing.Point(3, 3);
            this.UserdataGridView.Name = "UserdataGridView";
            this.UserdataGridView.Size = new System.Drawing.Size(439, 254);
            this.UserdataGridView.TabIndex = 0;
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelPictureBox.BackgroundImage = global::SLPA.Properties.Resources.user;
            this.panelPictureBox.Location = new System.Drawing.Point(15, 2);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(213, 226);
            this.panelPictureBox.TabIndex = 1;
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(147, 295);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(155, 20);
            this.searchBox.TabIndex = 1;
            this.searchBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchBox_KeyPress);
            // 
            // searchuser
            // 
            this.searchuser.Location = new System.Drawing.Point(314, 295);
            this.searchuser.Name = "searchuser";
            this.searchuser.Size = new System.Drawing.Size(75, 23);
            this.searchuser.TabIndex = 2;
            this.searchuser.Text = "search";
            this.searchuser.UseVisualStyleBackColor = true;
            this.searchuser.Click += new System.EventHandler(this.searchuser_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(395, 295);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Searchpanel
            // 
            this.Searchpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Searchpanel.Controls.Add(this.division);
            this.Searchpanel.Controls.Add(this.position);
            this.Searchpanel.Controls.Add(this.user_id);
            this.Searchpanel.Controls.Add(this.user_name);
            this.Searchpanel.Controls.Add(this.label3);
            this.Searchpanel.Controls.Add(this.labelUserDivision);
            this.Searchpanel.Controls.Add(this.back);
            this.Searchpanel.Controls.Add(this.delete);
            this.Searchpanel.Controls.Add(this.head);
            this.Searchpanel.Controls.Add(this.labelUserPsition);
            this.Searchpanel.Controls.Add(this.labelUserName);
            this.Searchpanel.Controls.Add(this.label1UserID);
            this.Searchpanel.Location = new System.Drawing.Point(234, 2);
            this.Searchpanel.Name = "Searchpanel";
            this.Searchpanel.Size = new System.Drawing.Size(233, 287);
            this.Searchpanel.TabIndex = 1;
            // 
            // division
            // 
            this.division.AutoSize = true;
            this.division.Location = new System.Drawing.Point(132, 129);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(42, 13);
            this.division.TabIndex = 48;
            this.division.Text = "division";
            // 
            // position
            // 
            this.position.AutoSize = true;
            this.position.Location = new System.Drawing.Point(132, 106);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(43, 13);
            this.position.TabIndex = 47;
            this.position.Text = "position";
            // 
            // user_id
            // 
            this.user_id.AutoSize = true;
            this.user_id.Location = new System.Drawing.Point(132, 51);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(41, 13);
            this.user_id.TabIndex = 46;
            this.user_id.Text = "user_id";
            // 
            // user_name
            // 
            this.user_name.AutoSize = true;
            this.user_name.Location = new System.Drawing.Point(132, 80);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(56, 13);
            this.user_name.TabIndex = 44;
            this.user_name.Text = "user name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(34, -16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 41;
            this.label3.Text = "Add New Driver";
            // 
            // labelUserDivision
            // 
            this.labelUserDivision.AutoSize = true;
            this.labelUserDivision.Location = new System.Drawing.Point(28, 129);
            this.labelUserDivision.Name = "labelUserDivision";
            this.labelUserDivision.Size = new System.Drawing.Size(44, 13);
            this.labelUserDivision.TabIndex = 40;
            this.labelUserDivision.Text = "Division";
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(31, 203);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 39;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(131, 203);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 38;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // head
            // 
            this.head.AutoSize = true;
            this.head.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.head.ForeColor = System.Drawing.Color.DarkOrchid;
            this.head.Location = new System.Drawing.Point(27, 13);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(162, 24);
            this.head.TabIndex = 37;
            this.head.Text = "User Information";
            // 
            // labelUserPsition
            // 
            this.labelUserPsition.AutoSize = true;
            this.labelUserPsition.Location = new System.Drawing.Point(28, 106);
            this.labelUserPsition.Name = "labelUserPsition";
            this.labelUserPsition.Size = new System.Drawing.Size(44, 13);
            this.labelUserPsition.TabIndex = 36;
            this.labelUserPsition.Text = "Position";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(28, 80);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(60, 13);
            this.labelUserName.TabIndex = 35;
            this.labelUserName.Text = "User Name";
            // 
            // label1UserID
            // 
            this.label1UserID.AutoSize = true;
            this.label1UserID.Location = new System.Drawing.Point(28, 51);
            this.label1UserID.Name = "label1UserID";
            this.label1UserID.Size = new System.Drawing.Size(41, 13);
            this.label1UserID.TabIndex = 34;
            this.label1UserID.Text = "User Id";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.ForeColor = System.Drawing.Color.Maroon;
            this.labelInfo.Location = new System.Drawing.Point(12, 286);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(129, 32);
            this.labelInfo.TabIndex = 4;
            this.labelInfo.Text = "Enetr the User ID \r\nto see the profile";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(478, 324);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Remove_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 330);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.Searchpanel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.searchuser);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.Readpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Remove_Users";
            this.Text = "Remove Users";
            this.Load += new System.EventHandler(this.Remove_Users_Load);
            this.Readpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UserdataGridView)).EndInit();
            this.Searchpanel.ResumeLayout(false);
            this.Searchpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Readpanel;
        private System.Windows.Forms.DataGridView UserdataGridView;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button searchuser;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Panel Searchpanel;
        private System.Windows.Forms.Label division;
        private System.Windows.Forms.Label position;
        private System.Windows.Forms.Label user_id;
        private System.Windows.Forms.Label user_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUserDivision;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label head;
        private System.Windows.Forms.Label labelUserPsition;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label label1UserID;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}