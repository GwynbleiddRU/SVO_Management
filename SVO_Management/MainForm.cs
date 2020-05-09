using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Devices.Bluetooth.Advertisement;
using Windows.Storage.Streams;

namespace SVO_Management
{
    public partial class MainForm : Form
    {
        //BluetoothLEAdvertisementWatcher watcher = new BluetoothLEAdvertisementWatcher();         

        //static ThreadStart tStart;
        //Thread thread => new Thread(watcher.Start());


        public MainForm()
        {
            AuthorizationForm Authorization = new AuthorizationForm();
            Authorization.ShowDialog();

            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            InitializeComponent();

            //tStart = new ThreadStart(watcher.Start());
            //watcher.Received += BeaconData.Watcher_Received;
        }

        #region PanelHeader
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.TopMost = false;
                this.WindowState = FormWindowState.Maximized;
                Elipse.ElipseRadius = 0;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                Elipse.ElipseRadius = 5;
            }
        }

        #endregion PanelHeader

        #region Menu
        private void menuButton_Click(object sender, EventArgs e)
        {
            if (panelMenu.Width == 70)
            {
                panelMenu.Visible = false;
                panelMenu.Width = 350;
                menuAnimator.ShowSync(panelMenu);
            }
            else
            {
                panelMenu.Visible = false;
                panelMenu.Width = 70;
                menuAnimator.ShowSync(panelMenu);
            }
        }
        #endregion Menu

        private void MainForm_Load(object sender, EventArgs e)
        {
            GeoCoordinate coord = new GeoCoordinate();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            BluetoothForm bluetooth = new BluetoothForm();
            bluetooth.Show();
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            OrderForm order = new OrderForm();
            order.Show();
        }
    }
}
