using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queueClients = GetQueueStore(10);
            int cashRegister = 0;

            while (queueClients.Count > 0)
            {
                Console.WriteLine($"Клиент : {queueClients.Peek()} | Касса - {cashRegister}");
                cashRegister += queueClients.Dequeue();

                Console.ReadKey();
                Console.Clear();
            }

            Console.WriteLine($"Итоговая сумма в кассе - {cashRegister}");
            Console.WriteLine("Очередь закончилась ...");
        }

        static Queue<int> GetQueueStore(int number)
        {
            Queue<int> queue = new Queue<int>();

            for (int i = 1; i <= number; i++)
            {
                queue.Enqueue(GetCostProduct());
            }

            return queue;
        }

        static int GetCostProduct()
        {
            Random random = new Random();
            int cost = 0;
            cost = random.Next(30, 1500);

            return cost;
        }
    }
}