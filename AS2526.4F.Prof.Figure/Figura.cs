using System;
using System.Collections.Generic;
using System.Text;

namespace AS2526._4F.Prof.Figure
{
    public abstract class Figura
    {
        protected int lati;
        protected string nome;

        public string Nome
        {
            get { return nome; }
        }

        public Figura()
        {
            lati = 0;
            nome = "Figura generica";
        }

        public abstract double Area();
        public abstract double Perimetro();
        public virtual string Visualizzati()
        {
            return $"Il {nome} ha area {Math.Round(Area(),2)} e perimetro {Math.Round(Perimetro(),2)}";
        }
    }
}
