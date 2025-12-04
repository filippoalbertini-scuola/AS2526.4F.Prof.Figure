using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Quadrato : Figura
    {
        private int lato;
        public int Lato
        {
            get { return lato; }
        }

        public Quadrato(int lato) 
        {
            nome = "Quadrato";
            lati = 4;

            this.lato = lato;
        }

        public override double Area()
        {
            return lato * lato;
        }

        public override double Perimetro()
        {
            return 4 * lato;
        }

        public override string Visualizzati()
        {
            return $"{base.Visualizzati()} con lato {lato}";
        }


    }
}
