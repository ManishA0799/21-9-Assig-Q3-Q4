using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_9__Assig
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            int max = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] > max)
                    max = Array[i];
            }
            Console.WriteLine("Maximum value is : " + max);




            int[] Array = new int[] { 12, 24, 03, 14,45, 6, 27 };
            int min = Array[0];
            for (int i = 1; i < Array.Length; i++)
            {
                if (Array[i] < min)
                    min = Array[i];
            }
            Console.WriteLine("Maximum value is : " + min);




        }
       
    }
}
