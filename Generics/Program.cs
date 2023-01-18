using System;
using System.Collections.Generic;
namespace Generics
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("To find maximum value betwwen 3 inputs using Generics \n");

         
            Console.WriteLine("Maximnum int  value is : " + MaximumNumberCheck.Maximum(12, 22, 20));
            Console.WriteLine("Maximnum float value is : " + MaximumNumberCheck.Maximum(44.2,42.9, 2.0));
            Console.WriteLine("Maximnum string value is : " + MaximumNumberCheck.Maximum("Apple", "Peach", "Banana"));

        }
    }
}