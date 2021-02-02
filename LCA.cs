using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class LCA //binary search tree
    {
        public static Node lowestCommonAncestor(Node root, int v1, int v2)
        {
            //create node to set equal to the parent
            if (root.Data > Math.Max(v1, v2))
            {
                return lowestCommonAncestor(root.Left, v1, v2);
            }
            else if (root.Data < Math.Max(v1, v2))
            {
                return lowestCommonAncestor(root.Right, v1, v2);
            }
            else
            {
                return root;
            }
        }
    

        public static void InOrderTravIter(Node root)
        {
            if (root == null) return;
            Stack<Node> s = new Stack<Node>();

            while(root != null || s.Count > 0)
            {
                while(root != null)
                {
                    s.Push(root);
                    root = root.Left;
                }

                root = s.Pop();
                Console.WriteLine(root.Data);
                root = root.Right;

            }

            //while (true)
            //{
            //    if (root != null)
            //    {
            //        s.Push(root);
            //        root = root.Left;
            //    }
            //    else
            //    {
            //        if (s.Count == 0) break;
            //        root = s.Pop();
            //        Console.WriteLine(root.Data);
            //        root = root.Right;
            //    }
            //}
        }

        public static void InOrderTrav(Node root) //recursively
        {         
            if (root.Left != null)
            {
                InOrderTrav(root.Left);
          
            }
            Console.WriteLine(root.Data);

            if(root.Right != null)
            {
                InOrderTrav(root.Right);
            }
        }
    }
}
