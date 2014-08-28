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
    public partial class Driver_Details_Update : Form
    {
        public Driver_Details_Update(String id, String name,String vehicleNumber)
        {
            InitializeComponent();
            textBoxDriverId.Text = id;
            textBoxDriverName.Text = name;
            vehicletxt.Text = vehicleNumber;
        }
        static string connectionString = "SERVER= localhost;" +
                 "DATABASE=syscall;" +
                 "UID= syscall;" +
                 "PASSWORD= syscall123;";
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        //Form load event
        //
        private void Driver_Details_Update_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
           // getLatitudeLongitude();
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        //
        //Cancel button click
        //
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //End cancel button activity
        //
        //update button click
        //
        private void update_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you really want to update record?",
            "Important Question",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {
                string connectionSQL = "server=localhost;user id=syscall;password=syscall123;database=syscall;";
                MySqlConnection conn = new MySqlConnection(connectionSQL);

                try
                {
                    MySqlCommand cmd1 = new MySqlCommand("UPDATE job_details SET Destination= '" + comboBoxDestinationSelection.SelectedItem+ "' WHERE Driver_id='" + textBoxDriverId.Text + "'", conn);
                    MySqlCommand cmd2 = new MySqlCommand("UPDATE job_details SET CurrentTime='" + time.Text + "' WHERE Driver_id='" + textBoxDriverId.Text + "'", conn);
                    MySqlCommand cmd4 = new MySqlCommand("UPDATE job_details SET  Driver_Name='" + textBoxDriverName.Text + "' WHERE Driver_id='" + textBoxDriverId.Text + "'", conn);
                    MySqlCommand cmd5 = new MySqlCommand("UPDATE job_details SET CurrentDate='" + date.Text + "' WHERE Driver_id='" + textBoxDriverId.Text + "'", conn);
                    MySqlCommand cmd6 = new MySqlCommand("UPDATE job_details SET  Vehicle_No='" + vehicletxt.Text + "' WHERE Driver_id='" + textBoxDriverId.Text + "'", conn);
                    conn.Open();

                    cmd1.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();
                    cmd4.ExecuteNonQuery();
                    cmd5.ExecuteNonQuery();
                    cmd6.ExecuteNonQuery();
                    this.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Can't connect to database\n" + ex.ToString());
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("Record updated successfully");
                }
            }
            else { }
        }
        //End update button activity
        //
        //town names are load to combobox
        //
       /* private void getLatitudeLongitude()
        {
          /*  string connectionString = "SERVER= localhost;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;
            try
            {
                string sql = "SELECT townname FROM destination_coordinates";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxDestinationSelection.Items.Add(reader.GetString("townname"));
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
        */
        //End combobox load activity
        //
        //Latitude and Longitude values get according to combobox selected town
        //
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           /* string connectionString = "SERVER= slpa.fit11.tk;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;*/
            try
            {
                string sql = "SELECT latitude,longitude FROM destination_coordinates  WHERE townname = '" + comboBoxDestinationSelection.SelectedItem + "'";// or Driver_Name='" + textBox1.Text + "'";

                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    LatitudeValue.Text = reader.GetString("latitude");
                    LongitudeValue.Text = reader.GetString("longitude");
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
        //End getting Latitude and Longitude
        //
        //If destination is not here load the web browser and add new destination
        //
        private void AddDestination_Click(object sender, EventArgs e)
        {
            AddLocations_forEditDrivers webBrowser = new AddLocations_forEditDrivers();
            webBrowser.ShowDialog();
            comboBoxDestinationSelection.Items.Clear();
           // getLatitudeLongitude();
        }

        String town = "";
        private void comboBoxDestinationSelection_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBoxDestinationSelection.Text.Length >= 3)
            {
                town = comboBoxDestinationSelection.Text.ToString();
                add1(town);
            }
        }
        private void add1(String coodinate)
        {
            /*  string connectionString = "SERVER= slpa.knnect.com;" +
                    "DATABASE=syscall;" +
                    "UID= syscall;" +
                    "PASSWORD= syscall123;";
              MySqlConnection conn = null;
              MySqlCommand cmd = null;
              MySqlDataReader reader = null;*/
            try
            {
                string sql = "SELECT townname FROM destination_coordinates where townname like'" + coodinate + "%' ";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    comboBoxDestinationSelection.Items.Add(reader.GetString("townname"));
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

        
       //End web browser activity

    }
}

