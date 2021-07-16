using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class Program
    {
        /// <summary>
        /// ------------------>Welcome To Algorithm Based Programs<-----------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t--------------->Welcome To Algorithm Based Programs<-----------------\n");
            Console.WriteLine("-----------{MENU}-----------");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1.Permutation Of String\n2.Binary Search\n3.Insertion Sort\n4.Bubble Sort\n5.Merge Sort\n6.Anagram Detection\n7.Prime Numbers From 0 to 1000\n8.Find Anagram,Prime,Palindrom\n9.Question to find your number\n10.Customer Regex Message");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Enter Your Choice");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.Write("Enter The  String You Want Permute :");
                    string str = Console.ReadLine();
                    int length = str.Length;
                    Console.WriteLine("The Permutations For {0} is ",str);
                    PermutationsOfString.permute(str, 0, length - 1);
                    break;
                case "2":
                    string filepath = File.ReadAllText(@"C:\Users\SaiVijay\source\repos\AlgorithmBasedPrograms\AlgorithmBasedPrograms\wordlist.txt");
                    List<string> wordList = new List<string>(filepath.Split(' '));
                    wordList.Sort();
                    BinarySearchClass.BinarySearch(wordList);
                    break;
                case "3":
                    InsertionSort<int>.ReadInput();
                    break;
                case "4":
                    BubbleSort.ReadInputForBubbleSort();
                    break;
                case "5":
                    MergeSortLogic.GetInputsForMergeSort();
                    break;
                case "6":
                    AnagramDetection.ReadAnagramInputs();
                    break;
                case "7":
                    FindPrimes.Prime();
                    break;
                case "8":
                    PrimeAnagram.ReadInputForPrimeAnagram();
                    break;
                case "9":
                    GuessTheNumber.ThinkingNumber();
                    break;
                case "10":
                    RegexProgram.CustomerRegexMessage();
                    break;
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
