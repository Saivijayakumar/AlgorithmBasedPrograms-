using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class FindPrimes
    {
        public static void Prime()
        {
            int count = 1;
            int flag = 1;
            int start = 0;
            int end = 1000;
            if (start == 0)
            {
                start = 2;
            }
            if (start == 2)
            {
                Console.Write(start + " ");
            }
            //Make sure the process starts with even number
            if (start % 2 == 0)
            {
                start++;
            }
            //checking only odd 
            for (int i = start; i <= end; i=i+2)
            {
                flag = 1;
                // WE TRAVERSE TILL SQUARE ROOT OF j only.
                // (LARGEST POSSIBLE VALUE OF A PRIME FACTOR)
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                {
                    Console.Write(i + " ");

                }
            }


        }
    }
}
