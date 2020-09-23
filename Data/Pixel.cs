using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {  
        public Pixel (double r, double g, double b)
        {
            this.r = this.g = this.b = 0;

            this.R = r;
            this.G = g;
            this.B = b;

        }
        public static double Trim (double val)
        {
            if (val < 0) return 0;
            if (val > 1) return 1;
            return val;
        }
        public double Check(double val)
        {
            if (val < 0 || val > 1)
            {
                Console.WriteLine("Исключение выброшено");
                throw new ArgumentException();
            }
            return val;
        }
        double r;
        public double R
        {
            get{return r;}
            set{r = Check(value);}
        }
        double g;
        public double G
        {
            get { return g; }
            set { g = Check(value); }
        }
        double b;
        public double B
        {
            get { return b; }
            set { b = Check(value); }
        }
        public static Pixel operator * (Pixel p, double c)
        {
            return new Pixel(
                Pixel.Trim(p.R * c),
                Pixel.Trim(p.G * c),
                Pixel.Trim(p.B * c));

        }
    }
}
