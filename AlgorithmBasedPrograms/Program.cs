using System;
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
            Console.WriteLine("1.Permutation Of String\n2.");
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
                default:
                    Console.WriteLine("Enter Valid Choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}
