using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCords
{
    public class Coord
    {
        public Double latitud { get; set; }
        public Double longitud { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            bool toContinue = true;

            Console.WriteLine("Hola, ingresa coordenadas (latitud, longitud) o x para salir:");
            Console.WriteLine("Ejemplo: 12.3444,14.2333");
            List<Coord> coordenadas = new List<Coord>();
            while (toContinue)
            {
                String input = Console.ReadLine();
                if (input.ToLower().Equals("x"))
                {
                    toContinue = false;
                    continue;
                }
                if (input.Split(',').Length != 2)
                {
                    continue;
                }
                // todo lo que es correcto
                Double latitud;
                Double longitud;
                Coord mycoord = new Coord()
                {
                    latitud = Double.TryParse(input.Split(',')[0], out latitud) ? latitud:0,
                    longitud = Double.TryParse(input.Split(',')[1], out longitud) ? longitud : 0,
                };

                coordenadas.Add(mycoord);
            }

            Console.WriteLine("Vuelve pronto... tu has ingresado: {0} coordenadas", coordenadas.Count);
            Console.ReadKey();
        }
    }
}
