namespace AS2526._4F.Prof.Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;AS 25/26 4G;27/11/25; Gestione figure geometriche con collezioni");

            Quadrato q = new Quadrato(4);
            Rettangolo r = new Rettangolo(4, 2);
            Cerchio c = new Cerchio(4);

            Triangolo t = new Triangolo(3, 4, 5);
            Rombo rombo = new Rombo(10, 8);

            // inizializzazione dinamica

            // definisci e istanzia la lista di Figura
            List<Figura> lstFigure = new List<Figura>();

            // Inserisci gli elementi nella lista
            lstFigure.Add(q);
            lstFigure.Add(r);
            lstFigure.Add(c);
            lstFigure.Add(t);
            lstFigure.Add(rombo);


            foreach (Figura figura in lstFigure)
            {
                Console.WriteLine($" Dettagli : {figura.Visualizzati()}");
            }

        }
    }
}
