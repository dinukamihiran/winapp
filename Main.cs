using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Diagnostics;//to add link

namespace SLPA
{
    public partial class Main : Form
    {
        private string status;
        private string username;
        public Main(String status, String username)
        {
            InitializeComponent();

            this.status = status;
            this.username = username;
        }
        
        static string connectionString = "SERVER= localhost;" +
                 "DATABASE=syscall;" +
                 "UID= syscall;" +
                 "PASSWORD= syscall123;";
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        MySqlDataReader reader = null;
        //
        //check the person adimin or a user
        //
        private void adminCheck()
        {
            if (status == "Administrator")
            {

                addUserToolStripMenuItem.Visible = true;
                removeUserToolStripMenuItem.Visible = true;
                addNewVehicleToolStripMenuItem.Visible = true;
                removeDriverToolStripMenuItem.Visible = true;

            }
            else if (status == "User")
            {
                //addUserToolStripMenuItem.Enabled = false;
                //removeUserToolStripMenuItem.Enabled = false;
                //aToolStripMenuItem.Enabled = false;
                //removeDriverToolStripMenuItem.Enabled = false;
                addUserToolStripMenuItem.Visible = false;
                removeUserToolStripMenuItem.Visible = false;
                addNewVehicleToolStripMenuItem.Visible = false;
                removeDriverToolStripMenuItem.Visible = false;

            }
            else { }
        }
        //end check
        //
        //Form Load 
        //
        
        private void Main_Load(object sender, EventArgs e)
        {
            pictureBox1.Show();
            Cursor.Current = Cursors.WaitCursor;           
            adminCheck();
            MaximizeBox = false;
            MinimizeBox = true;
            exitToolStripMenuItem.Enabled = false;
            panelDriverInformation.Hide();
            panelAddNewDriver.Hide();
            AboutPanal.Hide();
            panelWebBrowser.Hide();
            webBrowser1.Hide();
            methodload();
            Cursor.Current = Cursors.Default;
            pictureBox1.Hide();
            //
            //Add Link in About section
            //
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "http://www.google.lk/";
            linkLabel1.Links.Add(link);
            //End Link

        }
        //define a method for forn load
        private void methodload()
        {
            /*string connectionString = "SERVER= localhost;" +
                  "DATABASE=syscall;" +
                  "UID= syscall;" +
                  "PASSWORD= syscall123;";*/
            string sql = "SELECT * FROM job_details";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlDataAdapter dataadapter = new MySqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "job");
            connection.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "job";
            dataGridView1.ReadOnly = true;
           
        }
        //End Form Load

