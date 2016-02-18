using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpervlakteCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string BreedteString = "";
            string LengteString = "";

            int Breedte = 0;
            int Lengte = 0;
            int Resultaat = 0;
                
            Console.WriteLine("Geef de breedte.");
            BreedteString = Console.ReadLine();

            Console.WriteLine("Geef de lengte.");
            LengteString = Console.ReadLine();

            Breedte = int.Parse(BreedteString);
            Lengte = int.Parse(LengteString);

            Resultaat = Lengte * Breedte;

            Console.WriteLine("Het resultaat is: ");
            Console.WriteLine(Resultaat);

            Console.ReadLine();

            
            
        }
    }
}
