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
            Random rnd = new Random();

           // planet_system.AddPlanet(1900,1000,10,0,0,0);
            for (int i = 0; i < 10; i++)
            {
                int x = rnd.Next(10,1500) ;
                int y = rnd.Next(10, 1500);

                int vx = rnd.Next(-10, 10);
                int vy = rnd.Next(-10, 10);
                int rad = rnd.Next(1, 10);
                int mas = rnd.Next(10, 1000000);
                planet_system.AddPlanet(x,y,rad,vx,vy,mas);
            }
        }

        private void Space_Click(object sender, EventArgs e)
        {

        }

        private void Space_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0;i<planet_system.Length;i++)
            {
                e.Graphics.FillEllipse(Red, planet_system.Planet_data[i].X, planet_system.Planet_data[i].Y , planet_system.Planet_data[i].Rad*2, planet_system.Planet_data[i].Rad*2);
            }
            planet_system.move();
            Space.Invalidate();
        }
    }
}
