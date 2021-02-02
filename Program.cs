using System;
using System.Collections.Generic;

namespace hackerrank2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("STACK HACKER RANK - BALANCED BRACKETS");
            string test1 = "{[(])}";
            string test2 = "{[()]}";
            string test3 = "{{[[(())]]}}";

            //StackHack.TestStack(test1);
            //StackHack.TestStack(test2);
            //StackHack.TestStack(test3);

            Console.WriteLine(StackHack.Balanced(test1)); //return NO
            Console.WriteLine(StackHack.Balanced(test2)); //return YES
            Console.WriteLine(StackHack.Balanced(test3)); //return YES

            //Console.WriteLine("INFINITE STRING");
            //Console.WriteLine(RepeatedString.RepeatString("abcac", 10)); //returns 4 -----------------------------CLEARED
            //Console.WriteLine(RepeatedString.RepeatString("aba", 10)); //returns 7 -------------------------------CLEARED
            //Console.WriteLine(RepeatedString.RepeatString("abcdef", 100)); //returns 17 --------------------------CLEARED
            //Console.WriteLine(RepeatedString.RepeatString("a", 1000000000000)); //returns 1000000000000 ----------CLEARED
            //Console.WriteLine(RepeatedString.RepeatString("aa", 1000000000000)); //returns 1000000000000 ---------CLEARED
            //Console.WriteLine(RepeatedString.RepeatString("aaa", 1000000000000)); //returns 1000000000000
            //Console.WriteLine(RepeatedString.RepeatString("kmretasscityylpdhuwjirnqimlkcgxubxmsxpypgzxtenweirknjtasxtvxemtwxuarabssvqdnktqadhyktagjxoanknhgilnm", 736778906400)); //returns 51574523448
            //Console.WriteLine("TREE HEIGHT");

            //Node tester = new Node(4, 
            //    new Node(2, 
            //        new Node (1), new Node (3)),
            //    new Node(6, 
            //        new Node (5), new Node (7)));

            //Console.WriteLine(TreeHeight.GetHeight(tester));

            //create the tree first
            ////pull insert method from Hackerrank
            //Node LCAtester = new Node(2);
            //Node.insert(LCAtester, 1);
            //Node.insert(LCAtester, 3);
            //Node.insert(LCAtester, 4);
            //Node.insert(LCAtester, 5);
            //Node.insert(LCAtester, 6);

            //Console.WriteLine("LOWEST COMMON ANCESTOR");
            //Node testing = new Node();
            //testing = LCA.lowestCommonAncestor(LCAtester, 4, 6); //needs to return 3
            //Console.WriteLine(testing.Data);
            //LCA.InOrderTravIter(LCAtester);
            //LCA.InOrderTravIter(LCAtester);

            //Node SymmetricTester = new Node(1);
            //Node.insertNonSearch(SymmetricTester, 2);
            //Node.insertNonSearch(SymmetricTester, 2);
            //Node.insertNonSearch(SymmetricTester, 3);
            //Node.insertNonSearch(SymmetricTester, 4);
            //Node.insertNonSearch(SymmetricTester, 4);
            //Node.insertNonSearch(SymmetricTester, 3);

            //Console.WriteLine(SymmetricTree.IsSymmetric(SymmetricTester));

            //Does my BubbleSort Work?
            //int[] bubbleTest = { 5, 1, 8, 3, 2, 10, 4 };
            //Bubbles.SortBubbles(bubbleTest);

            //foreach(int i in bubbleTest)
            //{
            //    Console.WriteLine(i);
            //}




            //Console.WriteLine("FACTORIAL");
            //Console.WriteLine(Factorial.ReturnFact(4)); //24
            //Console.WriteLine(Factorial.ReturnFact(5)); //120
            //Console.WriteLine(Factorial.ReturnFact(6)); //720
            //Console.WriteLine(Factorial.ReturnFact(7)); //5040
            //Console.WriteLine(Factorial.ReturnFact(10)); //3,628,800
            //Console.WriteLine(Factorial.ReturnFact(13)); //6,227,020,800

            //Console.WriteLine("REPEAT STRING RECURSION");
            //Console.WriteLine(StringRepRecursion.RepeatString("ab", 3));

            //Console.WriteLine(SumRecursive.GetSum(5));

            int[,] hourGlass =
            {
                {-9, -9, -9, 1, 1, 1 },
                {0, -9, 0, 4, 3, 2},
                {-9, -9, -9, 1, 2, 3},
                {0, 0, 8, 6, 6, 0},
                {0, 0, 0, -2, 0, 0},
                {0, 0, 1, 2, 4, 0}
            };

            int[,] hourGlassTwo =
            {
                {1,1,1,0,0,0},
                {0,1,0,0,0,0},
                {1,1,1,0,0,0},
                {0,0,2,4,4,0},
                {0,0,0,2,0,0},
                {0,0,1,2,4,0}
            };

            //Console.WriteLine(HrGlassArr.SumHourglass(hourGlass)); //returns 28
            //Console.WriteLine(HrGlassArr.SumHourglass(hourGlassTwo)); //returns 19

            //int[] arr = { 1, 2, 3, 4, 5 };
            //int[] testArray = LeftRotation.ShiftLeft(arr, 2);

            //foreach(int item in testArray)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
