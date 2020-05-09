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
        public PanelPersonnel()
        {
            InitializeComponent();
        }

        private void PanelPersonnel_Load(object sender, EventArgs e)
        {
            Personnel person = new Personnel("Афанасьев Е.В.", Personnel.Type.Carrier, null);
            MainForm.staff.Add(person);
            Personnel person2 = new Personnel("Кошкин У.Г.", Personnel.Type.Engineer, null);
            MainForm.staff.Add(person2);

            personnelList.Items.Clear();
            personnelList.SmallImageList = personnelIcons;

            string imageKey = "";

            foreach (var personnel in MainForm.staff)
            {
                string name = personnel.Name;
                var type = personnel.Class;
                int id = personnel.ID;

                if (type == Personnel.Type.Engineer)
                    imageKey = "staffEngineerIcon.png";
                else if (type == Personnel.Type.Carrier)
                    imageKey = "staffLuggageIcon.png";

                personnelList.Items.Add(id.ToString(), name, imageKey);
            }
        }
    }
}
