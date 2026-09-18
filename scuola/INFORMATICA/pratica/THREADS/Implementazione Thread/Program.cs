using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Diagnostics;

namespace Implementazione_Thread
{
    internal class Program
    {
        static volatile int risorsa_condivisa; // Risorsa critica
        static SemaphoreSlim semaforo = new SemaphoreSlim(1);
        static void Main(string[] args)
        {
            char scelta = ' ';
            Thread t1, t2;

            do
            {
                menu(ref scelta);
                switch (scelta)
                {
                    case 'a':
                        risorsa_condivisa = 0;
                        t1 = new Thread(incrementa);
                        t2 = new Thread(decrementa);

                        t1.Start();
                        t2.Start();
                        t1.Join();
                        t2.Join();
                        Console.WriteLine("(Main Thread): Tutti i thread sono terminati" + " sono terminati , risorsa condivisa: " + risorsa_condivisa.ToString());

                        break;
                    case 'b':
                        Console.WriteLine("(Main Thread): Avvia i threads");
                        Parallel.Invoke(
                            () => scriviFile("*"),
                            () => scriviFile("#")
                            );
                        break;
                    case 'q':
                        Console.WriteLine("FINE");
                        Console.ReadKey();
                        break;
                }

            } while (scelta != 'Q');
        }
        private static void menu(ref char scelta)
        {
            Console.WriteLine("----- ESEMPI DI ESECUZIONE RBITRARIA -----");
            Console.WriteLine("a. Accesso a risorda condivisa");
            Console.WriteLine("b. Acceso a risorsa file condivisa");
            Console.WriteLine("q. Esci");
            do
            {
                Console.Write("Scelta > ");
            } while (!char.TryParse(Console.ReadLine(), out scelta));
        }
        private static void decrementa()
        {
            Console.WriteLine("(Thread decrementa)... avviato");
            for (int i = 0; i < 1000000; i++)
            {
                semaforo.Wait(); // Mi va trovare se ci sono blocchi verdi
                // Sezione critica
                risorsa_condivisa = risorsa_condivisa - 1;
                // Fine sezione critica
                semaforo.Release();
            }
        }

        private static void incrementa()
        {
            Console.WriteLine("(Thread incrementa)... avviato");
            for (int i = 0; i < 1000000; i++)
            {
                semaforo.Wait(); // Mi va trovare se ci sono blocchi verdi, se ci sono continua, altrimenti aspetta
                // Sezione critica
                risorsa_condivisa = risorsa_condivisa + 1;
                // Fine sezione critica
                semaforo.Release();
            }
        }
        private static void scriviFile(string msg)
        {
            StreamWriter sw;
            for (int i = 0; i < 50; i++)
            {
                // Sezione critica
                semaforo.Wait();
                sw = new StreamWriter("thread.txt", true);
                sw.Write(msg);
                sw.Close();
                semaforo.Release();
                // Fine sezione critica
            }
            Process.Start("thread.txt");
        }

    }
}
