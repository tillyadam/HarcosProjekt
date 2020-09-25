using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Harcos h = new Harcos("UwU", 1);

            List<Harcos> harcosLista = new List<Harcos>();

            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
