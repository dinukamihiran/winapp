using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SLPA
{
    public partial class Edit_User_Profile : Form
    {
        private String status;//declare two variables for hold status and username
        private String username; 

        public Edit_User_Profile(String status,String username)
        {
            InitializeComponent();
            this.status=status;
            this.username = username;
        }
        //
        //Form load event
        //
        private void Edit_User_Profile_Load_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            MaximizeBox = false;
            userprofile();
            password.Hide();
            Cursor.Current = Cursors.Default; 
        }
       
        private void userprofile()
        {
            string connectionString = "SERVER= localhost;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;

            try
            {
                string sql = "SELECT computer_number,password,Full_Name,Position,Division FROM logins WHERE computer_number = '" + username + "'";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();
                 if (reader.Read())
                 { 
                    textBoxComputerNo.Text = reader.GetString("computer_number");
                    textBoxName.Text = reader.GetString("Full_Name");
                    textBoxPosition.Text = reader.GetString("Position");
                    textBoxDivision.Text = reader.GetString("Division");
                    password.Text = reader.GetString("password");
                    
                    if (status=="Administrator")
                    {
                        Administrator.Checked = true;
                        Administrator.Enabled = false;
                        User.Enabled = false;
                    }
                    else
                    {
                        User.Checked = true;
                        User.Enabled = false;
                        Administrator.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("An error occurred {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (reader != null) reader.Close();
                if (conn != null) conn.Close();
            }
        }
        //End form load event
        //
        //Click the save button
        //
        private void UpdateUser_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you really want to update profile?",
             "Important Question",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {
                string connectionSQL = "server=localhost;user id=syscall;password=syscall123;database=syscall;";
                MySqlConnection conn = new MySqlConnection(connectionSQL);

                try
                {
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE logins SET Full_Name= '" + textBoxName.Text + "' WHERE computer_number='" + textBoxComputerNo.Text + "'", conn);
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE logins SET Position='" + textBoxPosition.Text + "' WHERE computer_number='" + textBoxComputerNo.Text + "'", conn);
                    MySqlCommand cmd3 = new MySqlCommand("UPDATE logins SET Division='" + textBoxDivision.Text + "' WHERE computer_number='" + textBoxComputerNo.Text + "'", conn);
                    conn.Open();

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd3.ExecuteNonQuery();

                    this.Close();
                    MessageBox.Show("Profile Updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        //End click save button
        //
        //Click cancel button
        //
        private void CancelEditProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End cancel activity
        //
        //Password change activity
        //
        private void changePwd_Click(object sender, EventArgs e)
        {
            Change_Password seven = new Change_Password(username, password.Text,status);
            seven.ShowDialog();
        }
        //End password change activity
        //
        //Enter only numeric values to Computer No
        //
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        //End
    }
}
