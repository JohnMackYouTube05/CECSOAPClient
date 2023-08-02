using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CECSOAPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GameMachineServices.GameMachineServicesSoapClient gmss = new GameMachineServices.GameMachineServicesSoapClient();
            
        }

        private void btnLocationsMenu_Click(object sender, EventArgs e)
        {
            LocationsViewer locationsViewer = new LocationsViewer();
            locationsViewer.Show();
        }
        //ProgressDialog progressDialog;
        private void btnMachinesMenu_Click(object sender, EventArgs e)
        {
            MachinesViewer machinesViewer = new MachinesViewer();
           
            machinesViewer.Shown += MachinesViewer_Shown;
            machinesViewer.Show();
        }

        private void MachinesViewer_Shown(object sender, EventArgs e)
        {
            //progressDialog.Close();
        }
    }
}
