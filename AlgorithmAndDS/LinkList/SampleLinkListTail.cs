using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LinkList
{
    public class SampleLinkListTail
    {
        LinkListNode head = null;
        LinkListNode tail = null;

        public void AddLast(int data)
        {
            LinkListNode item = new LinkListNode();
            item.data = data;
            if (head==null)
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
        public void AddFirst(int data)
        {
            LinkListNode item = new LinkListNode();
            item.data = data;
            if (head==null)
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
            LinkListNode curent = head;
            while (curent.next != null)
            {
                Console.WriteLine(curent.data);
                curent = curent.next;
              
            }
            Console.WriteLine(curent.data);
        }
    }
}
