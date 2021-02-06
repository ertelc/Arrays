
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("This is an auto populated array displaying 25 elements.");
            /*
              Automatically populate an array
            */
                    
                    int pop_array = 0;
           
            int[] Nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

            for (int i = 0; i < Nums.Length; i++)
                Console.WriteLine(Nums[i]);

            for (int i = 0; i < Nums.Length; i++)
                Nums[i] = Nums[i] + 1;
              
               
        }
    }
}