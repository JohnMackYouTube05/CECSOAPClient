using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CECSOAPClient.GenericUtilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CECSOAPClient
{
    public partial class LocationsViewer : Form
    {
        public LocationsViewer()
        {
            InitializeComponent();
        }
        SiteDTO[] locationList;

        private void LocationsViewer_Load(object sender, EventArgs e)
        {
            GenericUtilitiesSoapClient utilClient = new GenericUtilitiesSoapClient(); //Initialize Generic Utilities client.

            locationList = utilClient.GetSiteList(); //get the list of locations
            cbLocations.DataSource = locationList; //Populate the dropdown menu with them
            cbLocations.ValueMember = "SiteId"; //Filter by site ID
            cbLocations.DisplayMember = "SiteAddress"; //Display each location as its physical real-world address.
            cbLocations.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Enable auto-complete so searching is allowed.
            cbLocations.AutoCompleteSource = AutoCompleteSource.ListItems; 
        }

        private void cbLocations_SelectedValueChanged(object sender, EventArgs e)
        {
            SiteDTO location = cbLocations.SelectedItem as SiteDTO; //Grab location as a SiteDTO object.
            
            if (location != null) //Check to make sure it exists, to avoid errors.
            {
                //Populate all of the text box fields.
                tbSiteName.Text = location.SiteName.ToString();
                tbSiteCode.Text = location.SiteCode.ToString();
                tbSiteID.Text = location.SiteId.ToString();
                tbLastUpdated.Text = location.LastUpdateDate.ToString("MM/dd/yyyy hh:mm:ss tt");
                tbLastUploadTime.Text = location.LastUploadTime.ToString("MM/dd/yyyy hh:mm:ss tt");
                tbVersion.Text = location.Version.ToString();
                tbCreatedBy.Text = location.CreatedBy.ToString();
                tbCreationDate.Text = location.CreationDate.ToString("MM/dd/yyyy hh:mm:ss tt");

                lbStatus.Text = ""; //Clear status label

                //Run through status checker
                if (location.SiteName.ToLower().Contains("close"))
                {
                    RichTextBoxExtensions.AppendText(lbStatus, "PERMANENTLY CLOSED", Color.Red);
                }
                else if (location.SiteName.ToLower().Contains("not used") || location.SiteName.ToLower().Contains("notused"))
                {
                    RichTextBoxExtensions.AppendText(lbStatus, "NOT USED", Color.OrangeRed);
                    
                }
                else if (location.SiteName.ToLower().Contains("suites") || location.SiteName.ToLower().Contains("hotel"))
                {
                    RichTextBoxExtensions.AppendText(lbStatus, "SPECIAL", Color.Orange);
                    RichTextBoxExtensions.AppendText(lbStatus, " - ", Color.Black);
                    RichTextBoxExtensions.AppendText(lbStatus, "HOTEL", Color.Blue);
                }
                else if (location.SiteName.ToLower().Contains("arcade"))
                {
                    RichTextBoxExtensions.AppendText(lbStatus, "SPECIAL", Color.Orange);
                    RichTextBoxExtensions.AppendText(lbStatus, " - ", Color.Black);
                    RichTextBoxExtensions.AppendText(lbStatus, "ARCADE ONLY", Color.Purple);
                    
                }
                else
                {
                    RichTextBoxExtensions.AppendText(lbStatus, "OPEN", Color.Green);
                }
                if (location.SiteName.ToLower().Contains("ppp") || location.SiteAddress.Length < 2)
                {
                    RichTextBoxExtensions.AppendText(lbStatus, " [PPP/NO ADDRESS]", Color.Red);
                    
                }
                

            }
        }
    }
}
