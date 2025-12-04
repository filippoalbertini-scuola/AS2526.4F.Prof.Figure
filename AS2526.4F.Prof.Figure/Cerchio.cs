using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Cerchio : Figura
    {
        double raggio;

        public double Raggio
        {
            get { return raggio; }
        }

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
        public override string Visualizzati()
        {
            return $"Il {nome} ha area {Math.Round(Area(), 2)} e circonferenza {Math.Round(Perimetro(), 2)} con raggio {raggio}";
        }
    }
}
