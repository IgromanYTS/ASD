using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2_asd
{
    public class Queue<T>
    {
        private LinkedList<T> list;
        public Queue()
        {
            list = new LinkedList<T>();
        }
        public void Enqueue(T item)
        {
            list.AddLast(item);
        }
        public T Dequeue()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Черга пуста");
            }
            T item = list.First.Value;
            list.RemoveFirst();
            return item;
        }
        public T Peek()
        {
            if (list.Count == 0)
            {
                Console.WriteLine("Черга пуста");
            }
            return list.First.Value;
        }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }
        public void Display()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(4);
            queue.Display();
            queue.Dequeue();
            queue.Display();
            Console.ReadLine();

        }
    }
}
