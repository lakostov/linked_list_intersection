using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_Lists_Intersection
{
    class Program
    {
        class Node
        {
            public int Data { get; set; }
            public Node Next { get; set; }

            public Node(int value)
            {
                Data = value;
                Next = null;
            }
        }

        class LinkedList
        {
            public Node Head { get; set; }

            public LinkedList()
            {
                Head = null;
            }
            public void Push(int data)
            {
                Node newNode = new Node(data);
                newNode.Next = Head;
                Head = newNode;
            }

            public void GetIntersect(Node head1, Node head2)
            {
                Node tempNode = head1;

                while (tempNode != null)
                {
                    if (Contains(head2, tempNode.Data))
                    {
                        Push(tempNode.Data);
                    }
                    tempNode = tempNode.Next;
                }
            }

            public bool Contains(Node h, int data)
            {
                Node t = h;
                while (t != null)
                {
                    if (t.Data == data)
                    {
                        return true;
                    }
                    t = t.Next;
                }
                return false;
            }

            public void PrintList()
            {
                Node tempNode = Head;
                while (tempNode != null)
                {
                    Console.WriteLine(tempNode.Data);
                    tempNode = tempNode.Next;
                }
            }
        }

        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            LinkedList intersect = new LinkedList();

            list1.Push(25);
            list1.Push(8);
            list1.Push(10);
            list1.Push(15);
            list1.Push(12);

            list2.Push(3);
            list2.Push(8);
            list2.Push(11);
            list2.Push(12);

            intersect.GetIntersect(list1.Head, list2.Head);

            Console.WriteLine("List1 is:");
            list1.PrintList();
            Console.WriteLine("List2 is:");
            list2.PrintList();
            Console.WriteLine("Intersect of List1 and List2 is:");
            intersect.PrintList();
        }
    }
}
