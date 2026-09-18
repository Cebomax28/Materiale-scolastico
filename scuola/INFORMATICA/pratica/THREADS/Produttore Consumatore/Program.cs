using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Produttore_Consumatore
{
    internal class Program
    {
        // Viene messo a disposizione un buffer (int), Il primo thread si occupa di produrre => carica all'interno del buffer un valore generato casualmente
        // Il secondo thread si occupa di consumare => legge/rimuove e stampa il valore contenuto nel buffer

        const int T_PROD = 200;
        const int T_CONS = 500;
        static volatile int buffer; // Risorsa critica
        static Random rnd = new Random();   
        static SemaphoreSlim sem_vuoto = new SemaphoreSlim(1);
        static SemaphoreSlim sem_pieno = new SemaphoreSlim(0);
        static void Main(string[] args)
        {
            int tot_dati = 10;
            Console.WriteLine("(Main thread): Un produttore, un consumatore, buffer singolo");
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();
            Parallel.Invoke( // Funziona solo  se n prodotti e consumatori sono uguali
                () => Produci(tot_dati),
                () => Consuma(tot_dati)
                );
            Console.WriteLine("(Main thread): Elaborazione terminata in " + sw.ElapsedMilliseconds + " ms");
            Console.ReadKey();
        }
        private static void Produci(int totale)
        {
            int val;
            for (int i = 1; i <= totale; i++)
            {
                val = rnd.Next(1000, 2000);
                Thread.Sleep(T_PROD);
                // SEZIONE CRITICA
                sem_vuoto.Wait();
                buffer = val;
                sem_pieno.Release();
                // FINE SEZIONE CRITICA
                Console.WriteLine("(Thread #" + Thread.CurrentThread.ManagedThreadId + ") ha prodotto " + val.ToString());

            }
        }
        private static void Consuma(int totale)
        {
            int val;
            for (int i = 1; i <= totale; i++)
            {
                // SEZIONE CRITICA
                sem_pieno.Wait();
                val = buffer;
                sem_vuoto.Release();
                // FINE SEZIONE CRITICA
                Console.WriteLine("(Thread #" + Thread.CurrentThread.ManagedThreadId + ") ha consumato " + val.ToString());
                Thread.Sleep(T_CONS);

            }
        }
    }
}
