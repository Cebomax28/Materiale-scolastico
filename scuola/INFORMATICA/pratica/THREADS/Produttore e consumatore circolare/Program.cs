using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Produttore_e_consumatore_circolare
{
    internal class Program
    {
        const int T_PROF = 300;
        const int T_CONS = 1000;
        static int dimBuffer = 10;

        static int[] buffer = new int[dimBuffer];

        static SemaphoreSlim sem_vuoto = new SemaphoreSlim(dimBuffer);
        static SemaphoreSlim sem_pieno = new SemaphoreSlim(0);
        static void Main(string[] args)
        {
            int prod_dati = 30;
            Stopwatch sw = new Stopwatch();
            Thread[] t_prod = new Thread[1];
            Thread[] t_cons = new Thread[1];

            sw.Start();

            for (int i = 0; i < t_prod.Length; i++)
            {
                t_prod[i] = new Thread(produci);
                t_prod[i].Name = "";
            }

            for (int i = 0; i < t_cons.Length; i++)
            {
                t_prod[i] = new Thread(consuma);

            }

            sw.Stop();
            Console.WriteLine("(Main thread): Elaborazione terminata in: " + sw.ElapsedMilliseconds);
            Console.ReadKey();
        }

        private static void consuma()
        {
            throw new NotImplementedException();
        }

        private static void produci()
        {
            throw new NotImplementedException();
        }
    }
}
