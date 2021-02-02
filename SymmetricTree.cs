using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class SymmetricTree
    {
        static public bool IsSymmetric(Node root)
        {
            //exit conditions
            if (root == null) return true;
            if (root != null && root.Left == null && root.Right == null) return true;

            return root == null || Check(root.Left, root.Right);

        }

        static public bool Check(Node left, Node right)
        {
            if (left == null && right == null)
            {
                return true;
            }
            else if (left != null && right != null)
            {
                return left.Data == right.Data && Check(left.Left, right.Right)
                    && Check(left.Right, right.Left);
            }

            return false;
        }
    }
}
