using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDS.LinkList
{
    public class LinkListData
    {
        public class Node
        {
            string data;
            Node next;
            Node head;

            public Node(string data)
            {
                this.data = data;
                this.next = null;
            }
            public void AddFirst(string data)
            {
                Node newNode = new Node(data);
                if (head==null)
                {
                    head = newNode;
                    return;
                }
                newNode.next = head;
                head=newNode;
            }
            public void AddLast(string data)
            {
                Node newNode = new Node(data);
                if (head == null)
                {
                    head = newNode;
                    return;
                }
                Node currentNode = head;
                head = newNode;
            }
        }
    }
}
