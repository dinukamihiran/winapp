using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SLPA
{
    public partial class AddLocations_forEditDrivers : Form
    {
        public AddLocations_forEditDrivers()
        {
            InitializeComponent();
        }

        private void AddLocations_forEditDrivers_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            webBrowser1.Navigate("http://localhost/slpa/setDestination.php");
            
        }
    }
}
