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

        public MainForm()
        {
            AuthorizationForm Authorization = new AuthorizationForm();
            Authorization.ShowDialog();

            MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
            InitializeComponent();

            //tStart = new ThreadStart(watcher.Start());
            //watcher.Received += BeaconData.Watcher_Received;
            SetPersonal();

            personnelScreen.mapControl1.gMapControl1.OnMarkerClick += UpdatePersonnelInfoMarker;
            personnelScreen.personnelList.MouseClick += UpdatePersonnelInfoListView;
        }

        #region PanelPersonnel
        public void SetPersonal()
        {
            string[] serverData = File.ReadAllLines(Environment.CurrentDirectory + "\\testCoords.txt");
            foreach (string dataRow in serverData)
            {
                Bitmap bm = null;
                Personnel psn = null;
                GMap.NET.WindowsForms.Markers.GMarkerGoogle marker = null;

                int id = int.Parse(dataRow.Split(' ')[0]);
                //string name = dataRow.Split('"')[0];

                string name = dataRow.Remove(0, dataRow.IndexOf('"') + 1);
                name = name.Remove(name.LastIndexOf('"'));


                double x = double.Parse(dataRow.Split(' ')[1].Trim(','));
                double y = double.Parse(dataRow.Split(' ')[2]);

                //Personnel.Type type;

                switch (dataRow.Split(' ')[3])
                {
                    case "Engineer":
                        //type = Personnel.Type.Engineer;

                        bm = new Bitmap(Properties.Resources.personnelEngineerIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel(id, name, Personnel.Type.Engineer, marker);
                        marker.ToolTipText = psn.Name;
                        break;
                    case "Assistant":
                        //type = Personnel.Type.Assistant;

                        bm = new Bitmap(Properties.Resources.personnelAssistantIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel(id, name, Personnel.Type.Assistant, marker);
                        marker.ToolTipText = psn.Name;
                        break;
                    case "Carrier":
                        //type = Personnel.Type.Carrier;

                        bm = new Bitmap(Properties.Resources.personnelCarrierIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel(id, name, Personnel.Type.Carrier, marker);
                        marker.ToolTipText = psn.Name;
                        break;
                    case "Police":
                        //type = Personnel.Type.Police;

                        bm = new Bitmap(Properties.Resources.personnelPoliceIcon, new Size(35, 35));
                        marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(new GMap.NET.PointLatLng(x, y), bm);
                        marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                        psn = new Personnel(id, name, Personnel.Type.Police, marker);
                        marker.ToolTipText = psn.Name;
                        break;
                }

                staff.Add(psn);
                personnelScreen.mapControl1.markers.Markers.Add(marker);
            }
        }

        public void UpdatePersonnelInfoMarker(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            if (item.Tag == null)
            {
                Personnel p = personnelScreen.mapControl1.curPersonnel;
                personnelScreen.personnelNameLabel.Text = "Name: " + p.Name;
                personnelScreen.personnelTypeLabel.Text = "Class: " + p.Class.ToString();
                personnelScreen.personnelXCordLabel.Text = "Latitude: " + p.Coord.Position.Lat.ToString();
                personnelScreen.personnelYCordLabel.Text = "Longitude: " + p.Coord.Position.Lng.ToString();

                personnelScreen.locationTitleLabel.Text = "Локация: ";
                personnelScreen.personnelAreaLabel.Text = Territory.Check(p.Coord.Position.Lat, p.Coord.Position.Lng);
            }
        }

        public void UpdatePersonnelInfoListView(object sender, EventArgs e)
        {
            Personnel p = personnelScreen.curPersonnel;
            personnelScreen.personnelNameLabel.Text = "Name: " + p.Name;
            personnelScreen.personnelTypeLabel.Text = "Class: " + p.Class.ToString();
            personnelScreen.personnelXCordLabel.Text = "Latitude: " + p.Coord.Position.Lat.ToString();
            personnelScreen.personnelYCordLabel.Text = "Longitude: " + p.Coord.Position.Lng.ToString();

            personnelScreen.locationTitleLabel.Text = "Локация: ";
            personnelScreen.personnelAreaLabel.Text = Territory.Check(p.Coord.Position.Lat, p.Coord.Position.Lng);
        }
        #endregion PanelPersonnel

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
            Refresh(personnelScreen);
        }

        private void menuPersonnelButton_Click(object sender, EventArgs e)
        {
            Refresh(personnelBrowseScreen);
        }

        private void menuSettingsButton_Click(object sender, EventArgs e)
        {

        }

        private void menuLogOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit(); //пока нет авторизации...
        }

        void Refresh(Control curPanel)
        {
            personnelScreen.Visible = false;
            personnelBrowseScreen.Visible = false;

            curPanel.Visible = true;
        }

        #endregion Menu

        private void MainForm_Load(object sender, EventArgs e)
        {
            GeoCoordinate coord = new GeoCoordinate();
        }
    }
}
