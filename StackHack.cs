using System;
using System.Collections.Generic;
using System.Text;

namespace hackerrank2
{
    class StackHack
    {

        public static string Balanced(string s)
        {
            string isBalanced = "";

            Stack<char> firstHalf = new Stack<char>();
            Stack<char> interimSecHalf = new Stack<char>();
            Stack<char> SecHalf = new Stack<char>();

            char[] stringArr = s.ToCharArray();

            if (stringArr.Length % 2 != 0 || stringArr.Length == 0) return isBalanced = "NO";

            for (int i = 0; i < s.Length/2; i++)
            {
                firstHalf.Push(stringArr[i]);
            }

            for (int i = s.Length/2; i < s.Length; i++)
            {
                interimSecHalf.Push(stringArr[i]);
            }

            foreach(char val in interimSecHalf)
            {
                SecHalf.Push(val);
            }

            int notAMatch = 0;

           while(firstHalf.Count!=0 && SecHalf.Count != 0)
            {
                char checkOne = firstHalf.Pop();
                char checkTwo = SecHalf.Pop();

                if(checkOne == '[')
                {
                    if (checkTwo != ']') notAMatch += 1;

                } else if(checkOne == '{')
                {
                    if (checkTwo != '}') notAMatch += 1;
                }
                else //if checkOne == '('
                {
                    if (checkTwo != ')') notAMatch += 1;
                }
            }

            if (notAMatch != 0)
            {
                isBalanced = "NO";
            }
            else
            {
                isBalanced = "YES";
            }

            return isBalanced;
        }


        public static void TestStack(string s)
        {
            Stack<char> firstHalf = new Stack<char>();
            Stack<char> interimSecHalf = new Stack<char>();
            Stack<char> SecHalf = new Stack<char>();

            char[] stringArr = s.ToCharArray();

            if (stringArr.Length % 2 != 0 || stringArr.Length == 0) return;

            for (int i = 0; i < s.Length / 2; i++)
            {
                firstHalf.Push(stringArr[i]);
            }

            for (int i = s.Length / 2; i < s.Length; i++)
            {
                interimSecHalf.Push(stringArr[i]);
            }

            foreach (char val in interimSecHalf)
            {
                SecHalf.Push(val);
            }

            Console.WriteLine("FIRST HALF");
            foreach(char val in firstHalf)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("SECOND HALF");
            foreach(char val in SecHalf)
            {
                Console.WriteLine(val);
            }

            Console.WriteLine("END ------------------- ");
                
        }
    }
}
