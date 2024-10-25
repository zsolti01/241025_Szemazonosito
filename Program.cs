using System;
using System.Collections.Generic;
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
            Console.WriteLine( "Adja meg a személyazonosító jelének első 10 jegyét: " );
            szemazon = Console.ReadLine();
            Console.WriteLine();
            if (szemazon[0] % 2 == 0) Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme nő.");
            else Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme férfi.");
            Console.WriteLine("A megadott személyazonosító jel személyének születési időpontja: 19{0}{1}. {2}{3}. {4}{5}.", szemazon[1], szemazon[2], szemazon[3], szemazon[4], szemazon[5], szemazon[6]);
        }
    }
}
