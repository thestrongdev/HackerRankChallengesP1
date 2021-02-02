using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int data, Node left, Node right)
        {
            Data = data;
            Left = left;
            Right = Right;
        }

        public Node(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }

        public Node()
        {
        
        }

        public static Node insert(Node root, int data) //BINARY SEARCH TREE...
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.Data)
                {
                    cur = insert(root.Left, data);
                    root.Left = cur;
                }
                else
                {
                    cur = insert(root.Right, data);
                    root.Right = cur;
                }
                return root;
            }
        }

        public static Node insertNonSearch(Node root, int data) //BINARY SEARCH TREE...
        {

            if(root == null)
            {
                root = new Node(data);
                return root;
            }

            Node temp;
            Queue<Node> q = new Queue<Node>();
            q.Enqueue(root);

            while (q.Count != 0)
            {
                temp = q.Dequeue();

                if (temp.Left != null)
                {
                    q.Enqueue(temp.Left);
                }
                else
                {
                    temp.Left = new Node(data);
                    return root;
                }

                if (temp.Right != null)
                {
                    q.Enqueue(temp.Right);
                }
                else
                {
                    temp.Right = new Node(data);
                    return root;
                }

            }

            return root;
        }
    }
}
