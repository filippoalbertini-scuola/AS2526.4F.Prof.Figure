using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Cerchio : Figura
    {
        double raggio;

        public Cerchio(double raggio)
        {
            nome = "Cerchio";
            lati = 1;

            this.raggio = raggio;
        }

        public override double Area()
        {
            return Math.PI * raggio * raggio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * raggio;
        }
    }
}
