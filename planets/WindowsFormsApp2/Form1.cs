using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Universe planet_system = new Universe();
        public SolidBrush yel = new SolidBrush(Color.Yellow);
        public SolidBrush Red = new SolidBrush(Color.Red);
        public Form1()
        {
            InitializeComponent();
            planet_system.AddPlanet(250,300,5,2,2);
        }

        private void Space_Click(object sender, EventArgs e)
        {

        }

        private void Space_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(yel, 400,400,25,25 );
            e.Graphics.FillEllipse(yel, 400, 300, 25, 25);

            for (int i = 0;i<planet_system.Length;i++)
            {
                e.Graphics.FillEllipse(Red, planet_system.Planet_data[i].X, planet_system.Planet_data[i].Y , planet_system.Planet_data[i].Rad*2, planet_system.Planet_data[i].Rad*2);
            }
            planet_system.move();
            Space.Invalidate();
        }
    }
}
