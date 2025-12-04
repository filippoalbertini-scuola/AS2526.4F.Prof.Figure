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

            // definisci e istanzia la lista di Figura con assegnazione statica
            List<Figura> lstFigure = new List<Figura>() 
                { q,r,c,t};

            // e aggiunge Rombo
            lstFigure.Add(rombo);

            foreach (Figura figura in lstFigure)
            {
                Console.WriteLine($" Dettagli : {figura.Visualizzati()}");

                // dati aggiuntivi
                // con switch
                switch (figura.Nome.ToUpper())
                {
                    case "QUADRATO":
                        // cast esplito sulla variabile quadrato
                        Quadrato quadrato = (Quadrato)figura;

                        Console.WriteLine($" \tLato : {quadrato.Lato}");
                        break;

                    case "CERCHIO":
                        // cast esplito sulla variabile quadrato
                        Cerchio cerchio = (Cerchio)figura;

                        Console.WriteLine($" \tRaggio : {cerchio.Raggio}");
                        break;

                }

                // con if multiplo
                if (figura is Quadrato)
                {
                    // cast esplito sulla variabile quadrato
                    Quadrato quadrato = (Quadrato)figura;

                    Console.WriteLine($" \tLato : {quadrato.Lato}");

                } else if (figura is Cerchio)
                {
                    // cast esplito sulla variabile quadrato
                    Cerchio cerchio = (Cerchio)figura;

                    Console.WriteLine($" \tRaggio : {cerchio.Raggio}");
                }

            }

        }
    }
}
