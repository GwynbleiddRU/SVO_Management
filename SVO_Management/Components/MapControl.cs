using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Device.Location;

namespace SVO_Management
{
    public partial class MapControl : UserControl
    {
        public Personnel curPersonnel;
        public GMap.NET.WindowsForms.GMapOverlay markers = new GMap.NET.WindowsForms.GMapOverlay("markers");

        public MapControl()
        {
            InitializeComponent();

        }

        private void PanelMap_Load(object sender, EventArgs e)
        {
            //добавление маркеров
            gMapControl1.Overlays.Add(markers);

            //Настройки для компонента GMap.
            gMapControl1.Bearing = 0;

            //CanDragMap - Если параметр установлен в True,
            //пользователь может перетаскивать карту
            ///с помощью правой кнопки мыши.
            gMapControl1.CanDragMap = true;

            //Указываем, что перетаскивание карты осуществляется
            //с использованием левой клавишей мыши.
            //По умолчанию - правая.
            gMapControl1.DragButton = MouseButtons.Left;

            gMapControl1.GrayScaleMode = true;

            //MarkersEnabled - Если параметр установлен в True,
            //любые маркеры, заданные вручную будет показаны.
            //Если нет, они не появятся.
            gMapControl1.MarkersEnabled = true;

            //Указываем значение максимального приближения.
            gMapControl1.MaxZoom = 16;

            //Указываем значение минимального приближения.
            gMapControl1.MinZoom = 14;

            //Устанавливаем центр приближения/удаления
            //курсор мыши.
            gMapControl1.MouseWheelZoomType =
            GMap.NET.MouseWheelZoomType.MousePositionAndCenter;

            //Отказываемся от негативного режима.
            gMapControl1.NegativeMode = false;

            //Разрешаем полигоны.
            gMapControl1.PolygonsEnabled = true;

            //Разрешаем маршруты
            gMapControl1.RoutesEnabled = true;

            //Скрываем внешнюю сетку карты
            //с заголовками.
            gMapControl1.ShowTileGridLines = false;

            //Указываем, что при загрузке карты будет использоваться
            //18ти кратное приближение.
            gMapControl1.Zoom = 14;

            //Указываем что все края элемента управления
            //закрепляются у краев содержащего его элемента
            //управления(главной формы), а их размеры изменяются
            //соответствующим образом.
            gMapControl1.Dock = DockStyle.Fill;

            //Указываем что будем использовать карты Bing.
            gMapControl1.MapProvider =
            GMap.NET.MapProviders.GMapProviders.BingMap;
            GMap.NET.GMaps.Instance.Mode =
            GMap.NET.AccessMode.ServerOnly;

            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMap.NET.MapProviders.GMapProvider.WebProxy =
            System.Net.WebRequest.GetSystemWebProxy();
            GMap.NET.MapProviders.GMapProvider.WebProxy.Credentials =
            System.Net.CredentialCache.DefaultCredentials;

            gMapControl1.Position = new GMap.NET.PointLatLng(55.974247, 37.4058723);
        }

        private void gMapControl1_MouseClick(object sender, MouseEventArgs e)
        {
            double lat = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lat;
            double lng = gMapControl1.FromLocalToLatLng(e.X, e.Y).Lng;

            if (e.Button == MouseButtons.Right)
            {
                OrderForm order = new OrderForm(lng, lat);
                if (order.ShowDialog() == DialogResult.Cancel)
                    return;
                else
                {
                    int requestedPersonnelAmount = 0; //по-хорошему при создании чп указать необходимое количество сотрудников
                    List<Personnel> competentPersonnel = new List<Personnel>();
                    List<Personnel> nearestPersonnel = new List<Personnel>();

                    foreach (var personnel in MainForm.staff)
                    {
                        if (personnel.Class.ToString() == order.personeTypeComboBox.SelectedItem.ToString())
                        {
                            competentPersonnel.Add(personnel);
                        }
                    }

                    //вдруг компетентнвых сотрудников меньше 5
                    if (competentPersonnel.Count > 5)
                        requestedPersonnelAmount = 5;
                    else
                        requestedPersonnelAmount = competentPersonnel.Count;

                    for (int i = 0; i < requestedPersonnelAmount; i++) //выбираем requestedPersonnelAmount ближайших сотрудников
                    {
                        Personnel minDistPersonnel = null;
                        double minDist = double.MaxValue;

                        foreach (var personnel in competentPersonnel) //проходим по каждому сотруднику - ищем ближайших
                        {
                            GMap.NET.WindowsForms.Markers.GMarkerGoogle coords;

                            coords = personnel.Coord;

                            GeoCoordinate personnelPosition = new GeoCoordinate(coords.Position.Lat, coords.Position.Lng);
                            GeoCoordinate orderPosition = new GeoCoordinate(lat, lng);

                            double minDistCurrent = orderPosition.GetDistanceTo(personnelPosition);
                            if (minDistCurrent < minDist)
                            {
                                minDist = minDistCurrent;
                                minDistPersonnel = personnel;
                            }
                        }
                        nearestPersonnel.Add(minDistPersonnel);
                        competentPersonnel.Remove(minDistPersonnel);
                    }

                    //test zone
                    StringBuilder sb = new StringBuilder();

                    foreach(var a in nearestPersonnel)
                    {
                        sb.Append(a.Name + "\n");
                    }

                    MessageBox.Show("Ближайшие компетентные сотрудники: \n\n" + sb.ToString() + "\n (отправляем им уведомления)");
                    //test zone

                    GMap.NET.WindowsForms.GMapMarker marker =
                    new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                        new GMap.NET.PointLatLng(lat, lng),
                        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.blue_pushpin);
                    markers.Markers.Add(marker);
                    marker.Tag = "warning";
                }
            }
        }

        public void gMapControl1_OnMarkerClick(GMap.NET.WindowsForms.GMapMarker item, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (item.Tag == null)
                {
                    Personnel p = (from x in MainForm.staff where x.Coord == item select x).First();
                    curPersonnel = p;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
