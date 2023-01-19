using System;

namespace AlgorithmAndDS.LinkList.Generic
{
    public class Node<T>
    {
        public T data;
        public Node<T> next = null;
    }
    public class SampleLinkList<T>
    {
        Node<T> head = null;
        Node<T> tail = null;

        public void AddLast(T data)
        {
            Node<T> item = new Node<T>();
            item.data = data;
            if (head == null)
            {

                head = item;
                tail = item;
            }
            else
            {
                tail.next = item;
                tail = item;
            }
        }
        public void AddFirst(T data)
        {
            Node<T> item = new Node<T>();
            item.data = data;
            if (head == null)
            {

                head = item;
                tail = item;
            }
            else
            {
                item.next = head;
                head = item;
            }

        }
        public void ReadAll()
        {
            Node<T> curent = head;
            while (curent.next != null)
            {
                Console.WriteLine(curent.data);
                curent = curent.next;

            }
            Console.WriteLine(curent.data);
        }
    }
}
