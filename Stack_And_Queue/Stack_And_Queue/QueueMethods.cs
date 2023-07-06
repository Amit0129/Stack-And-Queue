using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queue
{
    public class QueueMethods<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next= node;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                head = head.next;
            }
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Node<T> temp = head;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
