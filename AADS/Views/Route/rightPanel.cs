using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace AADS.Views.Route
{
    public partial class rightPanel : UserControl
    {
        public string colorCheck;
        public string test;
        public List<string> points = new List<string>();
        private static int counter;
        private int x = 8, y = 0;
        public bool resetCheck = false;
        public List<GMarkerGoogle> arr = new List<GMarkerGoogle>();
        public rightPanel()
        {
            InitializeComponent();
            if (rdbLineRouteL.Checked)
            {
                this.colorCheck = "Brown";
            }
        }

        private void rdbLineRoute_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbLineRouteAir.Checked)
            {
                this.colorCheck = "Red";
            }
            else if (rdbLineRouteL.Checked)
            {
                this.colorCheck = "Brown";
            }
            else
            {
                this.colorCheck = "Deepblue";
            }

        }
        public void setListBox()
        {
            panel1.Controls.Add(new Label { Name = "Point" + counter.ToString() , Location = new Point(x, y), AutoSize = true, Text = "Point " + counter.ToString() + " :" });
            panel1.Controls.Add(new Label { Name = "Point" + counter.ToString(), Location = new Point(x+95, y), AutoSize = true, Text = points[counter] });
            y += 25;
            counter++;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
        }
        public void reset(bool check)
        {
            if (check)
            {
                points.Clear();
                panel1.Controls.Clear();
                counter = 0;
                y = 0;
            }
        }
    }
}
