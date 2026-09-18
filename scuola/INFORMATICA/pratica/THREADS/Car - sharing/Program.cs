using System.Collections.Generic;
using System;
using System.Net.Http.Headers;
using System.Threading;

//Semafori
SemaphoreSlim sem_manutenzione = new SemaphoreSlim(5);
SemaphoreSlim sem_auto = new SemaphoreSlim(1);

List<int> car_list = new List<int>();


for (int i = 0; i < 30; i++)
{
    car_list.Add(i + 1);
}

Thread[] threads_utenti = new Thread[40];

for (int i = 0; i < threads_utenti.Length; i++)
{
    threads_utenti[i] = new Thread(NoleggiaAuto);
    threads_utenti[i].Start();
}

for (int i = 0; i < threads_utenti.Length; i++)
{
    threads_utenti[i].Join();
    Console.WriteLine($"Thread {threads_utenti[i].ManagedThreadId} ha finito le sue commissioni");

}


void NoleggiaAuto()
{
    List<int> cars_shared = new List<int>();

    bool preso = false;

    while (!preso)
    {
        //Sezione critica
        sem_auto.Wait();
        if (car_list.Count >= 2)
        {
            for (int i = 0; i < 2; i++)
            {
                int j = new Random().Next(0, car_list.Count);
                cars_shared.Add(car_list[j]);
                car_list.RemoveAt(j);
            }
            Console.WriteLine($"Due auto noleggiate dal Thread {Thread.CurrentThread.ManagedThreadId}");
            preso = true;
        }
        else if (car_list.Count == 1)
        {
            int j = new Random().Next(0, car_list.Count);
            cars_shared.Add(car_list[j]);
            car_list.RemoveAt(j);
            Console.WriteLine($"Un'auto noleggiata dal Thread {Thread.CurrentThread.ManagedThreadId}");
            preso = true;
        }

        sem_auto.Release();

        if (!preso)
            Thread.Sleep(100);
    }

    Thread.Sleep(800);

    sem_manutenzione.Wait();
    Thread.Sleep(500);
    sem_auto.Wait();
    car_list.AddRange(cars_shared);
    sem_auto.Release();
    sem_manutenzione.Release();
    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} ha restituito");

}