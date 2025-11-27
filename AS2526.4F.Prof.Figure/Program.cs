namespace AS2526._4F.Prof.Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;AS 25/26 4G;27/11/25; Gestione figure geometriche");

            Quadrato q = new Quadrato(4);
            Rettangolo r = new Rettangolo(4, 2);
            //Cerchio c = new Cerchio(4);

            Console.WriteLine($"Figura:  {q.Visualizzati()}");
            Console.WriteLine($"Figura:  {r.Visualizzati()}");
            //Console.WriteLine($"Il cerchio ha area {c.Area()} e perimetro {c.Perimetro()}");

        }
    }
}
