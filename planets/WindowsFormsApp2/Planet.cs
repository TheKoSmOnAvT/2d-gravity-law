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
        private double vy;
        private double vx;

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
            this.vx = 0;
            this.vy = 0;
        }

        public Planet(double x, double y, float rad, double vx, double vy)
        {
            this.x = x;
            this.y = y;
            this.Rad = rad;
            this.vx = vx;
            this.vy = vy;
        }
        public void move()
        {

            double dx_pow2 = Math.Pow(x - 400, 2);
            double dy_pow2 = Math.Pow(y - 400, 2);

            double r = Math.Sqrt(dx_pow2 + dy_pow2);
            r = Math.Pow(r,3);

            double ax = 3000 * (400 - x) / r;
            double ay = 3000 * (400 - y) / r;

            vx = vx + ax * 0.1;
            vy = vy + ay * 0.1;

            x = x + vx * 0.1;
            y = y + vy * 0.1;

            double dx_pow21 = Math.Pow(x - 400, 2);
            double dy_pow21 = Math.Pow(y - 300, 2);
            r = Math.Sqrt(dx_pow21 + dy_pow21);
            r = Math.Pow(r, 3);
            ax = 3000 * (400 - x) / r;
            ay = 3000 * (300 - y) / r;

            vx = vx + ax * 0.1;
            vy = vy + ay * 0.1;

            x = x + vx * 0.1;
            y = y + vy * 0.1;
  
        }
    }
}
