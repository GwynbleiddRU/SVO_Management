using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Device.Location;
using System.Drawing;
using System.IO;
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
        public static List<Personnel> staff = new List<Personnel>();

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
            SetPersonal();

            personnelScreen.mapControl1.gMapControl1.OnMarkerClick += UpdatePersonnelInfo;
        }

        public void UpdatePersonnelInfo(object sender, EventArgs e)
        {
            Personnel p = personnelScreen.mapControl1.curPersonnel;
            personnelScreen.personnelNameLabel.Text = "Name: " + p.Name;
            personnelScreen.personnelTypeLabel.Text = "Class: " + p.Class.ToString();
            personnelScreen.personnelXCordLabel.Text = "Latitude: " + p.Coord.Position.Lat.ToString();
            personnelScreen.personnelYCordLabel.Text = "Longitude: " + p.Coord.Position.Lng.ToString();
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

        private void menuSchemeButton_Click(object sender, EventArgs e)
        {
            personnelScreen.Visible = true;
        }

        private void menuPersonnelButton_Click(object sender, EventArgs e)
        {
            personnelScreen.Visible = false;
        }

        private void menuSettingsButton_Click(object sender, EventArgs e)
        {
            personnelScreen.Visible = false;
        }

        private void menuLogOutButton_Click(object sender, EventArgs e)
        {
            personnelScreen.Visible = false;
        }

        static void Refresh()
        {

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

        public void SetPersonal()
        {
            string[] s = File.ReadAllLines(Environment.CurrentDirectory + "\\testCoords.txt");
            int next = 1;
            foreach (string a in s)
            {
                Bitmap bm = null;
                double x = double.Parse(a.Split(' ')[0].Trim(','));
                double y = double.Parse(a.Split(' ')[1]);
                Personnel psn = null;
                GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = null;
                switch (next)
                {
                    case 1:
                        bm = new Bitmap(Properties.Resources.personnelEngineerIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel("Сидоров Г.О.", Personnel.Type.Engineer, marker);
                        marker.ToolTipText = psn.Name;
                        next++;
                        break;
                    case 2:
                        bm = new Bitmap(Properties.Resources.personnelAssistantIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel("Иванов Г.О.", Personnel.Type.Assistant, marker);
                        marker.ToolTipText = psn.Name; ;
                        next++;
                        break;
                    case 3:
                        bm = new Bitmap(Properties.Resources.personnelCarrierIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel("Глебов Г.О.", Personnel.Type.Carrier, marker);
                        marker.ToolTipText = psn.Name;
                        next++;
                        break;
                    case 4:
                        bm = new Bitmap(Properties.Resources.personnelPoliceIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel("Носачев Г.О.", Personnel.Type.Police, marker);
                        marker.ToolTipText = psn.Name;

                        next = 1;
                        break;
                }
                staff.Add(psn);


                personnelScreen.mapControl1.markers.Markers.Add(marker);
            }

        }
    }
}
