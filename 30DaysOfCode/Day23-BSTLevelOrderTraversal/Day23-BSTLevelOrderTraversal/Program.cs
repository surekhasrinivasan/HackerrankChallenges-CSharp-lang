﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_BSTLevelOrderTraversal
{
    /* Task 
     * A level-order traversal, also known as a breadth-first search, visits each level of a tree's nodes 
     * from left to right, top to bottom. You are given a pointer, root, pointing to the root of a binary search tree. 
     * Complete the levelOrder function provided in your editor so that it prints the level-order traversal of the binary search tree.
     * Hint: You'll find a queue helpful in completing this challenge.
     * Input Format
     * The locked stub code in your editor reads the following inputs and assembles them into a BST: 
     * The first line contains an integer, T(the number of test cases).
     * The T subsequent lines each contain an integer,data, denoting the value of an element that must be added to the BST.
     * Output Format
     * Print the data value of each node in the tree's level-order traversal as a single line of N space-separated integers.
     * 
     * Sample Input
     * 6
     * 3
     * 5
     * 4
     * 7
     * 2
     * 1
     * Sample Output
     * 3 2 5 1 4 7 
     */

    public class Node
    {
        public Node left, right;
        public int data;
        public Node(int data)
        {
            this.data = data;
            left = right = null;
        }
    }

    public class Program
    {
        public static string data { get; private set; }

        public static void levelOrder(Node root)
        {
            //Write your code here
            Queue<Node> queue = new Queue<Node>(); 

            // if root is not empty
            if(root != null)
            {
                // enqueue current root
                queue.Enqueue(root);
            }
            // while there are nodes to process 
            while(queue.Count > 0)
            {
                // dequeue next node
                Node tree = queue.Dequeue();

                // process tree's root
                // enqueue child elements from next level in order

                // if tree has non-empty left subtree
                if(tree.left != null)
                {
                    queue.Enqueue(tree.left);
                }
                if(tree.right != null)
                {
                    queue.Enqueue(tree.right);
                }
                Console.Write(tree.data + " ");                
            }
            Console.WriteLine();
        }

        public static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(String[] args)
        {
            Node root = null;

            Console.WriteLine("Enter the number of test cases: ");
            int T = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter data element that must be added to the BST: ");
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }
    }
}

