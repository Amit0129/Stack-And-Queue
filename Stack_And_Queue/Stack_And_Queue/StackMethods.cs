using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_And_Queue
{
    public class StackMethods<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node= new Node<T>(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                node.next= head;
                head = node;
            }
        }
        public void Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Empty Linked List");
            }
            else
            {
                Console.WriteLine(head.data);
            }
        }
        public void Pop()
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
        public void EmptyStack()
        {
            while (head != null)
            {
                Peek();
                Pop();
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
