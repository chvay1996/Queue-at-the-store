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
            int amountStoreMoney = 0;
            Queue<int> store = new Queue<int>();
            store.Enqueue(1212);
            store.Enqueue(515);
            store.Enqueue(7818);
            store.Enqueue(9872);
            store.Enqueue(2239);

            while (store.Count != 0)
            {
                foreach (var queue in store)
                {
                    Console.WriteLine($"В очереди стоит на сумму: {queue}");
                }

                amountStoreMoney += store.Dequeue();

                Clear();

                Console.WriteLine($"Сумма магазина: {amountStoreMoney}");
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