using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Universe
    {
        public List<Planet> Planet_data = new List<Planet>();
        public int Length = 0;

        public Universe()
        {
            
        }
        public void AddPlanet(double x, double y)
        {
            Planet_data.Add(new Planet(x,y));
            Length = Planet_data.Count;
        }
        public void AddPlanet(double x, double y, float rad, double vx, double vy)
        {
            Planet_data.Add(new Planet(x, y,rad,vx,vy));
            Length = Planet_data.Count;
        }
        public void move()
        {
            for (int i =0;i< Length;i++)
            {
                Planet_data[i].move();

            }
        }
    }
}
