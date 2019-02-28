using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_LinkedList
{
    /* A Node class is provided for you in the editor. A Node object has an integer data field, data, and a Node instance 
     * pointer, next, pointing to another node (i.e.: the next node in a list).
     * 
     * A Node insert function is also declared in your editor. It has two parameters: a pointer, head, pointing to the 
     * first node of a linked list, and an integer data value that must be added to the end of the list as a new Node object.
     * 
     * Task 
     * 
     * Complete the insert function in your editor so that it creates a new Node (pass data as the Node constructor argument) 
     * and inserts it at the tail of the linked list referenced by the  parameter. Once the new node is added, return the 
     * reference to the head node.
     * 
     * Note: If the head argument passed to the insert function is null, then the initial list is empty.
     * 
     */
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }
    
    class Program
    {
        public static Node insert(Node head, int data)
        {
            //Complete this method
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(String[] args)
        {

            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            display(head);
        }
    }
}
