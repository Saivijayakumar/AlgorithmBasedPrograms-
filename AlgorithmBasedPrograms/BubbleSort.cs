using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class BubbleSort
    {
        public static void ReadInputForBubbleSort()
        {
            Console.WriteLine("Enter the size of Array:");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length];
            Console.WriteLine("Enter the elements to be Sorted(ONlY INTEGERS)");
            for (int i = 0; i < length; i++)
            {
                array[i] = (Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("Before sorted the list contains : ");
            Display(array, length);
            Sort(array,length);
            Console.Write("\nAfter sorted the list contains : ");
            Display(array, length);

        }
        private static void Sort(int[] array,int length)
        {
            for(int i=0;i<length-1;i++)
            {
                int flag = 0;
                for(int j=0;j<length-1-i;j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        flag = 1;
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
                if(flag == 0)
                {
                    break;
                }
            }
            
        }
        private  static void  Display(int[] array,int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

    }
}
