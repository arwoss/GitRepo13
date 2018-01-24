using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Console3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[20] { 2, 5, 6, 10, 13, 17, 18, 19, 21, 2, 10, 13, 25, 31, 17, 34, 21, 2, 5, 17 };
            int[] posizioni = new int[numeri.Length];
            int totali = 0;
            int numero = 0;
            int ctr = 0;

            Console.WriteLine("Inserisci il numero che vuoi cercare in lista");
            totali = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 20; i++)
            {
                if (totali == numeri[i])
                {
                    ctr = ctr + 1;
                    posizioni[numero] = i;
                    numero++;
                }
            }
            if (ctr > 0)
            {
                Console.WriteLine("Il numero è stato trovate {0} volte", ctr);
                for (numero = 0; numero < ctr; numero++)
                {
                    Console.WriteLine("Il numero che hai inserito all'inizio è {0} e si trova alla {1}° posizione dell'array", totali, posizioni[numero]);

                }
            }
            else
            {
                Console.WriteLine("Non è stato trovato il numero che hai digitato, riprova");
            }
            Console.ReadLine();
        }
    }
}
