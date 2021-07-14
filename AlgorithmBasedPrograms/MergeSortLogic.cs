using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class MergeSortLogic
    {
        public static void GetInputsForMergeSort()
        {
            Console.WriteLine("******Merge Sort********");
            Console.WriteLine("Enter the size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] array = new string[size];
            Console.WriteLine("Enter the string one by one you want to sort");
            for (int i = 0; i < size; i++)
            {
                array[i] = Console.ReadLine();
            }
            Console.WriteLine("*******Before Sort***********");
            display(array);
            merge(array, 0, size - 1);
            Console.WriteLine("\n*******After Sort***********");
            display(array);
        }
        public static void merge(string[] array, int lb, int ub)
        {
            if (lb < ub)
            {
                int mid = (lb + ub) / 2;
                merge(array, lb, mid);
                merge(array, mid + 1, ub);
                mergeing(array, lb, mid, ub);
            }
        }
        public static void mergeing(string[] array, int lb, int mid, int ub)
        {
            string[] barray = new string[100];
            int i = lb;
            int j = mid + 1;
            int k = lb;
            while (i <= mid && j <= ub)
            {
                if ((array[i].CompareTo(array[j])) > 0)
                {
                    barray[k] = array[j];
                    j++;
                }
                else
                {
                    barray[k] = array[i];
                    i++;
                }
                k++;
            }
            if (i > mid)
            {
                while (j <= ub)
                {
                    barray[k] = array[j];
                    j++;
                    k++;
                }
            }
            else
            {
                while (i <= mid)
                {
                    barray[k] = array[i];
                    i = i + 1;
                    k++;
                }
            }
            for (k = lb; k <= ub; k++)
            {
                array[k] = barray[k];
            }

        }
        public static void display(string[] array)
        {
            foreach (string di in array)
            {
                Console.Write(di+" ");
            }
        }


    }
}
