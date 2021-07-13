using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class InsertionSort
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number of items to be inserted:");
            int length = Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            Console.WriteLine("Enter the elements to be inserted");
            for (int i = 0; i < length; i++)
            {
                list.Add(Console.ReadLine());
            }
            Console.Write("Before sorted the list contains : ");
            foreach(var i in list)
            {
                Console.Write(i + " ");
            }
                
            Console.Write("\nAfter sorted the list contains : ");
            Sort(list);

        }
        private static void Sort(List<string> list)
        {
            int n = list.Count;
            for (int i = 1; i < n; ++i)
            {
                string key = list[i];
                int j = i - 1;
                while (j >= 0 && list[j].CompareTo(key) > 0)
                {
                    list[j + 1] = list[j];
                    j = j - 1;
                }
                list[j + 1] = key;
            }
            foreach (var i in list)
                Console.Write(i + " ");
        }
    }
}
