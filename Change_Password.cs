using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;

namespace SLPA
{
    public partial class Change_Password : Form
    {
        private String username;
        private String password;
        private string status;//to check update admin and user tables

        public Change_Password(String username,String password,String status)
        {
            InitializeComponent();
            this.username= username;
            this.password = password;
            this.status = status;
        }
        //
        //Form load
        //
        private void Change_Password_Load_1(object sender, EventArgs e)
        {
            MaximizeBox = false; 
        }
        //end load
        //
        //password set button click
        //
        private void setpwd_Click(object sender, EventArgs e)
        {
            string pwd = CalculateMD5Hash(oldpwd.Text);
            if (pwd == password)
            {

                if (newpwd.Text == confirmpwd.Text)
                {
                    DialogResult result1 = MessageBox.Show("Are you really want to update profile?",
                     "Important Question",
                      MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result1 == DialogResult.Yes)
                    {
                        string connectionSQL = "server=slpa.fit11.tk;user id=syscall;password=syscall123;database=syscall;";
                        MySqlConnection conn = new MySqlConnection(connectionSQL);

                        try
                        {
                            string newpassword = CalculateMD5Hash(confirmpwd.Text);
                            MySqlCommand cmd1 = new MySqlCommand("UPDATE logins SET password= '" +newpassword  + "' WHERE computer_number='" + username + "' AND password='" + password + "'", conn);
                            conn.Open();

                            cmd1.ExecuteNonQuery();
                              /*  if (status == "Administrator")
                                {
                                    MySqlCommand cmd2 = new MySqlCommand("UPDATE administrators SET password= '" + newpassword + "' WHERE computer_number='" + username + "' AND password='" + password + "'", conn);
                                    cmd2.ExecuteNonQuery();
                                }
                               */
                            this.Close();
                            MessageBox.Show("Password Updated", "Done");

                        }
                        catch (MySqlException ex)
                        {
                            MessageBox.Show("Can't connect to database\n" + ex.ToString());
                        }
                        finally
                        {
                            conn.Close();

                        }
                    }
                    else { }
                }
                else
                {
                    MessageBox.Show("Your new password and confirmation password is not matched", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    newpwd.Text = "";
                    confirmpwd.Text = "";
                    oldpwd.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Your old password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                newpwd.Text = "";
                confirmpwd.Text = "";
                oldpwd.Text = "";
            }

        }
        //end set button click activity
        //
        //cancel button click
        //
        private void cancelpwd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //end cancel button activity
        //
        //This method convert MD5 String to String.Then that value check with the user input password value
        //
        public string CalculateMD5Hash(string input)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString().ToLower();
        }
        //End MD5 operation
      }
}
