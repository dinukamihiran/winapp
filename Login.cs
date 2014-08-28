using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;//to use mysql
using System.Security.Cryptography;//to use md5

namespace SLPA
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //mysql
        static string connectionString = "SERVER= localhost;" +
                 "DATABASE=syscall;" +
                 "UID= syscall;" +
                 "PASSWORD= syscall123;";
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        //MySqlConnection conn = new MySqlConnection(connectionString);
                           // cmd = new MySqlCommand(sql, conn);
            
        //
        //
        //Login Form Load
        //
        private void Form1_Load(object sender, EventArgs e)
        {
            
            MaximizeBox = false;
            loginToolStripMenuItem.Enabled = false;
            textBoxUsername.Focus();
            //loading.Hide();
       
        }
        //End Load
        //
        //check the authentication
        //
        private void loadingimage()
        {
            buttonLogin.Show();
            //loading.Hide();
            loading.Text = "Dinuka";
            
        }
        
           
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loading.Text="Loading...";
            buttonLogin.Hide();
            
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "")
            {
                

               /* string connectionString = "SERVER= slpa.knnect.com;" +
                   "DATABASE=syscall;" +
                   "UID= syscall;" +
                   "PASSWORD= syscall123;";
                MySqlConnection conn = null;
                MySqlCommand cmd = null;
                MySqlDataReader reader = null;*/
                try
                {
                    string pwd = CalculateMD5Hash(textBoxPassword.Text);
                    string SQL = "SELECT computer_number,password FROM logins where computer_number='" + textBoxUsername.Text + "' and password='" + pwd + "' ";
                    conn = new MySqlConnection(connectionString);
                    cmd = new MySqlCommand(SQL, conn);
                    conn.Open();
                     
                    reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        String username = reader.GetString("computer_number").ToString(); 
                        try
                        {
                            //mulinma user kenekda kiyala blanna
                            string sql = "SELECT null FROM  administrators WHERE computer_number='" + textBoxUsername.Text + "'";// and password='" + pwd + "'";//ON administrator.computer_number=logins.computer_number";// WHERE computer_number='" + textBox1.Text + "'";// and password='" + hash + "'";
                            conn = new MySqlConnection(connectionString);
                            cmd = new MySqlCommand(sql, conn);
                            conn.Open();

                            reader = cmd.ExecuteReader();

                            if (reader.Read())
                            {
                                String status = "Administrator";
                                this.Hide();
                                Main second = new Main(status, username);
                                second.ShowDialog();
                                this.Show();
                                loadingimage();
                                textBoxUsername.Text = "";
                                textBoxPassword.Text = "";
                            }
                            else
                            {
                                String status = "User";
                                this.Hide();
                                Main second = new Main(status, username);
                                second.ShowDialog();
                                this.Show();
                                loadingimage(); 
                                textBoxUsername.Text = "";
                                textBoxPassword.Text = "";
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
                        MessageBox.Show("Access Denied", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBoxUsername.Text = "";
                        textBoxPassword.Text = "";
                        loadingimage(); 
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
            else if(textBoxUsername.Text=="")
            {
                MessageBox.Show("Please enter Username", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadingimage(); 
                                
            }
            else if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                loadingimage();
            }
            else { }
        }
        //End the user Authentication
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
        //
        //Login Form Menu item
        //
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       //End menu items
    }
}
