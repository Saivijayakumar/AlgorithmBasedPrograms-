using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmBasedPrograms
{
    class PrimeAnagram
    {
        public static void ReadInputForPrimeAnagram()
        {
            Console.WriteLine("Enter the two numbers");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int result = checkPrime(Convert.ToInt32(number1)) == checkPrime(Convert.ToInt32(number2)) ? result = 1 : result = 0;
            if(result == 1)
            {
                Palindrome(Convert.ToInt32(number1));
                Palindrome(Convert.ToInt32(number2));
                bool anagramResult = AnagramDetection.CompareTwoStrings(number1, number2);
                if (anagramResult)
                {
                    Console.WriteLine($"YES {number1} and  {number2} are anagram");
                }
                else
                {
                    Console.WriteLine($"NO {number1} and  {number2} are not anagram");
                }
            }
            else
            {
                Console.WriteLine("Enter both numbers as Prime Numbers only");
            }
        }
        public static int checkPrime(int number)
        {
            int flag = 1;
            if (number == 1 || number == 0) { flag = 0; }

            for (int i = 2; i <= number / 2; ++i)
            {
                if (number % i == 0)
                {
                    flag = 0;
                    break;
                }
            }
            return flag;
        }
        public static void Palindrome(int number)
        {
            int temp = number;
            int result = 0;
            while (temp != 0)
            {
                int rem = temp % 10;
                result = result * 10 + rem;
                temp /= 10;
            }
            if (result == number)
            {
                Console.WriteLine($"{number} is a Palindrome");
            }
            else
            {
                Console.WriteLine($"{number} is a Not a Palindrome");
            }
        }
    }
}
