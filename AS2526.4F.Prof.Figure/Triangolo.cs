using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Triangolo : Figura
    {
        private double lato1;
        private double lato2;
        private double lato3;

        public Triangolo(double lato1, double lato2, double lato3)
        {
            nome = "Triangolo";
            lati = 3;
            this.lato1 = lato1;
            this.lato2 = lato2;
            this.lato3 = lato3;
        }

        public override double Area()
        {
            double s = Perimetro() / 2;
            return Math.Sqrt(s * (s - lato1) * (s - lato2) * (s - lato3));
        }

        public override double Perimetro()
        {
            return lato1 + lato2 + lato3;
        }
    }
}
