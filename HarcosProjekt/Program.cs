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
            

            List<Harcos> harcosLista = new List<Harcos>();
            Harcos kihivo1 = new Harcos("Feri",2);
            Harcos kihivo2 = new Harcos("Peti",3);
            Harcos kihivo3 = new Harcos("Juli",1);
            harcosLista.Add(kihivo1);
            harcosLista.Add(kihivo2);
            harcosLista.Add(kihivo3);

            //foreach (Harcos harcos in harcosLista)
            //{
            //    Console.WriteLine(harcos);
            //}

            
            Console.Write("Adja meg a harcosa nevet: ");
            string jatekosHarcosNev = Console.ReadLine();
            Harcos jatekosHarcos = new Harcos(jatekosHarcosNev, 1);
            harcosLista.Add(jatekosHarcos);

            foreach (Harcos harcos in harcosLista)
            {                
                string nev = harcos.Nev;
                int index = harcosLista.FindIndex(a => a.Nev == nev);
                Console.Write("{0}. ",index+1);
                Console.WriteLine(harcos);

            }

            string mitSzeretne;
            do
            {
                Console.WriteLine("Mit szeretne? \n a) Megkuzdeni egy harcossal \n b) Gyogyulni \n c) Kilepni");
                mitSzeretne = Console.ReadLine();
            } while (mitSzeretne != "a" && mitSzeretne != "b" && mitSzeretne != "c");
            


            Console.ReadKey();
        }
    }
}
