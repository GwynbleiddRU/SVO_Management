using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SVO_Management
{
    public partial class PanelPersonnel : UserControl
    {
        public Personnel curPersonnel;

        public PanelPersonnel()
        {
            InitializeComponent();
        }

        private void PanelPersonnel_Load(object sender, EventArgs e)
        {
            personnelList.Items.Clear();
            personnelList.SmallImageList = personnelIcons;

            string imageKey = "";

            foreach (var personnel in MainForm.staff)
            {
                string name = personnel.Name;
                var type = personnel.Class;
                int id = personnel.ID;

                if (type == Personnel.Type.Engineer)
                    imageKey = "personnelEngineerIcon.png";
                else if (type == Personnel.Type.Carrier)
                    imageKey = "personnelCarrierIcon.png";
                else if (type == Personnel.Type.Assistant)
                    imageKey = "personnelAssistantIcon.png";
                else if (type == Personnel.Type.Police)
                    imageKey = "personnelPoliceIcon.png";

                personnelList.Items.Add(id.ToString(), name, imageKey);
            }
        }

        private void personnelList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (personnelList.FocusedItem.Bounds.Contains(e.Location))
                {
                    int id = Convert.ToInt32(personnelList.FocusedItem.Name);
                    curPersonnel = MainForm.staff.Where(x => x.ID == id).First();
                }
                else
                    return;
            }
        }
    }
}
