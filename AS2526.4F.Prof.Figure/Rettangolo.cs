using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Rettangolo : Figura
    {
        private double b;
        private double altezza;
        public Rettangolo(double b, double altezza)
        {
            nome = "Rettangolo";
            lati = 4;

            this.b = b;
            this.altezza = altezza;
        }

        public override double Area()
        {
            return b * altezza;
        }

        public override double Perimetro()
        {
            return 2 * b + 2 * altezza;
        }
    }
}
