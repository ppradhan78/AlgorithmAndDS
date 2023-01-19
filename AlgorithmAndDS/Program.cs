using AlgorithmAndDS.Array;
using AlgorithmAndDS.BinaryTree;
using AlgorithmAndDS.BinaryTree.Generic;
using AlgorithmAndDS.LinkList;
using AlgorithmAndDS.LinkList.Generic;
using AlgorithmAndDS.Linq;
using AlgorithmAndDS.Number;
using AlgorithmAndDS.QueueExample;
using AlgorithmAndDS.Sorting.Bubble;
using AlgorithmAndDS.Sorting.Selection;
using AlgorithmAndDS.StackExample;
using AlgorithmAndDS.String;
using AlgorithmAndDS.Traingle;
using System;
using System.Collections.Generic;
using System.Linq;
namespace AlgorithmAndDS
{
    class Program
    {
        static void Main(string[] args)
        {

            #region String
            //ReverseOfString.ReverseOfAString();
            //ReverseOfLetter.ReverseOfALetter();
            //ReverseOfLetterInSentance.ReverseOfALetterInSentance();
            //StringTitleCase.convertToTitleCaseIteratingChars();
            //RemoveSpacesInString.RemoveSpaces();
            //StringPermutations.PermutationsOfString();
            //PalindromeString.IsPalindromeString();
            //FirstLetterOfString.FirstLetter_1();
            //SubStringOfInput.GenerateSubstring();
            #endregion

            #region Number
            //ProdArrayProgram.ProdOfArray();
            //Swap2NumberProgram.Swap2Number();
            //SumOfDigitNumber.GetSumOfDigitNumber();
            //SmallestPosNoWithoutCompareProgram.SmallestPosNoWithoutCompare();
            //ReverseOfNumber.GetReverseOfNumber();
            //GCD.FindGCD();
            //ArmstrongNumber.IsArmstrongNumber1();
            //PalindromeNumber.IsPalindromeNumber();
            //FibonacciNumber.GetFibonacciNumber();
            //BinaryToDecimalConversion.BinaryToDecimal();
            //TwoIntHaveOppositeSign.FindTwoIntHaveOppositeSign();
            //CheckPrimeNumber.IsPrime();
            //LengthOfString.GetLengthOfString();
            //ZeroesToEndOfArray.Print();
            //SearchElementToEnd.moveElementToEnd();
            //BinarySearchExample.BinarySearch();
            //SqrtOfNumber.FindSqrt();
            //FibonacciSeries.GetFibonacciNumber();
            #endregion

            #region Array
            //RevArrayProgram.RevOfArray();
            //RevArrayProgram.ReverseOfArrayForLoop();
            //LargestSmallestNumberInArray.FindLargestSmallestNumberInArray();
            //SumOfArrayElement.SumOfArray();
            //ArrayNRotateProgram.ArrayNRotate();
            //LargestElementArray.FindLargestElementArray();
            //smallestElementArray.FindSmallestElementArray();
            //ArrayEvenOddNumber.Array_ProductOfEvenOddNumberIndex();
            //MinArrayProgram.FindMinElementInArray();
            //MergeTwoArray.Merge();
            //RemoveTheDuplicateElement.RemoveTheDuplicateElementArray();



            //GenerateMatrix.Print3X3Matrix();
            //MeanMedianArrayProgram.FindMeanMedianArrayProgram();
            //ArraySearch.Array_Search();
            //ArraySort.Sort1();
            //ArraySort.SortDesc();
            //CountingFrequenciesArray.countFreq();
            //RemoveEvenIntegersInAarray.PrintRemoveEvenIntegers();
            //DuplicateElementInArray.DistanctElement();
            //DuplicateElementInArray.DuplicateElement();

            #endregion



            //ReverseAlternateWords.Reverse();

            #region Matrix
            //GenerateMatrix.Print3X3Matrix();
            //GenerateMatrix.Generate4X4Matrix_Edg_InnerMatrix();
            //GenerateMatrix.Generate4X4Matrix_Dignoal();
            #endregion

            //DuplicateElementInString.Remove_All_Duplicates_From_String();
            //TinyURL.idToShortURL(12345);
            // Console.WriteLine(  NumberToWord.NumberToWords(101));

            //SampleJoin obj = new SampleJoin();
            //obj.PrintPorducts();
            //obj.PrintPorducts(catId:null,DeptId:1);
            //obj.PrintPorducts(catId: 1, DeptId: null);


            #region Stack
            //StackSample myStack = new StackSample();

            //myStack.Push(10);
            //myStack.Push(20);
            //myStack.Push(30);
            //myStack.Push(40);
            //myStack.PrintStack();
            //myStack.Peek();
            //Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            //myStack.PrintStack();

            //OneArrayTwoStatck ts = new OneArrayTwoStatck(5);
            //ts.push1(5);
            //ts.push2(10);
            //ts.push2(15);
            //ts.push1(11);
            //ts.push2(7);
            //Console.WriteLine("Popped element from"+ " stack1 is " + ts.pop1());
            //ts.push2(40);
            //Console.WriteLine("Popped element from"+ " stack2 is " + ts.pop2());

            #endregion

            #region Queue
            //QueueSample Q = new QueueSample(5);

            //Q.enqueue(10);
            //Q.enqueue(20);
            //Q.enqueue(30);
            //Q.enqueue(40);
            //Q.printQueue();
            //Q.dequeue();
            #endregion

            //var BinaryTree = new BinaryTreeExample();
            //BinaryTree.TreeTrav();

            #region BinaryTree
            //BinaryTreeSimpleExample tree = new BinaryTreeSimpleExample();
            //tree.root = new BinaryTreeNode(1);
            //tree.root.left = new BinaryTreeNode(2);
            //tree.root.right = new BinaryTreeNode(3);

            //BinaryTree<string> tree = new BinaryTree<string>();

            //tree.root = new BinaryTree.Generic.Node<string>("1");
            //tree.root.left = new BinaryTree.Generic.Node<string>("2");
            //tree.root.right = new BinaryTree.Generic.Node<string>("3");
            //tree.root.left.left = new BinaryTree.Generic.Node<string>("4");
            //tree.root.left.left.left = new BinaryTree.Generic.Node<string>("4.1");
            //tree.root.left.right = new BinaryTree.Generic.Node<string>("5");

            //Console.WriteLine("Height of tree is : " + tree.MaxDepth(tree.root));

            InorderBST tree = new InorderBST();
            tree.insert(5);
            tree.insert(1);
            tree.insert(3);
            tree.insert(4);
            tree.insert(2);
            tree.insert(7);
            tree.inorder();

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("_________________");
            int[] arr = { 5, 1, 3, 4, 2, 7 };
            Node root = null;
            for (int i = 0; i < arr.Length; i++)
            {
                root = InorderBST.InsertToTree(root, arr[i]);
            }
            InorderBST.inorderTravals(root);
            Console.WriteLine(Environment.NewLine);
            InorderBST.Search(root, 11);
            #endregion

            #region LinkList
            //SampleLinkListTail list = new SampleLinkListTail();
            //list.AddLast(3);
            //list.AddLast(4);
            //list.ReadAll();
            //list.AddFirst(1);
            //list.AddFirst(2);

            //SampleLinkList<int> list = new  SampleLinkList<int>();
            //list.AddLast(3);
            //list.AddLast(4);
            //list.ReadAll();
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.ReadAll();
            #endregion

            #region Tringle
            //GenerateTraingleByInputNumber.GenerateStarTraingle();
            //GenerateStarTraingleByInputNumber.GenerateStarTraingle();
            #endregion

            #region Generic
            //SwapTwoItem<int> obj = new SwapTwoItem<int>();
            ////obj.Swap(1, 2);
            //SwapTwoItem<string> objstr = new SwapTwoItem<string>();
            //objstr.Swap("one", "two");
            #endregion

            #region Linq
            //SampleLinq obj = new SampleLinq();
            //obj.ArrayExample();
            #endregion

            #region Sort
            //SelectionSortExample.sort();
            //BubbleSortExample.bubbleSort();
            #endregion
            Console.ReadKey();
        }
    }
}
