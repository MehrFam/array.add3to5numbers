using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array.add3to5numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
                int[] num_array;
                Console.WriteLine("please enter how many numbers you want to enter");
                int len = Convert.ToInt32(Console.ReadLine());
                num_array = new int[len];
                for (int j = 0; j < len; j++)
                {
                    Console.WriteLine("please enter number");
                    num_array[j] = Convert.ToInt32(Console.ReadLine());
                }
                for (int i = 0; i < num_array.Length; i++)
                {
                    Console.WriteLine(num_array[i] + 3);
                }
                Console.ReadKey();

            }
    }
}
