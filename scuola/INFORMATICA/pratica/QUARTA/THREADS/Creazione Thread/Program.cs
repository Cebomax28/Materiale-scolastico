using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Creazione_Thread
{
    internal class Program
    {
        static int risorsa_condivisa;
        static void Main(string[] args)
        {
            char scelta = ' ';
            Thread[] vT;
            Thread t1, t2;

            /*
             * t1.Name => Setta il nome del thread
             * t1.IsAlive => TRUE/FALSE => Verifica se il thread è in esecuzione
             * t1.Start() => Avvia il thread
             * t1.Suspend() => Sospende il thread in esecuzione
             * t1.Resume() => Avvia il thread precedentemente sospeso
             * t1.Join() => Il chiamate (main thread) attende il ricongiugimento del thread precedentemente avviato
             * t1.Abort() => Esegue una kill del thread
             */

            do
            {
                menu(ref scelta);
                scelta = scelta.ToString().ToUpper().ToCharArray()[0];
                switch (scelta)
                {
                    case 'A': // Singolo thread
                        t1 = new Thread(eseguiTask);
                        t1.Name = "Thread1";
                        Console.WriteLine("(main thread): " + t1.Name + " Creato - attivo " + t1.IsAlive);
                        t1.Start();
                        // DA QUESTO MOMENTO IL MAIN_THREAD ED IL Thread1 LAVORANO IN PARALLELO
                        Console.WriteLine("(main thread): Esercizio a terminato");
                        t1.Join(); // Main thread attende fine thread1 per proseguire
                        break;

                    case 'B':
                        int n;
                        do
                        {
                            Console.Write("Quanti thread vuoi avviare? > ");
                        } while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));

                        vT = new Thread[n]; // Istanza
                        for (int i = 0; i < n; i++)
                        {
                            vT[i] = new Thread(eseguiTask);
                            vT[i].Name = "Thread_" + (i + 1).ToString();
                        }
                        Console.WriteLine($"(main thread): tutti i {n} thread istanziati e configurati...");
                        Thread.Sleep(500);
                        for (int i = 0; i < n; i++)
                            vT[i].Start();

                        for (int i = 0; i < n; i++)
                            vT[i].Join();

                        Console.WriteLine($"(main thread): Esercizio b terminato");
                        break;

                    case 'C':
                        Parallel.Invoke(ita, eng, esp); // La Parallel.Provoke() Ha gia la .Start() e la .Join() inclusa
                        //Parallel.Invoke( () => saluta("SALVE"), saluta("HELLO"), saluta("HOLA"));

                        Console.WriteLine($"(main thread): Esercizio c terminato");

                        break;

                    case 'D':
                        risorsa_condivisa = 0;

                        t1 = new Thread(somma);
                        t2 = new Thread(sottrai);
                        
                        t1.Start();
                        t2.Start();

                        t1.Join();
                        t2.Join();

                        Console.WriteLine($"(main thread): Esercizio d terminato: {risorsa_condivisa.ToString()}");
                        break;

                    case 'Q':
                        Console.WriteLine("FINE");
                        Console.ReadKey();
                        break;
                }
            } while (scelta != 'Q');

        }

        /*
         * private void saluta(string msg)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name}: {msg}");
        }
        */

        private static void sottrai()
        {
            for (int i = 0; i < 1000000; i++)
                risorsa_condivisa--;
        }

        private static void somma()
        {
            for (int i = 0; i < 1000000; i++)
                risorsa_condivisa++;
        }

        private static void ita()
        {
            Console.WriteLine("SALVE");
        }

        private static void esp()
        {
            Console.WriteLine("HOLA");
        }

        private static void eng()
        {
            Console.WriteLine("HELLO");
        }

        private static void eseguiTask()
        {
            Console.WriteLine($"(thread: {Thread.CurrentThread.Name}): eseguo task");

            for (int i = 0; i < 1000000; i++){}

            Console.WriteLine($"(thread {Thread.CurrentThread.Name}) fine task");
        }

        private static void menu(ref char scelta)
        {
            Console.WriteLine("----- ESEMPI DI ESECUZIONE NON ARBITRATA -----");
            Console.WriteLine("a. Singolo Thread");
            Console.WriteLine("b. Multi Thread");
            Console.WriteLine("c. Multi Thread (Parallel)");
            Console.WriteLine("d. Accesso a medesima risorsa");
            Console.WriteLine("q. Esci");
            do
            {
                Console.Write("Scelta > ");
            } while (!char.TryParse(Console.ReadLine(), out scelta));
        }
    }
}
