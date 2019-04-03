﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day24_MoreLinkedLists
{
    /* Task 
     * A Node class is provided for you in the editor. A Node object has an integer data field, data, 
     * and a Node instance pointer, next, pointing to another node (i.e.: the next node in a list).
     * 
     * A removeDuplicates function is declared in your editor, which takes a pointer to the head node of a 
     * linked list as a parameter. Complete removeDuplicates so that it deletes any duplicate nodes from the 
     * list and returns the head of the updated list.
     * 
     * Note: The head pointer may be null, indicating that the list is empty. Be sure to reset your next pointer
     * when performing deletions to avoid breaking the list.
     * 
     * Input Format
     * The first line contains an integer, N, the number of nodes to be inserted. 
     * The N subsequent lines each contain an integer describing the  data value of a node being inserted at the list's tail.
     * 
     * Constraints
     * The data elements of the linked list argument will always be in non-decreasing order.
     * 
     * Output Format
     * 
     * Your removeDuplicates function should return the head of the updated linked list. The locked stub code in your editor will print the returned list to stdout.
     * 
     * Sample Input
     * 6
     * 1
     * 2
     * 2
     * 3
     * 3
     * 4
     * 
     * Sample Output
     * 
     * 1 2 3 4 
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
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
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

        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
