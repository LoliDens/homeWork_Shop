using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clients = new Queue<int>();
            int wallet = 0;

            clients.Enqueue(100);
            clients.Enqueue(150);
            clients.Enqueue(200);
            clients.Enqueue(250);
            clients.Enqueue(1000);

            CostomerService(clients, ref wallet);
        }

        static void CostomerService(Queue<int> clients, ref int wallet)
        {
            foreach (var client in clients)
            {
                Console.WriteLine($"Обслужен клиент с суммой заказа - {client}.");
                wallet += client;

                Console.WriteLine($"На данный момент на вашем счету  - {wallet}.");
                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine("Клиентов больше нет.");
            Console.ReadKey();
        }
    }
}
