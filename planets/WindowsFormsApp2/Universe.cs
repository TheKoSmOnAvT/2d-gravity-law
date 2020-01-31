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
        const double G = 1;
        public double dT = 0.01;
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

        public void AddPlanet(double x, double y, float rad, double vx, double vy, float mas)
        {
            Planet_data.Add(new Planet(x, y, rad, vx, vy,mas));
            Length = Planet_data.Count;
        }
        public void move()
        {
            for (int i = 0; i < Length; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (i != j)
                    {
                        Planet_data[i].move(Planet_data[j].X, Planet_data[j].Y, (float)Planet_data[j].mas, G, dT);
                    }
                }

            }
        }
    }
}
