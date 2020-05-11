using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVO_Management
{
    public partial class OrderForm : Form
    {
        double Lng, Lat;

        public OrderForm(double lng, double lat)
        {
            Lng = lng;
            Lat = lat;
            Personnel.Type requestedType;

            InitializeComponent();
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


        private void OrderForm_Load(object sender, EventArgs e)
        {
            coordsLabel.Text = Lat + "° " + Lng + "°";
        }

        private void orderSendButton_Click(object sender, EventArgs e)
        {
            //отправляем уведомления сотрудникам

            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void OrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
