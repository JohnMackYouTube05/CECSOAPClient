using CECSOAPClient.GameMachineServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Runtime.Caching;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace CECSOAPClient
{
    public partial class MachinesViewer : Form
    {
        private static readonly ObjectCache Cache = MemoryCache.Default;
        public MachinesViewer()
        {
            InitializeComponent();
        }
        ProgressDialog progressDialog;
        MachineStruct[] machineList;

        SQLiteConnection connection = new SQLiteConnection("Data Source=" + Path.Combine(Directory.GetCurrentDirectory(), "Data\\CECGameImages.db"));
        private async void MachinesViewer_Load(object sender, EventArgs e)
        {
            GameMachineServicesSoapClient machineClient = new GameMachineServicesSoapClient(); //Initialize Game Machine Services client.
            connection.Open();

            var progress = new Progress<int>(value => progressDialog.updateProgressValue(value));

            

            var machineProc = machineClient.GetMachineListAsync();

            progressDialog = new ProgressDialog("Please wait while the list of machines is downloaded...", "Downloading Machine List");
            progressDialog.Show();

            machineProc = DownloadMachineListAsync("machinelist", machineClient.GetMachineListAsync, TimeSpan.FromHours(2));
            while (!machineProc.IsCompleted)
            {
                Application.DoEvents();
                await Task.Delay(10);
            }
            machineList = machineProc.Result;
            cbMachines.DataSource = machineList; //Populate the dropdown menu with them
            cbMachines.ValueMember = "MachineId"; //Filter by Machine ID
            cbMachines.DisplayMember = "MachineName"; //Display each machine as its name.
            cbMachines.AutoCompleteMode = AutoCompleteMode.SuggestAppend; //Enable auto-complete so searching is allowed.
            cbMachines.AutoCompleteSource = AutoCompleteSource.ListItems;
            progressDialog.Close();
            //await Task.Run(() => machineClient.GetMachineListAsync(progress));
            //await Task.Factory.StartNew(async () => {
            //    var machineProc = await machineClient.GetMachineListAsync();

            //}).ContinueWith(result => {

            //}, TaskScheduler.FromCurrentSynchronizationContext()
            //});
        }


        public static async Task<MachineStruct[]> DownloadMachineListAsync(string cacheKey, Func<Task<MachineStruct[]>> dataRetrievalFunc, TimeSpan cacheExpiration)
        {
            if (Cache.Contains(cacheKey))
            {
                return (MachineStruct[])Cache.Get(cacheKey);
            }

            var data = await dataRetrievalFunc.Invoke();
            if (data != null)
            {
                var cacheItemPolicy = new CacheItemPolicy
                {
                    AbsoluteExpiration = DateTimeOffset.Now.Add(cacheExpiration)
                };
                Cache.Add(cacheKey, data, cacheItemPolicy);
            }

            return data;
        }

        private void MachinesViewer_Shown(object sender, EventArgs e)
        {
            //progressDialog.Close();
        }

        private void KVtoStatusLabel(Label label, string value)
        {
            if (value == "Y")
            {
                label.Text = "YES";
                label.ForeColor = Color.Green;
            } else
            {
                label.Text = "NO";
                label.ForeColor = Color.Red;
            }
                
        }
        public Image ByteToImage(byte[] imageBytes)
        {
            // Convert byte[] to Image
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            Image image = new Bitmap(ms);
            return image;
        }

        private Image GetMachineImage(string machineName)
        {
            
            using (var command = new SQLiteCommand(connection))
            {
                //Construct the SQL query command.
                command.CommandText = "SELECT Image FROM GameImages WHERE GameName LIKE '%' || @keyword || '%'";
                command.Parameters.AddWithValue("@keyword", machineName);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader[0].GetType() != typeof(DBNull))
                        {
                            byte[] array = (System.Byte[])reader[0];
                            return ByteToImage(array);
                        } else
                        {
                            return CECSOAPClient.Properties.Resources.NoPhoto;
                        }
                        
                    }
                }
                return CECSOAPClient.Properties.Resources.NoPhoto;
            }
        }
        private void cbMachines_SelectedValueChanged(object sender, EventArgs e) //Display Machine Listing
        {
            GameMachineServicesSoapClient machineClient = new GameMachineServicesSoapClient();
            MachineStruct machine = cbMachines.SelectedItem as MachineStruct;
            KeyValueStruct[] machineDetails = machineClient.GetGameDetails("", machine.MachineId);
            tbMachineID.Text = machine.MachineId;
            foreach(KeyValueStruct detail in machineDetails)
            {
                switch (detail.Key)
                {
                    case "GamesAllowed":
                        KVtoStatusLabel(lbGamesAllowed, detail.Value); 
                        break;
                    case "CreditsAllowed":
                        KVtoStatusLabel(lbCreditsAllowed, detail.Value);
                        break;
                    case "CCPlusAllowed":
                        KVtoStatusLabel(lbCCPlusAllowed, detail.Value);
                        break;
                    case "BonusAllowed":
                        KVtoStatusLabel(lbBonusAllowed, detail.Value);
                        break;
                    case "CourtesyAllowed":
                        KVtoStatusLabel(lbCourtesyAllowed, detail.Value);
                        break;
                    case "CreditsBeforeBonus":
                        KVtoStatusLabel(lbCreditsBeforeBonus, detail.Value);
                        break;
                    case "GamePrice":
                        double price = Double.Parse(detail.Value);
                        if (price > 1 || price < 1)
                        {
                            tbPrice.Text = price.ToString("0.0") + " PlayPoints";
                        } else if (price == 1)
                        {
                            tbPrice.Text = price.ToString("0.0") + " PlayPoint";
                        }
                        break;
                    case "GameVIPPrice":
                        double vipPrice = Double.Parse(detail.Value);
                        if (vipPrice > 1 || vipPrice < 1)
                        {
                            tbVIPPrice.Text = vipPrice.ToString("0.0") + " PlayPoints";
                        }
                        else if (vipPrice == 1)
                        {
                            tbVIPPrice.Text = vipPrice.ToString("0.0") + " PlayPoint";
                        }
                        break;
                    case "GameId":
                        tbGameID.Text = detail.Value;
                        break;
                    case "GameProfileId":
                        tbGameProfileID.Text = detail.Value;
                        break;
                }
            }
            pbMachinePreview.Image = GetMachineImage(machine.MachineName);
            
            
            
        }
    }
}
