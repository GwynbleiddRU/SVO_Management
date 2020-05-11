using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVO_Management.Components
{
    public partial class PanelPersonnelBrowse : UserControl
    {
        public PanelPersonnelBrowse()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            BluetoothForm bluetooth = new BluetoothForm();
            bluetooth.Show();
        }
    }
}
