using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class BinarySearchClass
    {
        public static void BinarySearch(List<string> wordList)
        {
            //Local Variables
            int mid, start = 0;
            int end = wordList.Count - 1;
            bool found = false;

            //geting input 
            Console.Write("Enter the word to be search : ");
            string search = Console.ReadLine();

            while (start <= end)
            {
                mid = start + (end - start) / 2;
                int flag = search.CompareTo(wordList[mid]);
                if (flag == 0)
                {
                    Console.WriteLine("The given \"{0}\" is \" PRESENT\" in  Text File!", search);
                    found = true;
                    break;
                }
                else if (flag > 0)
                {
                    start = mid + 1;//Reduce the first half 
                }
                else
                {
                    end = mid - 1;//Reduce the second half
                }
            }
            if (!found)
            {
                Console.WriteLine("The given \"{0}\" is \" NOT PRESENT \" in  Text File!", search);
            }

        }
    }
}
