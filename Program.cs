using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _241025_Szemazonosito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string szemazon = "";
            string szemazon2 = "";
            Console.WriteLine( "Adja meg a személyazonosító jelének első 10 jegyét: " );
            szemazon = Console.ReadLine();
            
            Console.WriteLine();
            
            if (szemazon[0] % 2 == 0) Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme nő.");
            else Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme férfi.");
            Console.WriteLine("A megadott személyazonosító jel személyének születési időpontja: 19{0}{1}. {2}{3}. {4}{5}.", szemazon[1], szemazon[2], szemazon[3], szemazon[4], szemazon[5], szemazon[6]);
            
            Console.WriteLine();

            Console.WriteLine("Adja meg a második személyazonosító jelének első 10 jegyét is: ");
            szemazon2 = Console.ReadLine();

            Console.WriteLine();

            int szemazon_egy = szemazon[1];
            int szemazon_ketto = szemazon2[1]
            int x = String.Compare(szemazon[1], szemazon2[1]);
            if (x > 0) Console.WriteLine("Az első személyazonosító jel személye a nagyobb.");
            else if (x < 0) Console.WriteLine("A második személyazonosító jel személye a nagyobb.");

            Console.ReadKey();
        }
    }
}
