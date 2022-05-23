using System;
using System.Collections.Generic;

namespace Queue_at_the_store
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateQueue();
        }

        static void CreateQueue()
        {
            int result = 0;
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1212);
            queue.Enqueue(515);
            queue.Enqueue(7818);
            queue.Enqueue(9872);
            queue.Enqueue(2239);

            while (queue.Count != 0)
            {
                foreach (var item in queue)
                {
                    Console.WriteLine($"В очереди стоит на сумму: {item}");
                }

                result += queue.Dequeue();

                Clear();

                Console.WriteLine($"Сумма магазина: {result}");
            }
        }
        static void Clear()
        {
            Console.WriteLine("Нажмите любую кнопку для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
/*Задача:
У вас есть множество целых чисел. Каждое целое число это сумма покупки.
Вам нужно обслуживать клиентов до тех пор пока очередь не станет пуста.
После каждого обслуженного клиента деньги нужно добавлять на наш счёт и выводить его в консоль.
После обслуживания каждого клиента программа ожидает нажатия любой клавиши, после чего затирает консоль и по новой выводит всю информацию, только уже со следующим клиентом*/