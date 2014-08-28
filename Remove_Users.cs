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
    public partial class Remove_Users : Form
    {
        private String status;
        public Remove_Users(String status)
        {
            this.status = status;
            InitializeComponent();
        }
        static string connectionString = "SERVER= localhost;" +
                 "DATABASE=syscall;" +
                 "UID= syscall;" +
                 "PASSWORD= syscall123;";
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        //
        //Form load event
        //
        private void Remove_Users_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            Cursor.Current = Cursors.WaitCursor; 
            MaximizeBox = false;
            panelPictureBox.Hide();
            Readpanel.Show();
            Searchpanel.Hide();
            methodload();
            pictureBox1.Hide();
            Cursor.Current = Cursors.Default; 
        }
       
        private void methodload()
        {
            /*string connectionString = "SERVER= localhost;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";    */
            string sql = "SELECT computer_number,Full_Name,Position,Division FROM logins";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "users");
            connection.Close();
            UserdataGridView.DataSource = ds;
            UserdataGridView.DataMember = "users";
            UserdataGridView.ReadOnly = true;
        }
        //end load
        //
        //search button click
        //
        private void searchuser_Click(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
            {
               /* string connectionString = "SERVER= localhost;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";
                MySqlConnection conn = null;
                MySqlCommand cmd = null;
                MySqlDataReader reader = null;*/
                Cursor.Current = Cursors.WaitCursor; 
                int idNo = int.Parse(searchBox.Text);
                try
                {
                    string sql = "SELECT computer_number,Full_Name,Position,Division FROM logins WHERE computer_number = '" + idNo + "'";// or Driver_Name='" + textBox1.Text + "'";
                    conn = new MySqlConnection(connectionString);
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Readpanel.Hide();
                        panelPictureBox.Show();
                        Searchpanel.Show();
                        

                        user_id.Text = reader.GetString("computer_number");
                        user_name.Text = reader.GetString("Full_Name");
                        position.Text = reader.GetString("Position");
                        division.Text = reader.GetString("Division");

                        searchBox.Text = "";

                        Cursor.Current = Cursors.Default; 
                    }
                    else
                    {
                        MessageBox.Show("Record could not found", "Error in Read");
                        searchBox.Text = "";
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
            else
            {
                MessageBox.Show("Please enter ID number to search", "Error in Read", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //end search button event
        //
        //back button click
        //
        private void back_Click(object sender, EventArgs e)
        {
            Searchpanel.Hide();
            panelPictureBox.Hide();
            Readpanel.Show();
        }
        //end back button click event
        //
        //enter only numeric values to searchbox
        //
        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        //end search user
        //
        //delete button click
        //
        private void delete_Click(object sender, EventArgs e)
        {

            DialogResult result1 = MessageBox.Show("Are you really want to delete user?",
            "Important Question",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {
                string connectionSQL = "server=localhost;user id=syscall;password=syscall123;database=syscall;";
                MySqlConnection conn = new MySqlConnection(connectionSQL);

                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE  FROM logins WHERE computer_number='" + user_id.Text + "'", conn);
                    MySqlCommand cmd1 = new MySqlCommand("DELETE  FROM administrators WHERE computer_number='" + user_id.Text + "'", conn);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();

                    Cursor.Current = Cursors.WaitCursor;
                    panelPictureBox.Hide();
                    Searchpanel.Hide();
                    Readpanel.Show();
                    MessageBox.Show("You successfully remove the user", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    methodload();
                    Cursor.Current = Cursors.Default; 
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
        //end delete button activity
        //cancel button click
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //end cancel button activity
    }
}


