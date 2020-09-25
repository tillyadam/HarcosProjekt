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
            Harcos kihivo1 = new Harcos("OwO",2);
            Harcos kihivo2 = new Harcos("d_b",3);
            Harcos kihivo3 = new Harcos(":p",1);
            harcosLista.Add(kihivo1);
            harcosLista.Add(kihivo2);
            harcosLista.Add(kihivo3);

            foreach (Harcos harcos in harcosLista)
            {
                Console.WriteLine(harcos);
            }

            Console.WriteLine(h);
            Console.ReadKey();
        }
    }
}
