using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Planet
    {
        private double x;
        private double y;
        public float Rad;
        public float mas;
        public double vy;
        public double vx;

        public float distance;

        public float X
        {
            get {
                return (float)x;
            }
            set { this.x = value; }
        }

        public float Y
        {
            get
            {
                return (float)y;
            }
            set { this.y = value; }
        }


        public Planet(double x, double y)
        {
            this.x = x;
            this.y = y;
            this.Rad = 3;
            this.mas = 1000;
            this.vx = 0;
            this.vy = 0;
        }

        public Planet(double x, double y, float rad, double vx, double vy)
        {
            this.x = x;
            this.y = y;
            this.Rad = rad;
            this.mas = 1000;
            this.vx = vx;
            this.vy = vy;
        }

        public Planet(double x, double y, float rad, double vx, double vy,float mas)
        {
            this.x = x;
            this.y = y;
            this.Rad = rad;
            this.mas = mas/100;
            this.vx = vx;
            this.vy = vy;
        }

        
        public void move(float Xin, float Yin, float Mas, double G, double dT)
        {

            double dx_pow2 = Math.Pow(x - Xin, 2);
            double dy_pow2 = Math.Pow(y - Yin, 2);

            double r = Math.Sqrt(dx_pow2 + dy_pow2);
            distance = (float)r;
            r = Math.Pow(r, 3);

            double ax = G*Mas * (Xin - x) / r;
            double ay = G*Mas * (Yin - y) / r;

            vx = vx + ax * dT;
            vy = vy + ay * dT;

            x = x + vx * dT;
            y = y + vy * dT;

        }

        public void check_zone()
        {
            x = x > 1850 ? 0 : x;
            x = x < 0 ? 1850 : x;

            y = y > 950 ? 0 : y;
            y = y < 0 ?  950 : y;
        }
    }
}
