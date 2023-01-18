using System;
using System.Collections.Generic;
namespace Generics
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("To find maximum value betwwen 3 inputs using Generics \n");

         
            Console.WriteLine("Maximnum int  value is : " + MaximumNumberCheck<int>.Maximum(12, 22, 20));
            Console.WriteLine("Maximnum float value is : " + MaximumNumberCheck<float>.Maximum(44.2f,42.9f, 2.0f));
            Console.WriteLine("Maximnum string value is : " + MaximumNumberCheck<string>.Maximum("Apple", "Peach", "Banana"));

        }
    }
}