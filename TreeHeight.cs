using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class TreeHeight
    {
        static public int GetHeight(Node root) //USE RECURSION
        {

            if (root == null) return -1;

            var leftHeight = GetHeight(root.Left);
            var rightHeight = GetHeight(root.Right);
          
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
