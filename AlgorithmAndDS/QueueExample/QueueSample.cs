using System;

namespace AlgorithmAndDS.QueueExample
{
    public class QueueSample
    {
        private int[] element;
        private int front;
        private int rear;
        private int max;

        public QueueSample(int size)
        {
            element = new int[size];
            front = 0;
            rear = -1;
            max = size;
        }
        public void enqueue(int item)
        {
            if (rear == max - 1)
            {
                Console.WriteLine("Queue Overflow");
                return;
            }
            else
            {
                element[++rear] = item;
            }
        }

        // Function to remove an item from queue.
        // It changes front and size
        public int dequeue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return -1;
            }
            else
            {
                Console.WriteLine(element[front] + " dequeued from queue");
                int p = element[front++];
                Console.WriteLine();
                Console.WriteLine("Front item is {0}", element[front]);
                Console.WriteLine("Rear item is {0} ", element[rear]);
                return p;
            }
        }

        // Function to print queue.
        public void printQueue()
        {
            if (front == rear + 1)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            else
            {
                for (int i = front; i <= rear; i++)
                {
                    Console.WriteLine(element[i] + " enqueued to queue");
                }
            }
        }
    }
}
