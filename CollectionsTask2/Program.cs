using System;
using System.Collections.Generic;

namespace CollectionsTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 0;
            Queue<int> clients = CreateQueue();

            Console.WriteLine($"В очереди {clients.Count} клиентов");

            while (clients.Count > 0)
            {
                ServeClient(ref balance, clients);
                GoNext();
            }

            Console.WriteLine("Все клиенты обслужены");
        }

        private static void GoNext()
        {
            Console.WriteLine("Нажмите любую клавишу для обслуживания очередного клиента");
            Console.ReadKey();
            Console.Clear();
        }

        static void ServeClient(ref int balance, Queue<int> clients)
        {
            int clientCash = clients.Dequeue();
            balance += clientCash;
            Console.WriteLine($"Очередной клиент совершил покупку на {clientCash} рублей. Ваш баланс составляет : {balance} рублей. Ещё клиентов в очередии: {clients.Count}");
        }

        static Queue<int> CreateQueue()
        {
            Random random = new Random();
            int maxSizeQueue = 10;
            int maxCashClient = 10000;
            Queue<int> clients = new Queue<int>();

            for (int i = 0; i < maxSizeQueue; i++)
            {
                clients.Enqueue(random.Next(maxCashClient));
            }

            return clients;
        }
    }
}
