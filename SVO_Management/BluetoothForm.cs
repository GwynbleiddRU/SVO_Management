using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;

namespace SVO_Management
{
    public partial class BluetoothForm : Form
    {
        BluetoothLEAdvertisementWatcher watcher = new BluetoothLEAdvertisementWatcher();
        Timer timer = new Timer { Interval = 1000 };


        public BluetoothForm()
        {
            InitializeComponent();
            watcher.Received += BeaconData.Watcher_Received;
        }

        #region PanelHeader
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion PanelHeader

        private void startButton_Click(object sender, EventArgs e)
        {
            watcher.Start();

            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer.Stop();
            watcher.Stop();
        }

        private void WatcherOnReceived(BluetoothLEAdvertisementWatcher sender, BluetoothLEAdvertisementReceivedEventArgs btAdv)
        {
            MessageBox.Show(btAdv.BluetoothAddress.ToString() + " " + btAdv.Advertisement.ManufacturerData.ToString() + " " + btAdv.Advertisement.LocalName.ToString());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            deviceList.Items.Add("Searching...");

            //var watcher = new BluetoothLEAdvertisementWatcher();
            watcher.Received += WatcherOnReceived;
            //Task.Delay(500);
        }
    }
}
