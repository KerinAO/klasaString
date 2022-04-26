using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string recenica = "Danas radimo s klasom String";

            //Broj znakova
            Console.WriteLine("Broj znakova u recenici je: " + recenica.Length);

            //Ispis malim i velikim slovima
            Console.WriteLine("\n --- ToLower is ToUpper");
            Console.WriteLine(recenica.ToLower());
            Console.WriteLine(recenica.ToUpper());

            //Metoda SubString
            Console.WriteLine("\n --- SubString");
            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Substring(0, 5));

            //Metoda Replace
            Console.WriteLine("\n --- Replace");
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));

            //Metoda Split
            Console.WriteLine("\n --- Split");
            string[] rijec = recenica.Split(' ');
            for (int i = 0; i < rijec.Length; i++)
            {
                Console.WriteLine(rijec[i]);
            }

            //Metode IndexOf i Insert
            Console.WriteLine("\n --- IndexOf i Insert");
            int pozicija = recenica.IndexOf("radimo");
            if (pozicija >= 0)
            {
                Console.WriteLine(recenica.Insert(pozicija, "intenzivno "));
            }

            Console.ReadKey();
        }
    }
}