        //
        //Main Form
        //
        private void search_Click(object sender, EventArgs e)
        {
            if (searchtextBox.Text != "")
            {
              /*  string connectionString = "SERVER= localhost;" +
                   "DATABASE=syscall;" +
                   "UID= syscall;" +
                   "PASSWORD= syscall123;";
                MySqlConnection conn = null;
                MySqlCommand cmd = null;
                MySqlDataReader reader = null;*/

                Cursor.Current = Cursors.WaitCursor;

                int idNo = int.Parse(searchtextBox.Text);
                try
                {

                    string sql = "SELECT Driver_id,Driver_Name,Vehicle_No,Destination,CurrentTime,CurrentDate,latitude,longitude FROM job_details,destination_coordinates WHERE Driver_id = '" + idNo + "'";
                    conn = new MySqlConnection(connectionString);
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {

                       
                       
                        driver_id.Text = reader.GetString("Driver_id");
                        driver_name.Text = reader.GetString("Driver_Name");
                        vehicle_number.Text=reader.GetString("Vehicle_No");
                        destination_txt.Text= reader.GetString("Destination");
                        jobTime.Text = reader.GetString("CurrentTime");
                        jobdate.Text = reader.GetDateTime("CurrentDate").ToString("yyyy-MM-dd");
                        searchtextBox.Text = "";

                        string SQL = "SELECT latitude,longitude FROM destination_coordinates WHERE townname = '" + destination_txt.Text + "' ";
                        conn = new MySqlConnection(connectionString);
                        cmd = new MySqlCommand(SQL,conn);
                        conn.Open();
                        
                        reader= cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            latti.Text = reader.GetString("latitude");
                            longi.Text = reader.GetString("longitude");
                        }
                        DataShowPannal.Hide();
                        panelAddNewDriver.Hide();
                        panelWebBrowser.Hide();
                        panelDriverInformation.Show();
                        AboutPanal.Hide();
                        Cursor.Current = Cursors.Default;   
                        
                    }
                    else
                    {
                        MessageBox.Show("Record could not found", "Error in Read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        searchtextBox.Text = "";
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
                MessageBox.Show("Please enter id number to search", "Error in Read", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Method for enter only numeric values to textbox
        //to enter only numeric values to search
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }
        //Log out button
        private void logout_Click(object sender, EventArgs e)
        {
            DataShowPannal.Show();
            this.Close();
            
        }
        //End main Form
        //
        //Search Results when press the search button (pannel2)
        //
        private void cancel_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            panelDriverInformation.Hide();
            DataShowPannal.Show();
            methodload();
            searchtextBox.Text = "";
            Cursor.Current = Cursors.Default; 
        }
        private void update_Click(object sender, EventArgs e)
        {
            Driver_Details_Update third = new Driver_Details_Update(driver_id.Text, driver_name.Text, vehicle_number.Text);
            third.ShowDialog();
            DataShowPannal.Hide();
            panelDriverInformation.Show();
            methodAfterUpdate();
        }
        private void delete_Click(object sender, EventArgs e)
        {
            deletemethod();
            searchtextBox.Text = "";

        }
        //delete driver
        private void deletemethod()
        {
            DialogResult result1 = MessageBox.Show("Are you really want to delete record?",
            "Important Question",
             MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {

                string connectionSQL = "server=localhost;user id=syscall;password=syscall123;database=syscall;";
                MySqlConnection conn = new MySqlConnection(connectionSQL);

                try
                {
                    MySqlCommand cmd = new MySqlCommand("DELETE FROM job_details WHERE Driver_id='" + driver_id.Text + "'", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Can't connect to database\n" + ex.ToString());
                }
                finally
                {
                    conn.Close();
                    MessageBox.Show("You successfully remove the driver", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panelDriverInformation.Hide();
                    DataShowPannal.Show();
                    methodload();
                }
            }
            else { }
        }
        //method for update
        private void methodAfterUpdate()
        {
            /*string connectionString = "SERVER= localhost;" +
                   "DATABASE=syscall;" +
                   "UID= syscall;" +
                   "PASSWORD= syscall123;";
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;*/

            try
            {
                string sql = "SELECT Driver_id,Driver_Name,Vehicle_No,Destination,CurrentTime,CurrentDate FROM job_details WHERE Driver_id = '" + driver_id.Text + "' ";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    driver_id.Text = reader.GetString("Driver_id");
                    driver_name.Text = reader.GetString("Driver_Name");
                    vehicle_number.Text = reader.GetString("Vehicle_No");
                    destination_txt.Text = reader.GetString("Destination");
                    jobTime.Text = reader.GetString("CurrentTime");
                    jobdate.Text = reader.GetDateTime("CurrentDate").ToString("yyyy-MM-dd");

                    string SQL = "SELECT latitude,longitude FROM destination_coordinates WHERE townname = '" + destination_txt.Text + "' ";
                       conn = new MySqlConnection(connectionString);
                       cmd = new MySqlCommand(SQL, conn);
                       conn.Open();

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            latti.Text = reader.GetString("latitude");
                            longi.Text = reader.GetString("longitude");
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
        //End of pannel2
        //
        //Add new Driver(pannel4)
        //
        private void back_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            panelDriverInformation.Hide();
            panelAddNewDriver.Hide();
            DataShowPannal.Show();
            AboutPanal.Hide();
            methodload();
            searchtextBox.Text = "";
            idtxt.Text = "";
            name.Text = "";
            Cursor.Current = Cursors.Default; 

        }
        //only enter numeric value for id
        private void idtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (idtxt.Text == "" || name.Text == "")
            {
                MessageBox.Show("Please enter Driver Id and Driver name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                Cursor.Current = Cursors.WaitCursor; 
                methodInsertNewDriver();
                idtxt.Text = "";
                nametxt.Text = "";
                vehicletxt.Text = "";
                comboBoxDestinationSelection.Text = "";
                LatitudeValue1.Text = "0.000000";
                LongitudeValue1.Text = "0.000000";
                panelAddNewDriver.Hide();
                panelDriverInformation.Hide();
                DataShowPannal.Show();
                AboutPanal.Hide();
                methodload();
                Cursor.Current = Cursors.Default; 
            }
        }
        //method for insert new driver
        public void methodInsertNewDriver()
        {
            DialogResult result1 = MessageBox.Show("Are you really want to Add new Driver?",
           "Important Question",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result1 == DialogResult.Yes)
            {
               /* string connectionString = "SERVER= localhost;" +
                   "DATABASE=syscall;" +
                   "UID= syscall;" +
                   "PASSWORD= syscall123;";
                MySqlConnection conn = null;
                MySqlCommand cmd = null;
                MySqlDataReader reader = null;*/

                try
                {
                    string sql = "INSERT INTO job_details  ( Driver_id,Driver_Name,Vehicle_No,Destination,CurrentTime,CurrentDate) VALUES ('" + idtxt.Text + "', '" + nametxt.Text + "','" + vehicletxt.Text + "', '" + comboBoxDestinationSelection.SelectedItem + "','" + time.Text + "','" + date.Text + "' )";
                    conn = new MySqlConnection(connectionString);
                    cmd = new MySqlCommand(sql, conn);
                    conn.Open();

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You successfully added New Driver\nDriver id: " + idtxt.Text + "\nDriver Name: " + nametxt.Text + "\nVehicle Number : "+vehicletxt.Text, "Done");
                    idtxt.Text = "";
                    nametxt.Text = "";
                    comboBoxDestinationSelection.Text = "";
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
                idtxt.Text = "";
                nametxt.Text = "";
                vehicletxt.Text = "";
                comboBoxDestinationSelection.Text = "";
                LatitudeValue1.Text = "";
                LongitudeValue1.Text = "";
            }
        }
        //End of panel4
        //
        //Add cordinates for new Driver
        //
        private void addLocation_Click(object sender, EventArgs e)
        {
            //panelWebBrowser.Show();
            //webBrowser1.Show();
            //webBrowser1.Navigate("http://localhost/slpa/setDestination.php");
            AddLocations_forEditDrivers webBrowser = new AddLocations_forEditDrivers();
            webBrowser.ShowDialog();
            //DataShowPannal.Hide();
            //panelDriverInformation.Hide();
            //panelAddNewDriver.Hide();
            //AboutPanal.Hide();
            comboBoxDestinationSelection.Items.Clear();
            //getLatitudeLongitude();
            

        }
        //
        //Menu Items Click events(Edit menu)
        //
        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            date.Text = DateTime.Now.ToString("yyyy-MM-dd");
            time.Text = DateTime.Now.ToString("HH:mm:ss");
            panelAddNewDriver.Show();
            DataShowPannal.Hide();
            panelDriverInformation.Hide();
            AboutPanal.Hide();
            panelWebBrowser.Hide();
            webBrowser1.Hide();
            comboBoxDestinationSelection.Items.Clear();
            //getLatitudeLongitude();
            Cursor.Current = Cursors.Default;
        }
        private void addNewVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the driver id or driver name and press search button to edit existing drivers",
              "Remove Drivers Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            searchtextBox.Focus();
        }

        private void removeDriverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the driver id or driver name and press search button to remove drivers",
           "Remove Drivers Informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
            searchtextBox.Focus();
        }
        //End of edit menu items		
        //
        //VTS menu item(log out)
        //
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataShowPannal.Show();
            this.Close();
        }
        //End of VTS menu items
        //
        //Windows menu items(show/hide time)
        //
        private void timeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timeToolStripMenuItem.Checked == true)
            {
                dateTimePicker1.Show();
            }
            else
            {
                dateTimePicker1.Hide();
            }
        }
        //End of Windows menu items 

        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_New_User five = new Add_New_User();
            five.ShowDialog();
        }

        private void editUserProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_User_Profile six = new Edit_User_Profile(status, username);
            six.ShowDialog();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Users eight = new Remove_Users(status);
            eight.ShowDialog();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataShowPannal.Hide();
            panelDriverInformation.Hide();
            panelAddNewDriver.Hide();
            AboutPanal.Show();
            Cursor.Current = Cursors.Default;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

        private void back_to_main_Click(object sender, EventArgs e)
        {
            AboutPanal.Hide();
            DataShowPannal.Show();
        }

        //get latitude and longitude
     /*   private void getLatitudeLongitude()
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
        

       
        //
        //Add new cordinates using web page
        //
        private void addNewCordinatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor; 
            panelWebBrowser.Show();
            webBrowser1.Show();
            webBrowser1.Navigate("http://localhost/slpa/setDestination.php");
            DataShowPannal.Hide();
            panelDriverInformation.Hide();
            panelAddNewDriver.Hide();           
            AboutPanal.Hide();
            Cursor.Current = Cursors.Default;
        }
        private void WebCloseBrowser_Click(object sender, EventArgs e)
        {
            panelWebBrowser.Hide();
            webBrowser1.Hide();
            DataShowPannal.Show();
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
          /*  string connectionString = "SERVER= localhost;" +
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
        //
        //combobox selection(load data acording value from combobox)
        //
        private void comboBoxDestinationSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string connectionString = "SERVER= localhost;" +
                    "DATABASE=syscall;" +
                    "UID= syscall;" +
                    "PASSWORD= syscall123;";
            MySqlConnection conn = null;
            MySqlCommand cmd = null;
            MySqlDataReader reader = null;*/
            try
            {
                string sql = "SELECT latitude,longitude FROM destination_coordinates  WHERE townname = '" + comboBoxDestinationSelection.SelectedItem + "'";
                conn = new MySqlConnection(connectionString);
                cmd = new MySqlCommand(sql, conn);
                conn.Open();

                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    LatitudeValue1.Text = reader.GetString("latitude");
                    LongitudeValue1.Text = reader.GetString("longitude");
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

        


        //End web browser
       
    }
}
