using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_asd
{
    class Queue
    {
        private int amount_el;
        private int[] array;
        private int front;
        private int rear;
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть к-ть елементів у масиві: ");
            int amount_el = Int32.Parse(Console.ReadLine());
            Queue queue = new Queue(amount_el);
            queue.enquence(10);
            queue.enquence(5);
            queue.enquence(3);
            queue.enquence(7);
            queue.display();
            queue.dequence();
            queue.dequence();
            queue.enquence(100);
            queue.dequence();
            queue.display();
            Console.ReadLine();

        }
        public Queue(int amount_el) 
        {
            this.amount_el = amount_el;
            array = new int[amount_el]; 
            front = -1;
            rear = -1; 
        }
        bool isFull() 
        {
            if (front == 0 && rear == amount_el - 1)
            {
                return true;
            }
            else if (front == rear + 1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
        bool isEmpty() 
        {
            if (front == -1)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public void enquence(int element) 
        {
            if (isFull())
            {
                Console.WriteLine("Черга заповнена: ");
            }
            else if (front == -1) 
            {
                front = 0;
                rear = (rear + 1) % amount_el;
                array[rear] = element;
                Console.WriteLine("Елемент додано: " + element);
            }
            else
            {
                rear = (rear + 1) % amount_el; 
                array[rear] = element;
                Console.WriteLine("Елемент додано: " + element);
            }

        }

        public int dequence() 
        {
            if (isEmpty())
            {
                Console.WriteLine("Черга пуста ");
                return (-1);
            }
            else 
            {
                int element = array[front];
                if (front == rear)
                {
                    front = -1;
                    rear = -1;
                }
                else 
                {
                    front = (front + 1) % amount_el;
                }
                return element;
            }


        }
        public void display() 
        {
            int i;
            if (isEmpty())
            {
                Console.WriteLine("Пуста черга ");
            }
            else
            {
                Console.WriteLine("Показник Front: " + front);
                //Console.WriteLine(array[front]);
                Console.WriteLine("Елементи: ");

                /*int element = dequence();
                if (element != -1)
                {
                    Console.WriteLine("Видалений елемент:" + element);
                }*/

                for (i = front; i != rear; i = (i + 1) % amount_el)
                {
                    Console.WriteLine(array[i] + " ");
                }
                Console.WriteLine(array[i]);
                Console.WriteLine("Показник Rear: " + rear);
            }            
        }
    }
}
