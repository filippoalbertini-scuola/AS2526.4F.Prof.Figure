using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Rombo : Figura
    {
        private double d1;
        private double d2;

        public Rombo(double d1, double d2)
        {
            nome = "Rombo";
            lati = 4;
            this.d1 = d1;
            this.d2 = d2;
        }

        public override double Area()
        {
            return (d1 * d2) / 2;
        }

        public override double Perimetro()
        {
            double lato = Math.Sqrt(Math.Pow(d1 / 2, 2) + Math.Pow(d2 / 2, 2));
            return lato * 4;
        }
    }
}
