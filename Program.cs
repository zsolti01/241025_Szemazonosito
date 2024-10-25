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
            if (szemazon[0] % 2 == 0) Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme nő.");
            else Console.WriteLine("A megadott személyazonosító jel alaplán a személy neme férfi.");
        }
    }
}
