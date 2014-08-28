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
    public partial class Add_New_User : Form
    {
        public Add_New_User()
        {
            InitializeComponent();
        }
        //
        //Form Load Event
        //
        private void Add_New_User_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            textBoxUsername.Enabled = false;
        }
        //End load event
        //
        //Save button Click
        //
        String status = "";
        private void SaveNewUser_Click(object sender, EventArgs e)
        {
            if (textBoxComputerNo.Text == "" || textBoxFullName.Text == "" || textBoxPosition.Text == "" || textBoxDivision.Text == ""  || textBoxPassword.Text == "" || (!Administrator.Checked) && (!User.Checked))
            {
                MessageBox.Show("Enterr data");
            }
            else{
                if (Administrator.Checked == true)
                {
                    status = "Administrator";
                }
                else
                {
                    status = "User";
                }
                methodInsertNewUser();
            }
        }
        //method for insert new driver
        public void methodInsertNewUser()
        { 
            String pwd = CalculateMD5Hash(textBoxPassword.Text);
            DialogResult result1 = MessageBox.Show("Are you really want to Add new User?",
           "Important Question",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
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
                        string sql = "INSERT INTO login (computer_number,password,Full_Name,Position,Division) VALUES ('" + textBoxComputerNo.Text + "','" + pwd + "', '" + textBoxFullName.Text + "', '" + textBoxPosition.Text + "','" + textBoxDivision.Text + "')";//,'" + status + "','" + textBox5.Text + "','"+textBox6.Text +"' )";

                        conn = new MySqlConnection(connectionString);
                        cmd = new MySqlCommand(sql, conn);
                        conn.Open();

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("You successfully added New User\nUser id: " + textBoxComputerNo.Text + "\nUser Name: " + textBoxFullName.Text + "\nas " + status, "Done");
                        this.Close();

                        if (status == "Administrator")
                        {
                            string SQL = "INSERT INTO administrator  (computer_number,password,Full_Name,Position,Division) VALUES ('" + textBoxComputerNo.Text + "','" + pwd + "', '" + textBoxFullName.Text + "', '" + textBoxPosition.Text + "','" + textBoxDivision.Text + "')";//,'" + status + "','" + textBox5.Text + "','"+textBox6.Text +"' )";

                            conn = new MySqlConnection(connectionString);
                            cmd = new MySqlCommand(SQL, conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
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
            else { }
        }
        //End save button click activity
        //
        //Cancel button click activity
        //
        private void CancelNewUser_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       //End cancel button activity
       //
       //Enter only numeric values to computer No
       //      
       private void textBoxComputerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
      //End key press event
      //
      //MD5 password convertion
      //        
      public String CalculateMD5Hash(string input)
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
        //End MD5 event
        //
        //Automatically get username
        //
        private void textBoxComputerNo_TextChanged(object sender, EventArgs e)
        {
          textBoxUsername.Text = textBoxComputerNo.Text;
        }
        //End getting username automatically
    }
}

