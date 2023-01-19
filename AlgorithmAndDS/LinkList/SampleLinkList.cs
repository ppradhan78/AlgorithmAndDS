using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LinkList
{
    public class SampleLinkList
    {
        LinkListNode head = null;
      

        public void AddLast(int data)
        {
            LinkListNode item = new LinkListNode();
            item.data = data;
            if (head==null)
            {
             
                head = item;
                head.next = null;
            }
            else
            {
                //Last elemnt 
                LinkListNode curent = head;
                while (curent.next!=null)
                {
                    curent = curent.next;
                }
                curent.next = item;
                item.next = null;
            }
        }
        public void AddFirst(int data)
        {
            LinkListNode item = new LinkListNode();
            item.data = data;
            item.next = head;
            head = item;
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
