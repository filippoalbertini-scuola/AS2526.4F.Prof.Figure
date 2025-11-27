using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public class Figura
    {
        protected int lati;
        protected string nome;

        public Figura()
        {
            lati = 0;
            nome = "Figura generica";
        }

        public virtual double Area() { return 0; }
        public virtual double Perimetro() { return 0; }
        public string Visualizzati()
        {
            return $"Il {nome} ha area {Math.Round(Area(),2)} e perimetro {Math.Round(Perimetro(),2)}";
        }
    }
}
